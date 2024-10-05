using Microsoft.AspNetCore.Mvc;
using p1.Models;
using p1.Data;

[ApiController]
[Route("api/[controller]")]
public class FinancialController : ControllerBase
{
    private readonly FinancialService _financialService;

    public FinancialController(FinancialService financialService)
    {
        _financialService = financialService;
    }

    // Rota GET para consultar o saldo
    [HttpGet("balance")]
    public IActionResult GetBalance()
    {
        var balance = _financialService.GetBalance();
        return Ok(new { Balance = balance });
    }

    // Rota POST para adicionar uma nova transação
    [HttpPost("transaction")]
    public IActionResult AddTransaction(Transaction transaction)
    {
        _financialService.AddTransaction(transaction);
        return CreatedAtAction(nameof(GetBalance), new { id = transaction.Id }, transaction);
    }
}