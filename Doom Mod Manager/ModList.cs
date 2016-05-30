using System.Collections.Generic;
using System.IO;

namespace WMD
{
    class ModList : List<Mod>
    {
        public ModList()
        {
            var directory = new DirectoryInfo(PM.MODDIRECTORY);
            if (!directory.Exists)
                directory.Create();
            FileInfo[] files = directory.GetFiles();

            foreach (FileInfo fi in files)
                Add(new Mod(fi));
        }
    }
}