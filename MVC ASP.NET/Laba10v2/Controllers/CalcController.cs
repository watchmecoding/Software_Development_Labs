using Laba10v2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laba10v2.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(OperandsModel model)
        {
            string result = string.Empty;
            string equasion = $"2*{model.X}^2 - 10{model.X} + 40";
            try
            {
                double a = 1;
                double b = -10;
                double c = 40;

                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)
                {
                    double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                    result = $"Рівняння {equasion} має два корені: x1 = {x1}, x2 = {x2}";
                }
                else if (discriminant == 0)
                {
                    double x = -b / (2 * a);
                    result = $"Рівняння {equasion} має один корінь: x1 = {x}";
                    Console.WriteLine($"Рівняння має один корінь: x = {x}");
                }
                else
                {
                    result = "Рівняння не має дійсних коренів";
                }
            }
            catch (Exception e)
            {
                result = "Виникла помилка: " + e.Message.ToString();
            }
            result += $". Результат рівняння {equasion} при x = {model.X}: {Math.Pow(model.X,2) - 10 * model.X + 40}";
            ViewBag.Result = result;
            return View();
        }
    }
}
