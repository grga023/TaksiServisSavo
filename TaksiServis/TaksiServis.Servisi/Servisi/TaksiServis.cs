using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;
using TaksiServis.Repozitoriumi.Interfejsi;
using TaksiServis.Servisi.Interface;

namespace TaksiServis.Servisi.Servisi
{
    public class TaksiServis : ITaksiServis
    {
        private readonly ITaksiRepozitory _taksiRepozitory;

        public TaksiServis(ITaksiRepozitory taksiRepozitory)
        {
            _taksiRepozitory = taksiRepozitory;
        }

        public Task AzurirajFilm(Vozilo obj, object ID)
        {
            throw new NotImplementedException();
        }

        public Task KreirajNovFilm(Vozilo KartaModel)
        {
            throw new NotImplementedException();
        }

        public void ObrisiFilm(object ID)
        {
            throw new NotImplementedException();
        }

        public bool PostojiFilmUBaziPodataka()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> PrikazSvihVozilaAsync()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> prikazSvihVozilaPoModelu(object model)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Vozilo>> prikazSvihVozilaPoRegistraciji(object registracija)
        {
            throw new NotImplementedException();
        }
    }
}
