using DDD.Domain.Contracts.Goods;
using DDD.Domain.Entities.Goods;

namespace DDD.Domain.ApplicationServices.Goods.Query;

public class GetAllGoodQuery:IGetAllGoodQuery
{
    private readonly IGoodRepository _goodRepository;

    public List<Good> Execute()
        => _goodRepository.Goods();
}