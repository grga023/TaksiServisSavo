using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;
using TaksiServis.Repozitoriumi.Interfejsi;
using TaksiServis.Repozitoriumi.Migrations;
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

        public Task AzurirajVozilo(Vozilo obj, object ID)
        {
            var data = _taksiRepozitory.PrikaziPoIDAsync(ID);
            if (data == null) throw new ArgumentNullException();

            Vozilo volziloZaIzmenu = new()
            {
                Id = data.Id,
                Model = obj.Model,
                Marka = obj.Marka,
                Registracija = obj.Registracija,

            };

            _taksiRepozitory.Azuriraj(volziloZaIzmenu);
            _taksiRepozitory.Sacuvaj();
            return Task.CompletedTask;

        }

        public Task KreirajNovoVozilo(Vozilo voziloModel)
        {
            Vozilo voziloZaDodati = new()
            {
                Id = voziloModel.Id,
                Model = voziloModel.Model,
                Marka = voziloModel.Marka,
                Registracija = voziloModel.Registracija,

            };

            _taksiRepozitory.Dodaj(voziloZaDodati);
            _taksiRepozitory.Sacuvaj();
            return Task.CompletedTask;
        }

        public void ObrisiVozilo(object ID)
        {
            _taksiRepozitory.Obrisi(ID);
            _taksiRepozitory.Sacuvaj();
        }

        public async Task<IEnumerable<Vozilo>> PrikazSvihVozilaAsync()
        {
            var data = await _taksiRepozitory.prikazSvihVozila();
            if (data is null) throw new ArgumentNullException();

            List<Vozilo> vozila = new();
            Vozilo vozilo;

            foreach (var item in data)
            {
                vozilo = new Vozilo
                {
                    Id = item.Id,
                    Model = item.Model,
                    Marka = item.Marka,
                    Registracija = item.Registracija,
                };
                vozila.Add(vozilo);
            }
            return vozila.ToList();
        }

        public async Task<IEnumerable<Vozilo>> prikazSvihVozilaPoModelu(object model)
        {
            var data = await _taksiRepozitory.prikazVozilaPoModelu(model);
            if (data is null) throw new ArgumentNullException();

            List<Vozilo> vozila = new();
            Vozilo vozilo;

            foreach (var item in data)
            {
                vozilo = new Vozilo
                {
                    Id = item.Id,
                    Model = item.Model,
                    Marka = item.Marka,
                    Registracija = item.Registracija,
                };
                vozila.Add(vozilo);
            }
            return vozila.ToList();
        }

        public async Task<IEnumerable<Vozilo>> prikazSvihVozilaPoRegistraciji(object registracija)
        {
            var data = await _taksiRepozitory.prikazVozilaPoRegistraciji(registracija);
            if (data is null) throw new ArgumentNullException();

            List<Vozilo> vozila = new();
            Vozilo vozilo;

            foreach (var item in data)
            {
                vozilo = new Vozilo
                {
                    Id = item.Id,
                    Model = item.Model,
                    Marka = item.Marka,
                    Registracija = item.Registracija,
                };
                vozila.Add(vozilo);
            }
            return vozila.ToList();
        }
    }
}
