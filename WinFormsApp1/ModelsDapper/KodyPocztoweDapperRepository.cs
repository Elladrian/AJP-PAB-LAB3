using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1.ModelsDapper
{
    public class KodyPocztoweDapperRepository : IKodyPocztoweDapperRepository
    {
        private readonly DapperContext _context;

        public KodyPocztoweDapperRepository(DapperContext context)
        {
            _context = context;
        }

        public List<KodyPocztoweDapper> GetKodyPocztowe(int? id, string? kodPocztowy, string? adres, string? miejscowosc, string? wojewodztwo, string? powiat)
        {
            var filtr = "SELECT Id, Kod_pocztowy AS KodPocztowy, Adres, Miejscowosc, Wojewodztwo, Powiat FROM Kody_Pocztowe";
            int counter = 0;

            if (id != null)
            {
                filtr += $" WHERE (CAST(CONVERT(VARCHAR(MAX), Id) AS INT) LIKE '%{id}%')";
                counter++;
            }
            if (miejscowosc != null)
            {
                filtr += (counter > 0 ? $" AND (Miejscowosc LIKE '%{miejscowosc}%')" : $" WHERE (Miejscowosc LIKE '%{miejscowosc}%')");
                counter++;
            }
            if (powiat != null)
            {
                filtr += (counter > 0 ? $" AND (Powiat LIKE '%{powiat}%')" : $" WHERE (Powiat LIKE '%{powiat}%')");
                counter++;
            }
            if (adres != null)
            {
                filtr += (counter > 0 ? $" AND (Adres LIKE '%{adres}%')" : $" WHERE (Adres LIKE '%{adres}%')");
                counter++;
            }
            if (kodPocztowy != null)
            {
                filtr += (counter > 0 ? $" AND (KodPocztowy LIKE '%{kodPocztowy}%')" : $" WHERE (KodPocztowy LIKE '%{kodPocztowy}%')");
                counter++;
            }
            if (wojewodztwo != null)
            {
                filtr += (counter > 0 ? $" AND (Wojewodztwo LIKE '%{wojewodztwo}%')" : $" WHERE (Wojewodztwo LIKE '%{wojewodztwo}%')");
                counter++;
            }

            using (var connection = _context.CreateConnection())
            {
                var kody_pocztowe = connection.Query<KodyPocztoweDapper>(filtr);
                return kody_pocztowe.ToList();
            }
        }
    }
}
