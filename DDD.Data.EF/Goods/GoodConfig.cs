using DDD.Domain.Entities.Goods;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DDD.Data.EF.Goods;

public class GoodConfig : IEntityTypeConfiguration<Good>
{
    public void Configure(EntityTypeBuilder<Good> builder)
    {
        
    }
}