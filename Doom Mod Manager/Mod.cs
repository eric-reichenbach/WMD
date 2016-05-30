using System.IO;

namespace WMD
{
    class Mod
    {
        public FileInfo fileI { get; set; }

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
            return fileI.Name;
        }
    }
}