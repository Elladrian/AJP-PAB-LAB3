using WinFormsApp1.Models;
using WinFormsApp1.Shared;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddCSVDataToDatabase();
        }

        private void AddCSVDataToDatabase()
        {
            try
            {
                using (CSVContext csvContext = new())
                {
                    using (Ajppablab3Context db = new())
                    {
                        foreach(var kod in csvContext.ImportedKody)
                        {
                            KodyPocztowe record = new()
                            {
                                KodPocztowy = kod.kod_pocztowy,
                                Adres = kod.adres,
                                Miejscowosc = kod.miejscowosc,
                                Powiat = kod.miejscowosc,
                                Wojewodztwo = kod.wojewodztwo,
                            };
                            db.KodyPocztowes.Add(record);
                        }
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error: {ex}");
            }
        }
    }
}