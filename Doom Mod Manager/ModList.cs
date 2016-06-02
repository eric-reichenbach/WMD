using System.Collections.Generic;
using System.IO;

namespace WMD
{
    class ModList : List<Mod>
    {
        private PM pm = PM.getInstance();
        public ModList()
        {
            var directory = new DirectoryInfo(pm.MODDIRECTORY);
            if (!directory.Exists)
                directory.Create();
            FileInfo[] files = directory.GetFiles("*", SearchOption.AllDirectories);

            foreach (FileInfo fi in files)
            {
                Add(new Mod(fi));
            }
            Sort();
        }
    }
}