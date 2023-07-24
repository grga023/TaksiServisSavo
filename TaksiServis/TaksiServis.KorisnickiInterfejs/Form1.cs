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
        }
    }
}