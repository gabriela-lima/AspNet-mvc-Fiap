using FIapSmartCity.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIapSmartCity.Controllers
{
    public class TipoProdutoController : Controller
    {
        public IActionResult Index()
        {
            //criando o atributo da lista
            IList<Models.TipoProduto> listaTipo = new List<Models.TipoProduto>();

            //adicionando na lista o TipoProduto da tinta
            listaTipo.Add(new Models.TipoProduto()
            {
                IdTipo = 1,
                DescricaoTipo = "Tinta",
                Comercializado = true
            });

            listaTipo.Add(new Models.TipoProduto()
            {
                IdTipo = 2,
                DescricaoTipo = "Filtro de agua",
                Comercializado = true
            });

            listaTipo.Add(new Models.TipoProduto()
            {
                IdTipo = 3,
                DescricaoTipo = "Captador de energia",
                Comercializado = true
            });

            //retornando para a View a lista de tipos
            return View(listaTipo);
        }

        //Anotação do uso do Verb HTTP Get
        [HttpGet]
        public IActionResult Cadastrar()
        {
            //Imprime a mensagem de execução
            System.Diagnostics.Debug.Print("Executou a Action Cadastrar()");

            //Retorna para a view cadastrar um objeto modelo com as propriedades em branco
            return View(new TipoProduto());
        }

        //Anotação Ver HTTP Post
        [HttpPost]
        public IActionResult Cadastrar(Models.TipoProduto tipoProduto)
        {
            //Imprime os valores do modelo
            System.Diagnostics.Debug.Print("Descrição: "+ tipoProduto.DescricaoTipo);
            System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);

            //Simula que os dados foram gravados
            System.Diagnostics.Debug.Print("Gravando o Tipo de Produto");

            //Substituimos o return view() pelo metodo de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }
    }
}
