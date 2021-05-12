using Domain.Interfaces.Services.Product;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Net;
using System.Threading.Tasks;

namespace Application.Controllers
{
    [Route("api/[controller]")] // identifica api/products
    [ApiController]
    public class ProductsController : ControllerBase
    {
        //private IProductService _service;
        //public ProductsController(IProductService service)
        //{
        //    _service = service;
        //}

        [HttpGet]
        // public async Task<ActionResult> GetAll() { }
        public async Task<ActionResult> GetAll([FromServices] IProductService service)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // return Ok(await service.GetAll());
                return Ok(await service.GetAll());
            }
            catch (ArgumentException e) // Tratar erros de controllers
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }
    }
}
