using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace ARACIM_KİRALA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\\HP\\.gradle\\arackirala.mdb");
        OleDbCommand komut = new OleDbCommand();

        private void verilerigörüntüle()
        {
            baglantı.Open();
            DataTable dataTable = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter("Select * from arackirala", baglantı);
            da.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglantı.Close();

        }
        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string sorgu = "Insert into arackirala (Marka,AracPlaka,AracRengi,KiraÜcreti,MüsteriAdi,MüsteriSoyadi,MüsteriTel,AlisTarihi,VerisTarihi)" + "values (@Marka,@AracPlaka,@AracRengi,@KiraÜcreti,@MüsteriAdi,@MüsteriSoyadi,@Müsteritel,@AlisTarihi,@VerisTarihi)";
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
            
            komut.Parameters.AddWithValue("@AracPlaka", txtplaka.Text);
            komut.Parameters.AddWithValue("@AracRengi", txtrenk.Text);
            komut.Parameters.AddWithValue("@KiraÜcreti", txtücret.Text);
            komut.Parameters.AddWithValue("@MüsteriAdi", txtadi.Text);
            komut.Parameters.AddWithValue("@MüsteriSoyadi", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@MüsteriTel", txttel.Text);
            komut.Parameters.AddWithValue("@AlisTarihi", txtalistarihi.Text);
            komut.Parameters.AddWithValue("@VerisTarihi", txtveristarihi.Text);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
        }

        private void btngöster_Click(object sender, EventArgs e)
        {
            verilerigörüntüle();
        }

        private void txtad_Click(object sender, EventArgs e)
        {

        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            string sorgu = "Update arackirala Set Marka=@Marka,AracPlaka=@AracPlaka,AracRengi=@AracRengi,KiraÜcreti=@KiraÜcreti,MüsteriAdi=@MüsteriAdi,MüsteriSoyadi=@MüsteriSoyadi," +
                "MüsteriTel=@MüsteriTel,AlisTarihi=@AlisTarihi,VerisTarihi=@VerisTarihi where Arac_id = @Arac_id";

            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);

            komut.Parameters.AddWithValue("@Marka", txtmarka.Text);
            komut.Parameters.AddWithValue("@AracPlaka", txtplaka.Text);
            komut.Parameters.AddWithValue("@AracRengi", txtrenk.Text);
            komut.Parameters.AddWithValue("@KiraÜcreti", txtücret.Text);
            komut.Parameters.AddWithValue("@MüsteriAdi", txtadi.Text);
            komut.Parameters.AddWithValue("@MüsteriSoyadi", txtsoyadi.Text);
            komut.Parameters.AddWithValue("@MüsteriTel", txttel.Text);
            komut.Parameters.AddWithValue("@AlisTarihi", txtalistarihi.Text);
            komut.Parameters.AddWithValue("@VerisTarihi", txtveristarihi.Text);          
            komut.Parameters.AddWithValue("@Arac_id", Convert.ToInt32(txtid.Text));      
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();







        }

        private void btnsil_Click(object sender, EventArgs e)
        {

            string sorgu = "Delete from arackirala Where Arac_id= @Arac_id";
            OleDbCommand komut = new OleDbCommand(sorgu, baglantı);
            komut.Parameters.AddWithValue("@Arac_id", dataGridView1.CurrentRow.Cells[0].Value);
            baglantı.Open();
            komut.ExecuteNonQuery();
            baglantı.Close();
            verilerigörüntüle();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtmarka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtplaka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtrenk.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtücret.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtadi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtsoyadi.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txttel.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txtalistarihi.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtveristarihi.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();




        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
