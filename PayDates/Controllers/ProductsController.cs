using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PayDates.Interfaces;
using PayDates.Models;
using PayDates.Repositories;


namespace PayDates.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        IProductRepository repository;

        public ProductsController(IProductRepository repository)
        {
            this.repository = repository;
        }

        // GET: api/Products
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "ProductsValue1", "ProductsValue2" };
        }

        // GET: api/Products/5
        [HttpGet("{id}", Name = "GetProduct")]
        public string Get(int id)
        {
            return "ProductsValue = " + id;
        }

        // POST: api/Products
        [HttpPost]
        [ProducesResponseType(400)]
        public void Post()//Product product)//[FromBody] string value)
        {
            //var foo = product;
            var bar = "ff";
        }

        // PUT: api/Products/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
