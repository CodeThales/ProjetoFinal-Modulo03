using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ThayNailDesign.Data;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class ClienteSqlService : IClienteService
    {
        ThayNailDesignContext _context; 
        public ClienteSqlService(ThayNailDesignContext context)
        {
            _context = context;
        }
        public List<Cliente> GetAll(string busca, bool sort = false)
        {
            if (busca != null)
            {
                return getCliente().FindAll(c => c.Nome.ToLower().Contains(busca.ToLower()));
            }

            if (sort)
            {
                var clientes = getCliente();
                clientes = clientes.OrderBy(c => c.Nome).ToList();
                return clientes;
            }

            return getCliente();
        }

        public Cliente GetSingle(int? id)
        {
            return getCliente().FirstOrDefault(c => c.Id == id);
        }

        public bool Create(Cliente cliente)
        {
            try
            {
                _context.Add(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool Update(Cliente cliente)
        {
            try
            {
                _context.Cliente.Update(cliente);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }            
        }

        public bool Delete(int? id)
        {
            try
            {
                _context.Cliente.Remove(GetSingle(id));
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<Cliente> getCliente()
        {
            List<Cliente> lista = _context.Cliente.ToList();
            return lista;
        }

    }
}

