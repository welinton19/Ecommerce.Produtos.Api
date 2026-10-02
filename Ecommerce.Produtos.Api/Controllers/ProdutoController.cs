using Ecommerce.Produtos.Application.DTOs.Create;
using Ecommerce.Produtos.Application.DTOs.Update;
using Ecommerce.Produtos.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produtos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoService _produtoService;

    public ProdutoController(IProdutoService produtoService)
    {
        _produtoService = produtoService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateProduto([FromBody] CreateProdutoRequest request)
    {
        var response = await _produtoService.CreateProdutoAsync(request);
        return Ok(response);
    }

    [HttpGet("read/{produtoId}")]
    public async Task<IActionResult> ReadProduto([FromRoute] int produtoId)
    {
        var response = await _produtoService.ReadProdutoAsync(produtoId);
        return Ok(response);
    }

    [HttpGet("read-all")]
    public async Task<IActionResult> ReadAllProdutos()
    {
        var response = await _produtoService.ReadAllProdutosAsync();
        return Ok(response);
    }

    [HttpDelete("delete/{produtoId}")]
    public async Task<IActionResult> DeleteProduto([FromRoute] int produtoId)
    {
        var response = await _produtoService.DeleteProdutoAsync(produtoId);
        return Ok(response);
    }

    [HttpPut("update/{produtoId}")]
    public async Task<IActionResult> UpdateProduto([FromRoute] int produtoId, [FromBody] UpdateProdutoRequest request)
    {
        var response = await _produtoService.UpdateProdutoAsync(produtoId, request);
        return Ok(response);
    }
}
