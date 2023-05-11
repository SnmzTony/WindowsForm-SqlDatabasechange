using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString);

        public Form1()
        {
            InitializeComponent();
        }

        private void Select_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                // Sorgu yaz
                string query = "Select GIB_STATU from Dispatches Where EIRSALIYE_NUMARASI=@EIRSALIYE_NUMARASI";
                // Sorguyu SQL Server'a gönder
                SqlCommand command = new SqlCommand(query, connection);
                // Parametreleri ekle
                command.Parameters.AddWithValue("@EIRSALIYE_NUMARASI", txtEirsaliyeNumarasi.Text);
                // Sorguyu çalıştır ve sonuçları oku
                SqlDataReader reader = command.ExecuteReader();
                // Sonuçları txtResult TextBox'ına yaz
                if (reader.Read())
                {
                    txtResult.Text = reader["GIB_STATU"].ToString();
                }
                else
                {
                    txtResult.Text = "Kayıt bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection?.Close();
            }
        }

        private void Update_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                // Sorgu yaz
                string query = "Update Dispatches set GIB_STATU='1300' where EIRSALIYE_NUMARASI=@EIRSALIYE_NUMARASI";
                // Sorguyu SQL Server'a gönder
                SqlCommand command = new SqlCommand(query, connection);
                // Parametreleri ekle
                command.Parameters.AddWithValue("@EIRSALIYE_NUMARASI", txtEirsaliyeNumarasi.Text);
                // Sorguyu çalıştır ve etkilenen kayıt sayısını döndür
                int rowsAffected = command.ExecuteNonQuery();
                // Sonuçları txtResult TextBox'ına yaz
                if (rowsAffected > 0)
                {
                    txtResult.Text = "Kayıt başarıyla güncellendi.";
                }
                else
                {
                    txtResult.Text = "Kayıt bulunamadı.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
            }
            finally
            {
                // Bağlantıyı kapat
                connection?.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
            