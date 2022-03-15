using CafeCore.Model;
using CafeCore.Repository.Abstract;
using System;
using System.Linq;
using System.Windows.Forms;

namespace CafeCore.Repository
{
    public class SiparisRepo : RepositoryBase<Siparis, int>
    {
        public decimal AraToplam (int masaId) 
        {
            return Table.Where(x => x.MasaId == masaId && x.IsDeleted == false).Sum(x => x.AraToplam);
        }

        public Siparis GetSepetUrun(int urunId, int masaId)
        {
            return Table.FirstOrDefault(x => x.Urun.Id == urunId && x.MasaId == masaId && x.IsDeleted == false);
        }
        public object GetDay()
        {
            return Table.Select(x => new
            {
                x.CreatedDate,
                x.Urun.Ad,
                x.Adet,
                x.Urun.Fiyat,
                x.AraToplam,
                x.IsDeleted
            }).Where(x => (x.CreatedDate.Date.Day > DateTime.Today.AddDays(-1).Day && x.CreatedDate > DateTime.Now.AddDays(-1)) && x.IsDeleted == true).OrderBy(x => x.CreatedDate).ToList();
        }

        public object GetMonth()
        {
            return Table.Select(x => new
            {
                x.CreatedDate,
                x.Urun.Ad,
                x.Adet,
                x.Urun.Fiyat,
                x.AraToplam,
                x.IsDeleted
            }).Where(x => (x.CreatedDate.Date.Year == DateTime.Today.Year && x.CreatedDate.Date.Month > DateTime.Now.AddMonths(-1).Month) && x.IsDeleted == true).OrderBy(x => x.CreatedDate).ToList();
        }

        public object GetByDtp(DateTimePicker dtpBitis, DateTimePicker dtpBaslangic)
        {
            return Table.Select(x => new
            {
                x.CreatedDate,
                x.Urun.Ad,
                x.Adet,
                x.Urun.Fiyat,
                x.AraToplam,
                x.IsDeleted
            }).Where(x => (x.CreatedDate >= dtpBaslangic.Value && x.CreatedDate <= dtpBitis.Value) && x.IsDeleted == true).OrderBy(x => x.CreatedDate).ToList();
        }

    }
}
