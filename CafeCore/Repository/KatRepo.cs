using CafeCore.Model;
using CafeCore.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CafeCore.Repository
{
    public class KatRepo : RepositoryBase<Kat, int>
    {
        public bool IsKatAdInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.Ad.ToLower() == text.ToLower());
        }
        public bool IsKatKoduInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.Kodu.ToLower() == text.ToLower());
        }
        public bool IsKatSiraNoInDatabase(string text)
        {
            return Table.Where(x => x.IsDeleted == false).Any(x => x.SiraNo.ToString() == text);
        }
        public IQueryable<Kat> GetWithMasa()
        {
            return Table.Include(x => x.Masalar).Where(x => x.Masalar.Count > 0 && x.IsDeleted == false).OrderBy(x => x.SiraNo);
        }

    }
}
