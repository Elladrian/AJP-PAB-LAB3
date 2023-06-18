using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ModelsDapper
{
    public class KodyPocztoweDapper
    {
        public int Id { get; set; }

        public string KodPocztowy { get; set; } = null!;

        public string Adres { get; set; } = null!;

        public string Miejscowosc { get; set; } = null!;

        public string Wojewodztwo { get; set; } = null!;

        public string Powiat { get; set; } = null!;
    }
}
