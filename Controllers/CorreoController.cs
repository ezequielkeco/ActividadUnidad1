using Microsoft.AspNetCore.Mvc;

namespace ActividadUnidad1.Controllers
{
    public class CorreoController : Controller
    {
        public IActionResult Dominio(string correo)
        {
            string dominio = string.Empty;

                if (!string.IsNullOrWhiteSpace(correo) && correo.Contains('@'))
            {
                try
                {
                    dominio = correo.Split('@')[1];
                }
                catch (Exception)
                {
                    dominio = "No se pudo extraer el dominio.";
                }
            }
                 else
            {
                dominio = "Correo inválido.";
            }

    ViewBag.Correo = correo;
    ViewBag.Dominio = dominio;


            return View();
        }
    }
}
