using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[Controller]")]
[Authorize]
public class TransactionController : ControllerBase
{
    private readonly ITransactionService _transactionService;
    public TransactionController(ITransactionService transactionService)
    {
        _transactionService = transactionService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
        var transactions = _transactionService.GetAll();
        return StatusCode(200, transactions);
    }

    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var transaction = _transactionService.GetById(id);
        if (transaction == null)
        {
            return NotFound();
        }

        return StatusCode(200, transaction);
    }

    [HttpPost]
    public IActionResult Create(TransactionCreateDto dto)
    {
        var transaction = _transactionService.Create(dto);

        if (transaction == null)
        {
            return NotFound();
        }

        return StatusCode(201, transaction);
    }

    [HttpPut("{id}")]
    public IActionResult Update(int id, TransactionCreateDto dto)
    {
        var transaction = _transactionService.Update(id, dto);

        if (transaction == null)
        {
            return NotFound();
        }

        return StatusCode(200, transaction);
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        bool result = _transactionService.Delete(id);
        if (!result)
        {
            return NotFound();
        }
        return Ok();
    }
}