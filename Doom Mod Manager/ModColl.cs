using System.Collections.Generic;
using System.IO;

namespace WMD
{
    class ModColl : List<Mod>
    {
        public FileInfo config
        {
            get
            {
                var fi = new FileInfo(PM.CONFIGDIRECTORY + "//" + name + ".ini");

                if (!fi.Exists)
                {
                    var selectedSrcPrt = new FileInfo(PM.getInstance().SrcPrt);
                    if (srcPrt != null)
                        if (srcPrt.Exists)
                            selectedSrcPrt = srcPrt;
                    var dir = selectedSrcPrt.Directory.GetFiles("*.ini");
                    foreach (var file in dir)
                    {
                        if (file.Name.Contains(selectedSrcPrt.Name.Replace(".exe", "")))
                        {
                            file.CopyTo(fi.FullName);
                            return fi;
                        }
                    }

                }

                return fi;
            }
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