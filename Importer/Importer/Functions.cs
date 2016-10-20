using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importer
{
    public static class Functions
    {
        public static FileInfo GetZipFile()
        {
            return new FileInfo("");
        }

        public static IEnumerable<FileInfo> UnzipFile(FileInfo zipFile)
        {
            return new List<FileInfo>();
        }

        public static IEnumerable<PeopleData> Transform(IEnumerable<FileInfo> files)
        {
            return new List<PeopleData>();
        }
    }
}
