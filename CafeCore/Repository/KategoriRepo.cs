using CafeCore.Model;
using CafeCore.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CafeCore.Repository
{
    public class KategoriRepo : RepositoryBase<Kategori, int>
    {
        public IQueryable<Kategori> GetWithUrun()
        {
            return Table.Include(x => x.Urunler)
                .Where(x => x.Urunler.Count > 0 && x.IsDeleted == false)
                .OrderBy(x => x.SiraNo);
        }
        public IQueryable<Kategori> GetNotDeleted()
        {
            return Table.Where(x => x.IsDeleted == false)
                    .OrderBy(x => x.SiraNo);
        }
        // girilen kategoriad kayıtlı mı
        public bool IsKategoryAdInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.Ad.ToLower() == text.ToLower());
        }
        // girilen kategori sıra no kayıtlı mı
        public bool IsSıraNoInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.SiraNo.ToString() == text);
        }


    }



}
