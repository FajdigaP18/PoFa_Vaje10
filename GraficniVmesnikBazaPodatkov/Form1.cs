using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;


namespace GraficniVmesnikBazaPodatkov
{
    public partial class Filmi : Form
    {
        private string povezava = @"Data Source=C:\Users\Polona\Desktop\Prak_mat\Prog\PoLo_Vaje10\filmi.sqlite";

        public Filmi()
        {
            InitializeComponent();
        }

        private void pokazi_Click(object sender, EventArgs e)
        {
            double ocenaFilma = double.Parse(ocena.Text);


            DataSet baza = new DataSet();
            SQLiteConnection povezavaBaza = new SQLiteConnection(povezava);

            SQLiteDataAdapter podatkiAdapter = new SQLiteDataAdapter($"SELECT id, naslov, reziser, leto, ocena FROM filmi WHERE ocena = {ocenaFilma}", povezavaBaza);
            podatkiAdapter.Fill(baza);
            DataTable tabela = baza.Tables[0];
            prikazFilmov.DataSource = tabela;

        }

        private void spremeni_Click(object sender, EventArgs e)
        {
            string id = idFilma.Text;
            string reziser = novReziser.Text;

            DataSet baza = new DataSet();
            SQLiteConnection povezavaBaza = new SQLiteConnection(povezava);

            SQLiteDataAdapter podatkiAdapter = new SQLiteDataAdapter("SELECT id, naslov, reziser, ocena FROM filmi WHERE id =" + id, povezavaBaza);
            podatkiAdapter.Fill(baza);
            //prilazFilmaReziser.DataSource = baza.Tables[0];

            SQLiteCommand comanda = new SQLiteCommand("UPDATE filmi SET reziser = " + reziser + " WHERE id = " + id, povezavaBaza);
            SQLiteCommandBuilder builder = new SQLiteCommandBuilder(podatkiAdapter);
            podatkiAdapter.UpdateCommand = builder.GetUpdateCommand(true);

            podatkiAdapter.UpdateCommand = comanda;
            podatkiAdapter.AcceptChangesDuringUpdate = true;
            podatkiAdapter.Update(baza);
            SQLiteDataAdapter novPodatki = new SQLiteDataAdapter("SELECT id, naslov, reziser, ocena FROM filmi WHERE id =" + id, povezavaBaza);
            novPodatki.Fill(baza);

            prilazFilmaReziser.DataSource = baza.Tables[0];
        }
    }
}
