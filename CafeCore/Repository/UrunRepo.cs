using CafeCore.Model;
using CafeCore.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CafeCore.Repository
{
    public class UrunRepo : RepositoryBase<Urun, int>
    {
        public IQueryable<Urun> GetUrunWithKategori()
        {
            return Table.Where(x => x.IsDeleted == false)
                .Include(x => x.Kategori)
                .Where(x => x.Kategori.IsDeleted == false)
                .OrderBy(x => x.Kategori.Ad);
        }

        // girilen ürün adı kayıtlı mı
        public bool IsUrunAdInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.Ad.ToLower() == text.ToLower());
        }

        public IQueryable<Urun> GetUrunWithKategoriId(int _kategoriId)
        {
            return Table.Where(x => x.KategoriId == _kategoriId && x.IsDeleted == false);
        }

    }
}
