using Microsoft.AspNetCore.Mvc;
using TechStoreMvc.Models;

namespace TechStoreMvc.Controllers 
{
    public class CategoriaController : Controller
    {
        public ActionResult Index()
        {
            List<Categoria> categorias = new List<Categoria>
            {
                new Categoria(1, "Computador e componentes", "Periféricos", true),
                new Categoria(2, "Mouse, teclado e acessórios", "Periféricos", true),
                new Categoria(3, "Fones, caixas e microfones", "Periféricos", true),
                new Categoria(4, "Telas e monitores", "Periféricos", true),
                new Categoria(5, "Categorias fora de uso", "Periféricos", true)
            };
            return View(categorias);
        }
    }

}
