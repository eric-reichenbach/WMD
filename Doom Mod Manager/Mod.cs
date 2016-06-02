using System;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WMD
{
    class Mod : System.IComparable
    {
        public FileInfo fileI { get; set; }

        public string displayText { get { return ToString(); } }

        public int loadOrder { get; set; }

        public bool selected { get; set; }

        public Mod(FileInfo fi)
        {
            fileI = fi;
            selected = false;
            loadOrder = 0;
        }

        public Mod(bool selected, int loadOrder, string fi)
        {
            fileI = new FileInfo(PM.MODDIRECTORY + "\\" + fi);
            this.selected = selected;
            this.loadOrder = loadOrder;
        }

        public Mod(bool selected, string loadOrder, string fi)
        {
            fileI = new FileInfo(PM.MODDIRECTORY + "\\" + fi);
            this.selected = selected;
            int i = 0;
            int.TryParse(loadOrder, out i);
            this.loadOrder = i;
        }

        public Mod(bool selected, string loadOrder, FileInfo fi)
        {
            fileI = fi;
            this.selected = selected;
            int i = 0;
            int.TryParse(loadOrder, out i);
            this.loadOrder = i;
        }

        public override string ToString()
        {
            var str = fileI.FullName.Replace(new DirectoryInfo(PM.MODDIRECTORY).FullName, "");
            int count = str.Split('\\').Length - 1;
            if (count == 1)
            {
                str = str.Replace("\\", "");

            }
            return str;
        }

        public int CompareTo(object obj)
        {
            Mod m = (Mod)obj;
            if (displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal) && !m.displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal))
                return -1;
            if (!displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal) && m.displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal))
                return 1;
            /*
            if (displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal) && (Regex.IsMatch(m.displayText.ToLower().Trim(), @"^\d+")))
                return -1;
                */
            return (string.Compare(displayText.ToLower(), m.displayText.ToLower(), StringComparison.Ordinal));
        }
    }
}