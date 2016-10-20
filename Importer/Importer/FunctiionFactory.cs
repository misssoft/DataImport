using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Importer
{
    public class FunctiionFactory
    {
        public static Action CreateImportDataFunction()
        {
            return () => ImportDataFunction.ImportData(
                Functions.GetZipFile,
                Functions.UnzipFile,
                Functions.Transform
                );
        }
    }
}
