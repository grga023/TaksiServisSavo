using System.Windows.Forms;
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
            Prikaz();
        }

        private void TableView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }
}