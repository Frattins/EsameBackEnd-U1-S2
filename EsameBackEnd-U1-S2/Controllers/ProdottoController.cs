using EsameBackEnd_U1_S2.Data;
using Microsoft.AspNetCore.Mvc;
using EsameBackEnd_U1_S2.Models;

namespace EsameBackEnd_U1_S2.Controllers
{
    public class ProdottoController : Controller
    {
        public IActionResult Index()
        {
            var prodotti = ProdottoRepository.GetProdotti();
            return View(prodotti);
        }
            public IActionResult Dettagli(int id)
            {
                var prodotto = ProdottoRepository.GetProdottoById(id);
                if (prodotto == null)
                {
                    return NotFound();
                }
                return View(prodotto);
            }
        }
    }
