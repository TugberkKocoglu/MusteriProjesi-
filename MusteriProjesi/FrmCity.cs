using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusteriProjesi
{
    public partial class FrmCity : Form
    {
        public FrmCity()
        {
            InitializeComponent();
        }

        SqlConnection sqlConnection = new SqlConnection("Server=DESKTOP-TCALSD6;initial catalog=DbCustomer;integrated security=true;");
        private void btnListele_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity",sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sqlConnection.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("insert into TblCity (CityName,CityCountry) values (@cityName,@cityCountry)", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtSehirAdi.Text);
            command.Parameters.AddWithValue("@cityCountry", txtUlke.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir Başarıyla Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("delete from TblCity where CityId=@cityId", sqlConnection);
            command.Parameters.AddWithValue("@cityId", txtSehirId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarılı bir şekilde silindi.","Uyarı",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("update TblCity set CityName=@cityName,CityCountry=@cityCountry where CityId=@cityId",sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtSehirAdi.Text);
            command.Parameters.AddWithValue("@cityCountry", txtUlke.Text);
            command.Parameters.AddWithValue("@cityId", txtSehirId.Text);
            command.ExecuteNonQuery();
            sqlConnection.Close();
            MessageBox.Show("Şehir başarıyla güncellendi", "Uyarı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCity where CityName=@cityName", sqlConnection);
            command.Parameters.AddWithValue("@cityName", txtSehirAdi.Text);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource=dataTable;
            sqlConnection.Close();
        }
    }
}
