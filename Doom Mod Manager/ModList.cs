using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;

namespace WMD
{
    class ModList : List<Mod>
    {
        readonly PM pm = PM.getInstance();

        public ModList(bool filterSelectedOnly = false)
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