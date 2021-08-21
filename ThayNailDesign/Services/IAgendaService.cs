using System.Collections.Generic;
using ThayNailDesign.Models;

namespace ThayNailDesign.Services
{
    public interface IAgendaService
    {
        bool create(Agenda agenda, string userName);
        bool delete(int? id);
        Agenda get(int? id);
        List<Agenda> getAll(string userName);
        bool update(Agenda agenda);
        
    }
}
