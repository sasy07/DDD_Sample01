namespace DDD.Data.EF.Common;

public class BaseEfRepository
{
    protected DataContext _context;

    public BaseEfRepository(DataContext context)
    {
        _context = context;
    }
}