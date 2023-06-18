using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using WinFormsApp1.Models;
using WinFormsApp1.ModelsDapper;
using WinFormsApp1.Shared;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static string connectionString = @"Server=LOCALHOST\LOCALDATABASE;Database=AJPPABLAB3;User ID=Administrator;Password=cisco123!L;Encrypt=False;TrustServerCertificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //AddCSVDataToDatabase();
            fillKodyDataGridView();
        }

        private void fillKodyDataGridView()
        {
            try
            {
                using (Ajppablab3Context db = new())
                {
                    db.KodyPocztowes.Load();
                    this.kodyDataGridView.DataSource = db.KodyPocztowes.Local.ToBindingList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void AddCSVDataToDatabase()
        {
            try
            {
                using (CSVService csvContext = new())
                {
                    using (Ajppablab3Context db = new())
                    {
                        foreach (var kod in csvContext.ImportedKody)
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

        private void efSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? id = idTextBox.Text.Length > 0 ? idTextBox.Text : null;
                string? miejscowosc = miejscowoscTextBox.Text.Length > 0 ? miejscowoscTextBox.Text : null;
                string? powiat = powiatTextBox.Text.Length > 0 ? powiatTextBox.Text : null;
                string? adres = adresTextBox.Text.Length > 0 ? adresTextBox.Text : null;
                string? kodPocztowy = kodPocztowyTextBox.Text.Length > 0 ? kodPocztowyTextBox.Text : null;
                string? wojewodztwo = wojewodztwoTextBox.Text.Length > 0 ? wojewodztwoTextBox.Text : null;

                List<KodyPocztowe> result = new();
                Stopwatch stopwatch = new();
                stopwatch.Start();
                using (Ajppablab3Context db = new())
                {
                    result = db.KodyPocztowes.ToList();
                    if (id != null)
                    {
                        result = result.Where(kod => kod.Id.ToString().ToLower().Contains(id.ToLower())).ToList();
                    }
                    if(miejscowosc != null)
                    {
                        result = result.Where(kod => kod.Miejscowosc.ToLower().Contains(miejscowosc.ToLower())).ToList();
                    }
                    if(powiat != null)
                    {
                        result = result.Where(kod => kod.Powiat.ToLower().Contains(powiat.ToLower())).ToList();
                    }
                    if(adres != null)
                    {
                        result = result.Where(kod => kod.Adres.ToLower().Contains(adres.ToLower())).ToList();
                    }
                    if(kodPocztowy != null)
                    {
                        result = result.Where(kod => kod.KodPocztowy.ToLower().Contains(kodPocztowy.ToLower())).ToList();
                    }
                    if(wojewodztwo != null)
                    {
                        result = result.Where(kod => kod.Wojewodztwo.ToLower().Contains(wojewodztwo.ToLower())).ToList();
                    }
                    if(result.Count < 0)
                    {
                        throw new Exception("Nothing Found");
                    }
                }
                stopwatch.Stop();

                resultDataGridView.DataSource = result;
                MessageBox.Show($"Search Result: {result.Count} items \nIn time: {stopwatch.Elapsed}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void adonetSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = null;
                if (Int32.TryParse(idTextBox.Text, out _)) id = Int32.Parse(idTextBox.Text);

                string? miejscowosc = miejscowoscTextBox.Text.Length > 0 ? miejscowoscTextBox.Text : null;
                string? powiat = powiatTextBox.Text.Length > 0 ? powiatTextBox.Text : null;
                string? adres = adresTextBox.Text.Length > 0 ? adresTextBox.Text : null;
                string? kodPocztowy = kodPocztowyTextBox.Text.Length > 0 ? kodPocztowyTextBox.Text : null;
                string? wojewodztwo = wojewodztwoTextBox.Text.Length > 0 ? wojewodztwoTextBox.Text : null;

                DataView dataView = new();
                Stopwatch stopwatch = new();
                stopwatch.Start();
                using (SqlConnection connection = new(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new();
                    command.Connection = connection;
                    command.CommandText = "SELECT Id, Kod_pocztowy AS KodPocztowy, Adres, Miejscowosc, Wojewodztwo, Powiat FROM Kody_Pocztowe";

                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dataTable = new DataTable();
                    dataTable.Load(reader);
                    dataTable.CaseSensitive = false;
                    dataView = dataTable.DefaultView;
                    string filtr = "";

                    if (id != null)
                    {
                         filtr += $"(CONVERT(Id, System.String) LIKE '%{id}%')";
                    }
                    if (miejscowosc != null)
                    {
                         filtr += (filtr.Length > 0 ? $" AND (Miejscowosc LIKE '%{miejscowosc}%')" : $"(Miejscowosc LIKE '%{miejscowosc}%')");
                    }
                    if (powiat != null)
                    {
                        filtr += (filtr.Length > 0 ? $" AND (Powiat LIKE '%{powiat}%')" : $"(Powiat LIKE '%{powiat}%')");
                    }
                    if (adres != null)
                    {
                        filtr += (filtr.Length > 0 ? $" AND (Adres LIKE '%{adres}%')" : $"(Adres LIKE '%{adres}%')");
                    }
                    if (kodPocztowy != null)
                    {
                        filtr += (filtr.Length > 0 ? $" AND (KodPocztowy LIKE '%{kodPocztowy}%')" : $"(KodPocztowy LIKE '%{kodPocztowy}%')");
                    }
                    if (wojewodztwo != null)
                    {
                        filtr += (filtr.Length > 0 ? $" AND (Wojewodztwo LIKE '%{wojewodztwo}%')" : $"(Wojewodztwo LIKE '%{wojewodztwo}%')");
                    }

                    dataView.RowFilter = filtr;

                    if (dataView.Count < 0)
                    {
                        throw new Exception("Nothing Found");
                    }
                }
                stopwatch.Stop();

                resultDataGridView.DataSource = dataView;
                MessageBox.Show($"Search Result: {dataView.Count} items \nIn time: {stopwatch.Elapsed}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Occured error {ex.Message}");
            }
        }

        private void dapperSearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                int? id = null;
                if (Int32.TryParse(idTextBox.Text, out _)) id = Int32.Parse(idTextBox.Text);

                string? miejscowosc = miejscowoscTextBox.Text.Length > 0 ? miejscowoscTextBox.Text : null;
                string? powiat = powiatTextBox.Text.Length > 0 ? powiatTextBox.Text : null;
                string? adres = adresTextBox.Text.Length > 0 ? adresTextBox.Text : null;
                string? kodPocztowy = kodPocztowyTextBox.Text.Length > 0 ? kodPocztowyTextBox.Text : null;
                string? wojewodztwo = wojewodztwoTextBox.Text.Length > 0 ? wojewodztwoTextBox.Text : null;

                Stopwatch stopwatch = new();
                var result = new List<KodyPocztoweDapper>();
                stopwatch.Start();
                using (DapperContext dapperContext = new(connectionString))
                {
                    KodyPocztoweDapperRepository kodyPocztoweDapperRepository = new(dapperContext);
                    result = kodyPocztoweDapperRepository.GetKodyPocztowe(id, kodPocztowy, adres, miejscowosc, wojewodztwo, powiat);
                }
                stopwatch.Stop();

                resultDataGridView.DataSource = result;
                MessageBox.Show($"Search Result: {result.Count()} items \nIn time: {stopwatch.Elapsed}");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Occured error: {ex.Message}");
            }
        }

        #region unused
        private void label2_Click(object sender, EventArgs e)
        {

        }


        #endregion
    }
}