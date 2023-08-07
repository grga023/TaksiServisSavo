using System.Windows.Forms;
using TaksiServis.Modeli;
using TaksiServis.Servisi.Interface;

namespace TaksiServis.KorisnickiInterfejs
{
    public partial class Form1 : Form
    {
        private readonly ITaksiServis _taksiServis;
        public Form1(ITaksiServis taksiServis)
        {
            InitializeComponent();
            _taksiServis = taksiServis;
            _ = Prikaz();
            fillCbx();
        }

        private void fillCbx()
        {
            cbxFilter.Items.Clear();

            cbxFilter.Items.Add("Po Registraciji");
            cbxFilter.Items.Add("Po Modelu");
        }

        private void TableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                DataGridViewRow selektovaniRed = TableView.Rows[e.RowIndex];

                txtID.Text = selektovaniRed.Cells["ID"].Value.ToString();
                txtMarka.Text = selektovaniRed.Cells["Marka"].Value.ToString();
                txtModel.Text = selektovaniRed.Cells["Model"].Value.ToString();
                txtGodiste.Text = selektovaniRed.Cells["Godiste"].Value.ToString();
                txtRegistracija.Text = selektovaniRed.Cells["Registracija"].Value.ToString();

            }
            catch (Exception ex) { }
        }

        private async Task Prikaz()
        {
            try
            {
                var vozilo = await _taksiServis.PrikazSvihVozilaAsync();

                TableView.DataSource = vozilo;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private async void btnDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                Vozilo VoziloZaDodat = new()
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    Gdiste = DateTime.Parse(txtGodiste.Text),
                    Registracija = txtRegistracija.Text,
                };


                await _taksiServis.KreirajNovoVozilo(VoziloZaDodat);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _ = Prikaz();
        }

        private async void btnIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);

                Vozilo VoziloZaIzmeniti = new()
                {
                    Marka = txtMarka.Text,
                    Model = txtModel.Text,
                    Gdiste = DateTime.Parse(txtGodiste.Text),
                    Registracija = txtRegistracija.Text,
                };


                await _taksiServis.AzurirajVozilo(VoziloZaIzmeniti, id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            _ = Prikaz();
        }

        private void btnObrisi_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                _taksiServis.ObrisiVozilo(id);
            }
            catch (Exception ex) { }
            _ = Prikaz();
        }

        private async void btnFiltriraj_ClickAsync(object sender, EventArgs e)
        {
            var selected = cbxFilter.SelectedItem;
            var value = txtFilterBox.Text;
            var vozilo = await _taksiServis.PrikazSvihVozilaAsync();
            try
            {
                switch (selected)
                {
                    case "Po Registraciji":
                        vozilo = await _taksiServis.prikazSvihVozilaPoRegistraciji(value);
                        break;
                    case "Po Modelu":
                        vozilo = await _taksiServis.prikazSvihVozilaPoModelu(value);
                        break;
                    default:
                        break;
                }
                TableView.DataSource = vozilo;
            }
            catch (Exception ex) { }
        }
    }
}