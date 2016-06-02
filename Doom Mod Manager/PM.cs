using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml;

namespace WMD
{
    class PM
    {
        public const string CONFIGDIRECTORY = @".\WMDCONF";
        public const string SAVEDIRECTORY = @".\WMDSAVE";
        public const string FILENAME = @".\WMD.xml";
        public const string LANGFILE = @".\wmd-lang.xml";
        public const string MODDIRECTORY = @".\WMD";
        List<ModColl> modCollList;
        static PM param;
        Dictionary<string, string> wDict;
        bool disableConfirm;
        string srcPrt;
        bool stopAskingVar;

        public bool DisableConfirm
        {
            get { return disableConfirm; }
            set
            {
                disableConfirm = value;
                write2XML();
            }
        }

        public string SrcPrt
        {
            get { return srcPrt; }
            set
            {
                srcPrt = value;
                write2XML();
            }
        }

        public bool StopAskingVar
        {
            get { return stopAskingVar; }
            set
            {
                stopAskingVar = value;
                write2XML();
            }
        }

        PM()
        {
            Directory.CreateDirectory(CONFIGDIRECTORY);
            Directory.CreateDirectory(SAVEDIRECTORY);
            Directory.CreateDirectory(MODDIRECTORY);
            modCollList = new List<ModColl>();
            modCollList = read2XML();
            if (!string.IsNullOrEmpty(srcPrt))
            {
                var fiZand = new FileInfo("./zandronum.exe");
                var fiZdoom = new FileInfo("./zdoom.exe");
                var fiGZdoom = new FileInfo("./gzdoom.exe");
                if (fiZand.Exists)
                    SrcPrt = fiZand.FullName;
                else if (fiZdoom.Exists)
                    SrcPrt = fiZdoom.FullName;
                else if (fiGZdoom.Exists)
                    SrcPrt = fiGZdoom.FullName;
            }
        }

        public static PM getInstance()
        {
            if (param == null)
                param = new PM();
            return param;
        }

        public void addModColl(ModColl mc)
        {
            modCollList.Add(mc);
            write2XML();
        }

        public void deleteEverything()
        {
            var Cdirectory = new DirectoryInfo(CONFIGDIRECTORY);
            foreach (FileInfo file in Cdirectory.GetFiles())
                file.Delete();
            foreach (DirectoryInfo dir in Cdirectory.GetDirectories())
                dir.Delete(true);
            var Sdirectory = new DirectoryInfo(SAVEDIRECTORY);
            foreach (FileInfo file in Sdirectory.GetFiles())
                file.Delete();
            foreach (DirectoryInfo dir in Sdirectory.GetDirectories())
                dir.Delete(true);

            modCollList = new List<ModColl>();
            modCollList.Add(new ModColl("[none]", ""));
            srcPrt = "";
            stopAskingVar = false;
            File.Delete(new FileInfo(FILENAME).FullName);

            write2XML();
        }

        public List<ModColl> getModColllist()
        {
            return modCollList;
        }

        public void langtxt2XML()
        {
            var Writer = new XmlTextWriter(LANGFILE, Encoding.Unicode);

            // Write XML with Indent

            Writer.Formatting = Formatting.Indented;

            // Write XML Declaration

            Writer.WriteStartDocument(true);

            // Writing Comments in XML File

            Writer.WriteComment("Language string edition table. You must only change the value, not the key!");

            // Root Element

            Writer.WriteStartElement("wmd-lang");

            foreach (var item in wDict)
            {
                Writer.WriteStartElement("string");

                Writer.WriteStartElement("key");
                Writer.WriteString(item.Key);
                Writer.WriteEndElement();

                Writer.WriteStartElement("value");
                Writer.WriteString(item.Value);
                Writer.WriteEndElement();

                Writer.WriteEndElement();
            }
            Writer.WriteEndElement();
            Writer.WriteEndDocument();

            Writer.Flush();

            Writer.Close();
        }

        public void removeModColl(ModColl mc)
        {
            if (mc.config != null)
                if (mc.config.Exists)
                    mc.config.Delete();
            modCollList.Remove(mc);
            write2XML();
        }

        public string txt(string txtKey, string param = "")
        {
            return txt(txtKey, new[] { param });
        }

        public string txt(string txtKey, string[] param)
        {
            var dict = langXML2txt();
            if (dict == null)
                dict = new Dictionary<string, string>();
            var txt = txtKey;
            if (dict.ContainsKey(txtKey))
                txt = dict[txtKey];
            if (wDict == null)
                wDict = new Dictionary<string, string>();
            if (!wDict.ContainsKey(txtKey))
                wDict.Add(txtKey, txt);

            foreach (string s in param)
            {
                var regex = new Regex(Regex.Escape("$"));
                txt = regex.Replace(txt, s, 1);
            }
            return txt;
        }

