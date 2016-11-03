using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CRC_Hasher
{
    public partial class Form1 : Form
    {
        private List<HashFile> _hashes;
        private string _selfHash;

        public Form1()
        {

          /*  if (!_executableHash.Equals(_originalHash))
            {
                MessageBox.Show("ВНИМАНИЕ! CRC32 не совпало!");
                Application.Exit();
                return;
            }*/

            InitializeComponent();

            _lbRealSelfValue.Text = CalculateSelfCrc32();

            _hashes = new List<HashFile>();
            _selfHash = string.Empty;

            LoadAndUpdateIfNeed(true);          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var fbd = new FolderBrowserDialog();
            var result = fbd.ShowDialog();
            if (result != DialogResult.OK)
                return;

            if (!string.IsNullOrWhiteSpace(fbd.SelectedPath))
                CalculateAllHashes(fbd.SelectedPath);

            LoadAndUpdateIfNeed();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var fbd = new OpenFileDialog();
            var result = fbd.ShowDialog();
            if (result != DialogResult.OK)
                return;

            var compareTypes = ComareCrc32(fbd.FileName);
            var text = string.Empty;

            switch (compareTypes)
            {
                case CompareTypes.Same:
                    text = "CRC32 файла совпадает лежащим в хранилище.";
                    break;
                case CompareTypes.NotFound:
                    text = "Файл в хранилище не найден.";
                    break;
                case CompareTypes.NotSame:
                    text = "CRC32 файла не совпадает лежащим в хранилище.";
                    break;
            }

            MessageBox.Show(text);
        }

        public void CalculateAllHashes(string path)
        {
            _hashes.Clear();
            foreach (var file in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
                _hashes.Add(new HashFile { Name = file, Crc32 = CalculateHash(file) });

            XmlStorage.Save(_hashes, _selfHash);
        }

        public static string CalculateHash(string file)
        {
            var crc32 = new Crc32();
            var hash = string.Empty;

            using (var fs = File.Open(file, FileMode.Open, FileAccess.Read))
                hash = crc32.ComputeHash(fs).Aggregate(hash, (current, b) => current + b.ToString("x2").ToLower());

            return hash;
        }

        public void LoadAndUpdateIfNeed(bool file = false)
        {
            if (file)
            {
                _hashes = XmlStorage.Load(out _selfHash);
                _lbSelfValue.Text = _selfHash;
            }

            dataGridView1.Rows.Clear();
            foreach (var hashFile in _hashes)
                dataGridView1.Rows.Add(hashFile.Name, hashFile.Crc32);
        }

        public CompareTypes ComareCrc32(string filename)
        {
            var hashFile = _hashes.Find(x => x.Name.Equals(filename));
            if (hashFile == null)
                return CompareTypes.NotFound;

            return hashFile.Crc32.Equals(CalculateHash(filename)) ? CompareTypes.Same : CompareTypes.NotSame;
        }

        private void _btSaveSelf_Click(object sender, EventArgs e)
        {
            _selfHash = CalculateSelfCrc32();
            XmlStorage.Save(_hashes, _selfHash);
        }

        public static string CalculateSelfCrc32()
        {
            // hack
            File.Copy(Application.ExecutablePath, "calc_copy.exe");
            var selfCrc32 = CalculateHash("calc_copy.exe");
            File.Delete("calc_copy.exe");
            return selfCrc32;
        }

    }
}
