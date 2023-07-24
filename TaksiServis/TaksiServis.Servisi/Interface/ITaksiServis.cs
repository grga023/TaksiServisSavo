using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;

namespace TaksiServis.Servisi.Interface
{
    public interface ITaksiServis
    {
        Task<IEnumerable<Vozilo>> PrikazSvihVozilaAsync();
        Task<IEnumerable<Vozilo>> prikazSvihVozilaPoRegistraciji(object registracija);
        Task<IEnumerable<Vozilo>> prikazSvihVozilaPoModelu(object model);
        Task AzurirajVozilo(Vozilo obj, object ID);
        Task KreirajNovoVozilo(Vozilo voziloModel);
        void ObrisiVozilo(object ID);
    }
}
