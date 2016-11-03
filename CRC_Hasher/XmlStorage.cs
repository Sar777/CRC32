using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace CRC_Hasher
{
    public class XmlStorage
    {
        private static readonly string Filename;

        static XmlStorage()
        {
            Filename = "crc32.xml";
        }

        public static void Save(List<HashFile> hashes, string selfHash)
        {
            var xWriter = new XmlTextWriter(Filename, Encoding.UTF8);
            xWriter.WriteStartDocument();

            xWriter.WriteStartElement("Hashes");

            if (hashes.Count > 0)
            {
                foreach (var hashFile in hashes)
                {
                    xWriter.WriteStartElement("File");
                    xWriter.WriteElementString("Name", hashFile.Name);
                    xWriter.WriteElementString("Crc32", hashFile.Crc32);
                    xWriter.WriteEndElement();
                }
            }

            if (!string.IsNullOrEmpty(selfHash))
            {
                // личный хэш хэш
                xWriter.WriteStartElement("Self");
                xWriter.WriteElementString("Crc32", selfHash);
                xWriter.WriteEndElement();
            }

            xWriter.WriteEndElement();

            xWriter.WriteEndDocument();
            xWriter.Close();
        }

        public static List<HashFile> Load(out string selfHash)
        {
            selfHash = string.Empty;
            var hashes = new List<HashFile>();
            var document = new XmlDocument();
            try
            {
                document.Load(Filename);
            }
            catch (Exception)
            {
                return hashes;
            }

            if (string.IsNullOrEmpty(document.InnerXml))
                return hashes;

            var node = document.SelectSingleNode("Hashes");
            var prop = node?.SelectNodes("File");
            if (prop != null)
                hashes.AddRange(from XmlNode item in prop select new HashFile { Name = item.ChildNodes[0].InnerText, Crc32 = item.ChildNodes[1].InnerText });

            var selfNodes = node?.SelectNodes("Self");
            if (selfNodes?[0] != null)
                selfHash = selfNodes[0].InnerText;

            return hashes;
        }
    }
}
