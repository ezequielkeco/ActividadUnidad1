using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace ActividadUnidad1.Controllers
{
    public class ClaveController : Controller
    {
        public IActionResult Segura(string id)
        {
            bool esSegura = false;
            string mensaje;

            if (!string.IsNullOrWhiteSpace(id))
            {
                bool tieneLongitud = id.Length >= 8;
                bool tieneMayuscula = Regex.IsMatch(id, "[A-Z]");
                bool tieneNumero = Regex.IsMatch(id, "[0-9]");

                esSegura = tieneLongitud && tieneMayuscula && tieneNumero;

                mensaje = esSegura
                    ? "La contraseña es segura."
                    : "La contraseña NO es segura. Debe tener al menos 8 caracteres, una mayúscula y un número.";
            }
            else
            {
                mensaje = "No se proporcionó ninguna contraseña.";
            }

            ViewBag.Clave = id;
            ViewBag.Mensaje = mensaje;
            ViewBag.EsSegura = esSegura;

            return View();
        }
    }
}
