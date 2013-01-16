using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;

namespace GUSGives.Preprocessing
{
    public class AddressTools
    {
        private HashSet<string> Streets = new HashSet<string>();
        private HashSet<string> Suburbs = new HashSet<string>();

        private void ExtractOsmFile(string osmFile)
        {
            Streets.Clear();
            Suburbs.Clear();
            using (XmlTextReader reader = new XmlTextReader(osmFile))
            {
                while (reader.Read())
                {
                    if (reader.NodeType == XmlNodeType.Element && reader.Name == "node")
                    {
                        bool place = false;
                        string suburb = "";
                        while (reader.Read() && reader.NodeType != XmlNodeType.Element)
                        {

                        }
                        if (reader.Name == "tag")
                        {
                            do
                            {
                                if (reader.NodeType == XmlNodeType.Element && reader.Name == "tag")
                                {
                                    string key = reader.GetAttribute("k");
                                    string value = reader.GetAttribute("v");
                                    if (string.Compare(key, "place", true) == 0 && string.Compare(value, "suburb", true) == 0)
                                    {
                                        place = true;
                                    }
                                    else if (string.Compare(key, "name", true) == 0)
                                    {
                                        suburb = value;
                                    }
                                }
                                else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "node")
                                {
                                    break;
                                }
                                if (place && !string.IsNullOrEmpty(suburb) && !Suburbs.Contains(suburb))
                                {
                                    Suburbs.Add(suburb);
                                    break;
                                }
                            }
                            while (reader.Read());
                        }
                    }
                    else if (reader.NodeType == XmlNodeType.Element && reader.Name == "way")
                    {
                        bool residential = false;
                        string street = "";
                        while (reader.Read())
                        {
                            if (reader.NodeType == XmlNodeType.Element && reader.Name == "tag")
                            {
                                string key = reader.GetAttribute("k");
                                string value = reader.GetAttribute("v");
                                if (string.Compare(key, "highway", true) == 0 && string.Compare(value, "residential", true) == 0)
                                {
                                    residential = true;
                                }
                                else if (string.Compare(key, "name", true) == 0)
                                {
                                    street = value;
                                }
                            }
                            else if (reader.NodeType == XmlNodeType.EndElement && reader.Name == "way")
                            {
                                break;
                            }
                            if (residential && !string.IsNullOrEmpty(street) && !Streets.Contains(street))
                            {
                                Streets.Add(street);
                                break;
                            }
                        }
                    }
                }
            }
        }

        public void WriteToFiles(string osmFile, string streetsFile, string suburbFile)
        {
            ExtractOsmFile(osmFile);

            using (TextWriter writer = File.CreateText(streetsFile))
            {
                foreach (string street in Streets.OrderBy(s => s))
                {
                    writer.WriteLine(street);
                }
            }

            using (TextWriter writer = File.CreateText(suburbFile))
            {
                foreach (string suburb in Suburbs.OrderBy(s => s))
                {
                    writer.WriteLine(suburb);
                }
            }
        }
    }
}
