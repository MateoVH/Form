using Form.API.Data;
using Form.API.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Threading.Tasks;
using Vereyon.Web;

namespace Form.API.Controllers
{
    public class UnicFormsController : Controller
    {
        private readonly DataContext _context;
        private readonly IFlashMessage _flashMessage;

        public UnicFormsController(
            DataContext context,
            IFlashMessage flashMessage)
        {
            _context = context;
            _flashMessage = flashMessage;
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(UnicForm form)
        {
            try
            {
                form.CreationDate = DateTime.Now;
                await _context.UnicForms.AddAsync(form);
                await _context.SaveChangesAsync();
                _flashMessage.Warning("El Registro se ha creado correctamente!");
            }
            catch
            {
                _flashMessage.Danger("Ya está registrado ese número de documento");
            }
            return RedirectToAction("Add", "UnicForms");
        }       
    }
}
