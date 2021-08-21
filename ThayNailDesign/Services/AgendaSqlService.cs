﻿using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using ThayNailDesign.Data;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public class AgendaSqlService: IAgendaService
    {
        ThayNailDesignContext context;
        public AgendaSqlService(ThayNailDesignContext context)
        {
            this.context = context;
        }

        public List<Agenda> getAll(string userName)
        {
            string userId = context.Users.FirstOrDefault(u => u.UserName == userName).Id;
            return context.Agenda
                .Where(a => a.userId == userId)
                .Include(a => a.cliente).Include(a => a.servico).ToList();
        }

        public bool create(Agenda agenda, string userName)
        {
            string userId = context.Users.FirstOrDefault(u => u.UserName == userName).Id;
            agenda.userId = userId;
            agenda.servico = context.Servico.Find(agenda.servicoId);

            try
            {
                context.Agenda.Add(agenda);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public Agenda get(int? id)
        {
            return context.Agenda.Include(a => a.cliente).Include(a => a.servico).FirstOrDefault(a => a.id == id);
        }

        public bool update(Agenda agenda)
        {
            try
            {
                context.Agenda.Update(agenda);
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool delete(int? id)
        {
            try
            {
                context.Agenda.Remove(get(id));
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
