using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaksiServis.Modeli;
using TaksiServis.Repozitoriumi.Context;
using TaksiServis.Repozitoriumi.Interfejsi;

namespace TaksiServis.Repozitoriumi.Repozitorijumi
{
    public class TaksiRepozitorijum : ITaksiRepozitory
    {
        private readonly TaksiDBCotext _ctx;

        public TaksiRepozitorijum(TaksiDBCotext ctx)
        {
            _ctx = ctx;
        }

        public Vozilo Azuriraj(Vozilo obj)
        {
            try
            {
                _ctx.Entry(obj).State = EntityState.Modified;

                return obj;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Vozilo Dodaj(Vozilo obj)
        {
            return _ctx.Vozilo.Add(obj).Entity;
        }

        public void Obrisi(object PK)
        {
            var postoji = _ctx.Vozilo.Find(PK);
            if (postoji is null)
                throw new ArgumentNullException();

            _ctx.Vozilo.Remove(postoji);
        }

        public Vozilo PrikaziPoIDAsync(object ID)
        {
            var postoji = _ctx.Vozilo.Find(ID);
            if (postoji is not null)
            {
                _ctx.Entry(postoji).State = EntityState.Detached;
                return postoji;
            }
            else throw new ArgumentNullException();
        }

        public async Task<IEnumerable<Vozilo>> prikazSvihVozila()
        {
            var data = await _ctx.Vozilo     
                            .ToListAsync();

            return data;
        }

        public async Task<IEnumerable<Vozilo>> prikazVozilaPoModelu(object model)
        {
            var data = await _ctx.Vozilo
                    .Where(x => x.Model== model).ToListAsync();

            return data;
        }

        public async Task<IEnumerable<Vozilo>> prikazVozilaPoRegistraciji(object registracija)
        {
            var data = await _ctx.Vozilo
                    .Where(x => x.Registracija == registracija).ToListAsync();

            return data;
        }

        public void Sacuvaj()
        {
            _ctx.SaveChanges();
        }
    }
}
