using Microsoft.AspNetCore.Mvc;

namespace Moldovan_Paula_Lab1.Controllers
{
    public class Demo : Controller
    {
        public string Index()
        {
            return "Bun venit!";
        }

        public string Salut()
        {
            return "Salut!";
        }
        public string MesajPersonalizat(String nume, int numar)
        {
            nume = "Paula";
            numar = 2;
            return "Bine ai venit " + nume + " pentru a " + numar + "-a oara";
        }
    }
}
