using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiServis.Modeli
{
    public class Vozilo
    {
        public int Id { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime Gdiste { get; set; }
        public string Registracija { get; set; }
    }
}
