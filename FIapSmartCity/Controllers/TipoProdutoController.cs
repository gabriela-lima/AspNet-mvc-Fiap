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
        //Adicionando a validacao fazendo com que o usuario tenha que digitar algo na descricao para conseguir cadastrar um novo produto
        public IActionResult Cadastrar(Models.TipoProduto tipoProduto)
        {
            //usando outra forma de validacao pelo proprio modelo
            //validando o campo descricao
            //if(string.IsNullOrEmpty(tipoProduto.DescricaoTipo))
            //{
                //adicionando a mensagem de erro para descricao em branco
                //ModelState.AddModelError("Descricao", "Descrição obrigatória!");
            //}

            //se o ModelState nao tem erro
            if(ModelState.IsValid)
            {
                //Imprime os valores do modelo
                System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.DescricaoTipo);
                System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);

                //Simula que os dados foram gravados
                System.Diagnostics.Debug.Print("Gravando o Tipo de Produto");

                //Substituimos o return view() pelo metodo de redirecionamento
                return RedirectToAction("Index", "TipoProduto");
            }
            else
            {
                //caso encontre algum erro no preenchimento do campo descricao
                //retorna para a tela do formulario
                return View(tipoProduto);
            }
        }

        [HttpGet]
        public IActionResult Editar(int Id)
        {
            //imprime a mensagem de execucao
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = "+ Id);

            //cria o modelo que simula a consulta no banco de dados
            TipoProduto tipoProduto = new TipoProduto()
            {
                IdTipo = Id,
                DescricaoTipo = "Tinta",
                Comercializado = true
            };

            //retorna para a view o objeto modelo com as propriedades preenchidas com os dados do BD
            return View(tipoProduto);
        }

        [HttpPost]
        public IActionResult Editar(Models.TipoProduto tipoProduto)
        {
            //imprime valores do modelo
            System.Diagnostics.Debug.Print("Descrição: " + tipoProduto.DescricaoTipo);
            System.Diagnostics.Debug.Print("Comercializado: " + tipoProduto.Comercializado);

            //simula que os dados foram gravados
            System.Diagnostics.Debug.Print("Gravando o Tipo Editado");

            //Substituimos o return View() pelo metodo de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }

        [HttpGet]
        public IActionResult Consultar(int Id)
        {
            //imprime a mensagem de execucao
            System.Diagnostics.Debug.Print("Consultando o Tipo com Id = "+ Id);
            //cria o modelo que simula a consulta no banco de dados
            TipoProduto tipoProduto = new TipoProduto()
            {
                IdTipo = Id,
                DescricaoTipo = "Tinta",
                Comercializado = true
            };
            //retorna para a view o objeto modelo com as propriedades com dados do banco de dados
            return View(tipoProduto) ;
        }

        [HttpGet]
        public IActionResult Excluir(int Id)
        {
            //imprime a mensagem de execucao
            System.Diagnostics.Debug.Print("Excluir o tipo com Id = "+ Id);

            //substituimos o return View() pelo metodo de redirecionamento
            return RedirectToAction("Index", "TipoProduto");
        }
    }
}
