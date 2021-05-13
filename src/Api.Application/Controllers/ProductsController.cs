using Domain.Entities;
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
        private IProductService _service;
        public ProductsController(IProductService service)
        {
            _service = service;
        }

        // public async Task<ActionResult> GetAll() { }
        // public async Task<ActionResult> GetAll([FromServices] IProductService service)

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.GetAll());
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpGet]
        [Route("{id}", Name = "GetById")]
        public async Task<ActionResult> Get(Guid id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                return Ok(await _service.Get(id));
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] ProductEntity product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var result = await _service.Post(product);

                if (result != null)
                {
                    return Created(new Uri(Url.Link("GetById", new { id = result.Id })), result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (ArgumentException e)
            {
                return StatusCode((int)HttpStatusCode.InternalServerError, e.Message);
            }

        }
    }
}
