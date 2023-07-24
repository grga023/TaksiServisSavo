using TaksiServis.Servisi.Interface;

namespace TaksiServis.UI
{
    public partial class Form1 : Form
    {
        private readonly ITaksiServis _taksiServis;
        public Form1(ITaksiServis taksiServis)
        {
            _taksiServis = taksiServis;
            InitializeComponent();
        }
    }
}