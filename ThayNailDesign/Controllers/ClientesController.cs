using ThayNailDesign.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ThayNailDesign.Controllers
{
    public class ClientesController : Controller
    {
        List<Cliente> getCliente()
        {
            List<Cliente> clientes = new();
            clientes.Add(new Cliente { Id = 1, Nome = "Juliane", Telefone = "91111-1111", Nasc = new DateTime (2001,01,01) });
            clientes.Add(new Cliente { Id = 2, Nome = "Bárbara", Telefone = "92222-2222", Nasc = new DateTime(2002, 02, 02) });
            clientes.Add(new Cliente { Id = 3, Nome = "Letícia", Telefone = "93333-3333", Nasc = new DateTime(2003, 03, 03) });
            clientes.Add(new Cliente { Id = 4, Nome = "Débora", Telefone = "94444-4444", Nasc = new DateTime(2004, 04, 04) });
            clientes.Add(new Cliente { Id = 5, Nome = "Jessy", Telefone = "95555-5555", Nasc = new DateTime(2005, 05, 05) });
            clientes.Add(new Cliente { Id = 6, Nome = "Flávia", Telefone = "96666-6666", Nasc = new DateTime(2006, 06, 06) });
            clientes.Add(new Cliente { Id = 7, Nome = "Mariana", Telefone = "97777-7777", Nasc = new DateTime(2007, 07, 07) });
            clientes.Add(new Cliente { Id = 8, Nome = "Ingrid", Telefone = "98888-8888", Nasc = new DateTime(2008, 08, 08) });
            clientes.Add(new Cliente { Id = 9, Nome = "Simone", Telefone = "99999-9999", Nasc = new DateTime(2009, 09, 09) });
            clientes.Add(new Cliente { Id = 10, Nome = "Rosangela", Telefone = "91010-1010", Nasc = new DateTime(2010, 10, 10) });
            return clientes;       
        }

        public IActionResult Index(string nome, string sort = null)
        {
            List<Cliente> clientes = getCliente();

            if (sort == "nome")
            {
                clientes = clientes.OrderBy(c => c.Nome).ToList();
                ViewBag.sorted = true;
            }
            
            ViewBag.totClientes = clientes.Count();
            return View(nome == null ? clientes : clientes.FindAll(c => c.Nome.Contains(nome)));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Cliente cliente)
        {
            List<Cliente> clientes = getCliente();
            clientes.Add(cliente);
            cliente.Id = clientes.Max(c => c.Id) + 1;
            ViewBag.msg = "Cliente cadastrado com sucesso!";
            ViewBag.totClientes = clientes.Count();
            return View(nameof(Index), clientes);
        }

        public IActionResult Read(int? id)
        {
            Cliente cliente = getCliente().FirstOrDefault(c => c.Id == id);
            return View(cliente);
        }
        
        [HttpGet]
        public IActionResult Update(int? id)
        {
            var cliente = getCliente().Find(c => c.Id == id);
            if (cliente != null) return View(cliente);
            return NotFound();
        }
                
        [HttpPost]
        public IActionResult Update(Cliente cAtualizado)
        {
            List<Cliente> listaClientes = getCliente();
            Cliente cExistente = listaClientes.FirstOrDefault(c => c.Id == cAtualizado.Id);
            if (cExistente == null) return RedirectToAction(nameof(Index));

            var indice = listaClientes.IndexOf(cExistente);
            listaClientes[indice] = cAtualizado;
            return View(nameof(Index), listaClientes);
        }

        public IActionResult Delete(int? id)
        {
            List<Cliente> lista = getCliente();
            Cliente cliente = lista.FirstOrDefault(c => c.Id == id);
            if(cliente != null)
            {              

                lista.Remove(cliente);
                ViewBag.msg = "Cliente excluído com sucesso!";
                return View(nameof(Index), lista);
            }
            return NotFound();        
        }

        public IActionResult Confirm(int? id)
        {
            List<Cliente> lista = getCliente();
            Cliente cliente = lista.FirstOrDefault(c => c.Id == id);
            if (cliente != null)
            {               
                return View(nameof(Confirm));
            }
            return NotFound();
        }
    }
}
    