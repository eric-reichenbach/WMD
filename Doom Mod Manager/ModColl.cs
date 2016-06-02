using System.Collections.Generic;
using System.IO;

namespace WMD
{
    class ModColl : List<Mod>
    {
        public FileInfo config
        {
            get { return new FileInfo(PM.CONFIGDIRECTORY + "//" + name + ".ini"); }
        }

        public string name { get; set; }

        public DirectoryInfo save
        {
            get { return getSaveDir(); }
        }

        public FileInfo srcPrt { get; set; }

        public ModColl(string name, string srcPrt)
        {
            this.name = name;

            if (!string.IsNullOrEmpty(srcPrt))
            {
                this.srcPrt = new FileInfo(srcPrt);
            }
        }

        public DirectoryInfo getSaveDir()
        {
            DirectoryInfo di = new DirectoryInfo(PM.SAVEDIRECTORY + "//" + name + "//");
            if (!di.Exists)
                di.Create();
            return di;
        }

        public override string ToString()
        {
            return name + ((srcPrt != null) ? " {" + srcPrt.Name + "}" : "");
        }
    }
}