using DDD.Domain.Entities.Goods;

namespace DDD.Domain.Contracts.Goods;

public interface IGoodRepository
{
    List<Good> Goods();
}