using Microsoft.AspNetCore.Mvc;
using TechStoreMvc.Models;

namespace TechStoreMvc.Controllers 
{
    public class ProdutosController : Controller // o ";" significa herança
    // Herança = herdas as caracteristicas de um Controller. :)
    // Conceito de POO -> Programação Orientada a Objetos
    {
        // GET: ProdutosController

        // Passo 02 - Criar a ação
        // Uma view Depende de uma ação e vice-versa
        public ActionResult Index()
        {
            // Passo 05 - Objeto
            // Criar um objeto com vários produtos, por isso usamos um List
            List<Produto> produtos = new List<Produto>
            {
              new Produto(1, "Mouse Gamer", 129.9m, 10),  
              new Produto(2, "Teclado Mecânico", 249.9m, 5), 
              new Produto(1, "Monitor 24 polegadas", 899.90m, 8),  
              new Produto(1, "Headset Gamer", 179.9m, 15) 
            };
            return View(produtos);
        }

    }
}
