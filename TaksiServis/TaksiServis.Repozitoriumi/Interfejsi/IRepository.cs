using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaksiServis.Repozitoriumi.Interfejsi
{
    public interface IRepository <T> where T : class
    {
        void Obrisi(object PK);
        Task<IEnumerable<T>> prikazSvihVozila();
        Task<IEnumerable<T>> prikazVozilaPoModelu(object model);
        Task<IEnumerable<T>> prikazVozilaPoRegistraciji(object registracija);
        T PrikaziPoIDAsync(object ID);
        T Dodaj(T obj);
        T Azuriraj(T obj);
        void Sacuvaj();
    }
}
