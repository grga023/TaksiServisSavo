using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;
using TaksiServis.Repozitoriumi.Interfejsi;

namespace TaksiServis.Repozitoriumi.Repozitorijumi
{
    public class TaksiRepozitorijum : ITaksiRepozitory
    {
        public Vozilo Azuriraj(Vozilo obj)
        {
            throw new NotImplementedException();
        }

        public Vozilo Dodaj(Vozilo obj)
        {
            throw new NotImplementedException();
        }

        public void Obrisi(object PK)
        {
            throw new NotImplementedException();
        }

        public Vozilo PrikaziPoIDAsync(object ID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> prikazSvihVozila()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> prikazVozilaPoModelu(object model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> prikazVozilaPoRegistraciji(object registracija)
        {
            throw new NotImplementedException();
        }

        public void Sacuvaj()
        {
            throw new NotImplementedException();
        }
    }
}
