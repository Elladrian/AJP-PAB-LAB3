using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models;

namespace WinFormsApp1.ModelsDapper
{
    public interface IKodyPocztoweDapperRepository
    {
        public List<KodyPocztoweDapper> GetKodyPocztowe(int? id, string? kodPocztowy, string? adres, string? miejscowosc, string? wojewodztwo, string? powiat);
    }
}
