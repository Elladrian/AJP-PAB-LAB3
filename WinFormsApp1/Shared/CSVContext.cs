using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
using System.Diagnostics;

namespace WinFormsApp1.Shared
{
    public class CSVContext : IDisposable
    {
        static List<Kody> importedKody = new();

        public List<Kody> ImportedKody { get { return importedKody; } }

        public CSVContext()
        {
            importCSV();
        }

        static void importCSV()
        {
            var csvConfig = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = true,
                Delimiter = ";",
                MemberTypes = MemberTypes.Properties,
                HeaderValidated = null,
                MissingFieldFound = null,
            };

            using (var reader = new StreamReader(@"kody.csv"))
            using (var csv = new CsvReader(reader, csvConfig))
            {
                importedKody = csv.GetRecords<Kody>().ToList();
                Console.WriteLine($"Records Imported: {importedKody.Count}");
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public void Dispose(bool disposing)
        {
            if (disposing)
            {
                importedKody = null;
            }
        }
    }

    public class Kody
    {
        [Name("KOD POCZTOWY")]
        public string kod_pocztowy { get; set; } = "";
        [Name("ADRES")]
        public string adres { get; set; } = "";
        [Name("MIEJSCOWOŚĆ")]
        public string miejscowosc { get; set; } = "";
        [Name("WOJEWÓDZTWO")]
        public string wojewodztwo { get; set; } = "";
        [Name("POWIAT")]
        public string powiat { get; set; } = "";
    }
}
