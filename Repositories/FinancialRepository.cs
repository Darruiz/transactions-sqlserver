using p1.Models;
using p1.Data;

public class FinancialRepository
{
    private readonly ApplicationDbContext _context;

    public FinancialRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public List<Transaction> GetTransactions()
    {
        return _context.Transactions.ToList();
    }
}