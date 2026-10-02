using Ecommerce.Produtos.Application.Categorias_DTOs.Create;
using Ecommerce.Produtos.Application.Categorias_DTOs.Update;
using Ecommerce.Produtos.Application.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Produtos.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriaController : ControllerBase
{
    private readonly ICategoriaService _categoriaService;

    public CategoriaController(ICategoriaService categoriaService)
    {
        _categoriaService = categoriaService;
    }

    [HttpPost("create")]
    public async Task<IActionResult> CreateCategoriaAsync([FromBody] CreateCategoriaRequest request)
    {
        var categoria = await _categoriaService.CreateCategoriaAsync(request);
        return Ok(categoria);
    }

    [HttpGet("read-all")]
    public async Task<IActionResult> ReadAllCategoriasAsync()
    {
        var categorias = await _categoriaService.ReadAllCategoriasAsync();
        return Ok(categorias);
    }

    [HttpDelete("delete/{categoriaId}")]
    public async Task<IActionResult> DeleteCategoriaAsync(int categoriaId)
    {
        var deleted = await _categoriaService.DeleteCategoriaAsync(categoriaId);
        if (!deleted)
        {
            return NotFound();
        }
        return Ok();
    }

    [HttpGet("read/{categoriaId}")]
    public async Task<IActionResult> ReadCategoriaAsync(int categoriaId)
    {
        var categoria = await _categoriaService.ReadCategoriaIdAsync(categoriaId);
        if (categoria == null)
        {
            return NotFound();
        }
        return Ok(categoria);
    }

    [HttpPut("update/{categoriaId}")]
    public async Task<IActionResult> UpdateCategoriaAsync(int categoriaId, [FromBody] UpdateCategoriaRequest request)
    {
        var categoria = await _categoriaService.UpdateCategoriaAsync(categoriaId, request);
        if (categoria == null)
        {
            return NotFound();
        }
        return Ok(categoria);
    }
}
