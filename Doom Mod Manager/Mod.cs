using System;
using System.IO;

namespace WMD
{
    class Mod : IComparable
    {
        public string displayText { get { return ToString(); } }
        public FileInfo fileI { get; set; }
        public int loadOrder { get; set; }

        public bool selected { get; set; }

        public Mod(FileInfo fi)
        {
            fileI = fi;
            selected = false;
            loadOrder = 0;
        }

        public Mod(bool selected, int loadOrder, string modDir, string fi)
        {
            fileI = new FileInfo(modDir + "\\" + fi);
            this.selected = selected;
            this.loadOrder = loadOrder;
        }

        public Mod(bool selected, string loadOrder, string modDir, string fi)
        {
            fileI = new FileInfo(modDir + "\\" + fi);
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

        public int CompareTo(object obj)
        {
            Mod m = (Mod)obj;
            if (displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal) && !m.displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal))
                return -1;
            if (!displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal) && m.displayText.ToLower().Trim().StartsWith("\\", StringComparison.Ordinal))
                return 1;

            return (string.Compare(displayText.ToLower(), m.displayText.ToLower(), StringComparison.Ordinal));
        }

        public override string ToString()
        {
            var str = fileI.FullName.Replace(new DirectoryInfo(PM.getInstance().MODDIRECTORY).FullName, "");
            int count = str.Split('\\').Length - 1;
            if (count == 1)
            {
                str = str.Replace("\\", "");
            }
            str = str.Replace("\\", "/");
            return str;
        }
    }
}