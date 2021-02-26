using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace Mvc_Allan.Controllers
{
    public class ProdutoController : Controller
    {
        public string Index()
        {
            return "Senai Suiço Brasileiro Paulo Ernesto Tolle";
        }

        public string Welcome()
        {
            return "Ola , seja bem vindo ao Senai Suiço Brasileiro Paulo Ernesto Tolle";
        }

        public string Contato(string email, string numero)
        {
            return $"Seu email é : {email} \n Seu número é : {numero}";
        }
    }
}