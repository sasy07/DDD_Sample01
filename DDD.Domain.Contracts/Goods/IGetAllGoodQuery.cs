using DDD.Domain.Entities.Goods;

namespace DDD.Domain.Contracts.Goods;

public interface IGetAllGoodQuery
{
    List<Good> Execute();
}