        Dictionary<string, string> langXML2txt()
        {
            var fi = new FileInfo(LANGFILE);
            var dict = new Dictionary<string, string>();

            var reader = new XmlTextReader(LANGFILE);
            if (!fi.Exists)
                return null;
            try
            {
                while (reader.Read())
                {
                    if (!(reader.NodeType == XmlNodeType.Element) && !(reader.Name == "string"))
                        continue;
                    bool quit = false;
                    var key = "";
                    var value = "";
                    while (quit == false)
                    {
                        reader.Read();
                        switch (reader.NodeType)
                        {
                            case XmlNodeType.EndElement:
                                if (reader.Name == "string")
                                {
                                    quit = true;
                                    dict.Add(key, value);
                                }
                                break;

                            case XmlNodeType.Element:
                                if (reader.Name == "key")
                                {
                                    reader.Read();
                                    key = reader.Value.ToString().Trim().Replace("\t", "");
                                }
                                else if (reader.Name == "value")
                                {
                                    reader.Read();
                                    value = reader.Value.ToString().Trim();
                                }

                                break;
                        }
                    }
                }
                reader.Close();
            }
            catch (XmlException)
            {
                reader.Close();
                fi.Delete();
            }

            return dict;
        }
        public ModColl readXmlPackage(FileInfo fi)
        {
            ModColl nmc = null;
            var reader = new XmlTextReader(fi.FullName);
            if (fi.Exists)
                try
                {
                    while (reader.Read())
                    {
                        bool quit = false;
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Wadpack"))
                        {
                            nmc = new ModColl(reader.GetAttribute("name"), reader.GetAttribute("srcPrt"));

                            while (quit == false)
                            {
                                reader.Read();
                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.EndElement: //Display the end of the element.
                                        if (reader.Name == "Wadpack")
                                        {
                                            quit = true;
                                        }
                                        break;

                                    case XmlNodeType.Element: //Display the text in each element.
                                        if (reader.Name == "Wad")
                                        {
                                            string attr = "0";
                                            if (reader.HasAttributes)
                                                attr = reader.GetAttribute("loadorder");
                                            reader.Read();
                                            nmc.Add(new Mod(true, attr, new FileInfo(reader.Value.ToString())));
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    reader.Close();
                    fi.Delete();
                }
                catch (XmlException)
                {
                    reader.Close();
                    fi.Delete();
                }

            return nmc;
        }

        List<ModColl> read2XML()
        {
            var fi = new FileInfo(FILENAME);
            var nlmc = new List<ModColl>();
            nlmc.Add(new ModColl("[none]", ""));
            var reader = new XmlTextReader(FILENAME);
            stopAskingVar = false;
            disableConfirm = false;
            if (fi.Exists)
                try
                {
                    while (reader.Read())
                    {
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Var"))
                            stopAskingVar = (reader.GetAttribute("stopasking").Equals("1"));
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Confirm"))
                            disableConfirm = (reader.GetAttribute("disabled").Equals("1"));
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "SrcPrt"))
                            srcPrt = reader.GetAttribute("link");
                        bool quit = false;
                        if ((reader.NodeType == XmlNodeType.Element) && (reader.Name == "Wadpack"))
                        {
                            var nmc = new ModColl(reader.GetAttribute("name"), reader.GetAttribute("srcPrt"));

                            while (quit == false)
                            {
                                reader.Read();
                                switch (reader.NodeType)
                                {
                                    case XmlNodeType.EndElement: //Display the end of the element.
                                        if (reader.Name == "Wadpack")
                                        {
                                            quit = true;
                                            nlmc.Add(nmc);
                                        }
                                        break;

                                    case XmlNodeType.Element: //Display the text in each element.
                                        if (reader.Name == "Wad")
                                        {
                                            string attr = "0";
                                            if (reader.HasAttributes)
                                                attr = reader.GetAttribute("loadorder");
                                            reader.Read();
                                            nmc.Add(new Mod(true, attr, new FileInfo(reader.Value.ToString())));
                                        }
                                        break;
                                }
                            }
                        }
                    }
                    reader.Close();
                }
                catch (XmlException)
                {
                    reader.Close();
                    fi.Delete();
                }

            return nlmc;
        }

        void write2XML()
        {
            var Writer = new XmlTextWriter(FILENAME, Encoding.ASCII);

            // Write XML with Indent

            Writer.Formatting = Formatting.Indented;

            // Write XML Declaration

            Writer.WriteStartDocument(true);

            // Writing Comments in XML File

            Writer.WriteComment("DOOM WAD MANAGER COLLECTIONS XML");

            // Root Element

            Writer.WriteStartElement("WMD");

            Writer.WriteStartElement("Var");
            if (stopAskingVar)
                Writer.WriteAttributeString("stopasking", "1");
            else
                Writer.WriteAttributeString("stopasking", "0");
            Writer.WriteEndElement();

            Writer.WriteStartElement("SrcPrt");
            if (!string.IsNullOrEmpty(srcPrt))
                Writer.WriteAttributeString("link", srcPrt);
            Writer.WriteEndElement();

            Writer.WriteStartElement("Wadpacks");
            foreach (var mc in modCollList)
            {
                if (mc.Count == 0)
                    continue;
                Writer.WriteStartElement("Wadpack");
                Writer.WriteAttributeString("name", mc.name);
                if (mc.srcPrt != null)
                    Writer.WriteAttributeString("srcPrt", mc.srcPrt.FullName);

                foreach (var m in mc)
                {
                    Writer.WriteStartElement("Wad");
                    Writer.WriteAttributeString("loadorder", m.loadOrder.ToString());
                    var filePath = m.fileI.FullName;
                    var modPath = new DirectoryInfo(MODDIRECTORY);
                    filePath = filePath.Replace(modPath.FullName, MODDIRECTORY);
                    Writer.WriteString(filePath);

                    Writer.WriteEndElement(); // Mod End Tag
                }
                Writer.WriteEndElement(); // Collection End Tag

            }
            Writer.WriteEndElement();
            Writer.WriteEndDocument();

            Writer.Flush();

            Writer.Close();
        }
    }
}