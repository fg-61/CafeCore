using CafeCore.Model;
using CafeCore.Repository.Abstract;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace CafeCore.Repository
{
    public class MasaRepo : RepositoryBase<Masa, int>
    {
        public IQueryable<Masa> GetWithKatId(int seciliKatId)
        {
            return Table.Where(x => x.KatId == seciliKatId).Include(x => x.Siparisler).ThenInclude(x => x.Urun).OrderBy(x => x.No);
        }
    }
}
