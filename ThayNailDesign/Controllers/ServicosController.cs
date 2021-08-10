using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Models;
using ThayNailDesign.Services;

namespace ThayNailDesign.Controllers
{
    public class ServicosController : Controller
    {
        IServicoService service;

        public ServicosController(IServicoService service)
        {
            this.service = service;

        }

        public IActionResult Index()
        {
            return View(service.getAll());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            if (service.create(servico))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(servico);
            }
        }


        public IActionResult Read(int? id)
        {
            Servico servico = service.get(id);
            return servico != null ?
                View(servico) :
                NotFound();
        }

        public IActionResult Update(int? id)
        {
            Servico servico = service.get(id);
            return servico != null ?
                View(servico) :
                NotFound();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(Servico servico)
        {
            if (!ModelState.IsValid) return View(servico);

            if (service.update(servico))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View(servico);
            }
        }

        public IActionResult Delete(int? id)
        {
            if (service.delete(id))
            {
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        public IActionResult Confirm(int? id)
        {
            Servico servico = service.get(id);
            if (servico != null)
            {
                return View(nameof(Confirm));
            }
            return NotFound();
        }

    }
}
