using p1.Models;
using p1.Data;

public class FinancialService
{
    private readonly ApplicationDbContext _context;

    public FinancialService(ApplicationDbContext context)
    {
        _context = context;
    }

    // Retorna o saldo total com base nas transações
    public decimal GetBalance()
    {
        return _context.Transactions.Sum(t => t.Amount);
    }

    // Adiciona uma nova transação
    public void AddTransaction(Transaction transaction)
    {
        _context.Transactions.Add(transaction);
        _context.SaveChanges();
    }
}