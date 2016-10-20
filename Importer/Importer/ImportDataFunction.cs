using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importer
{
    public static class ImportDataFunction
    {
        public static void ImportData(
            Func<FileInfo> GetZipFile,
            Func<FileInfo, IEnumerable<FileInfo>> UnzipFile,
            Func<IEnumerable<FileInfo>, IEnumerable<PeopleData>> Transform
            )
        {
            var file = GetZipFile();
            var extractedfiles = UnzipFile(file);
            var peopleList = Transform(extractedfiles);
        }
    }

    public class PeopleData{}
}
