using DDD.Data.EF.Common;
using DDD.Domain.Contracts.Goods;
using DDD.Domain.Entities.Goods;

namespace DDD.Data.EF.Goods;

public class GoodRepository:BaseEfRepository,IGoodRepository
{
    public GoodRepository(DataContext context) : base(context)
    {
    }

    public List<Good> Goods()
        => _context.Goods.ToList();
}