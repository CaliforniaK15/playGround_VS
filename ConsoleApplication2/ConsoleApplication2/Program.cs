using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApplication2
{
    public static class extension
    {
        public static void dirInfoCopy(this DirectoryInfo dirinfo, string value, string value2)
        {
            object[] getdir = dirinfo.GetDirectories(value);
            foreach(object make in getdir)
            {
                //to somethign
            }         

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo info = new DirectoryInfo("");
            info.dirInfoCopy("", "");
        }
    }
}
