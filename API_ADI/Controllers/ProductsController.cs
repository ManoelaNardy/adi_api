using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_ADI.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_ADI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        List<Produto> produtos = new List<Produto>
        {
            new Produto { Id = 1, Nome = "Caixa" },
            new Produto { Id = 2, Nome = "Cadeira" },
            new Produto { Id = 3, Nome = "Mesa"}
        };

        // GET: api/<ProductsController>
        [HttpGet]
        public List<Produto> GetAll()
        {
            return produtos;
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Produto GetProduto(int id)
        {
            return produtos.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<ProductsController>
        [HttpPost]
        public string Post([FromBody] string nome)
        {
            var produto = new Produto
            {
                Id = produtos.Count-1,
                Nome = nome
            };
            produtos.Add(produto);
            return "Adicionado";
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody] string nome)
        {
            var prod = produtos.Where(x => x.Id == id).FirstOrDefault();
            prod.Nome = nome;
            return "Alterado";
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            var prod = produtos.Where(x => x.Id == id).FirstOrDefault();
            produtos.Remove(prod);
            return "Removido";
        }
    }
}
