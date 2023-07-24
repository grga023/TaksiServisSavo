using TaksiServis.Servisi.Interface;

namespace TaksiServis.KorisnickiInterfejs
{
    public partial class Form1 : Form
    {
        private readonly ITaksiServis taksiServis;
        public Form1()
        {
            InitializeComponent();
        }
    }
}