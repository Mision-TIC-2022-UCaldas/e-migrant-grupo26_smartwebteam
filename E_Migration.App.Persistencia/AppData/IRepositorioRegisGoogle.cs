using Microsoft.EntityFrameworkCore;
using E_Migration.App.Dominio;
using System.Collections.Generic;

namespace E_Migration.App.Persistencia
{

    //Crud RegisGoogle
    public interface IRepositorioRegisGoogle
    {
        IEnumerable<RegisGoogle> GetAllRegisGoogles();
        bool AddRegisGoogle(RegisGoogle regisGoogle);
        bool UpdateRegisGoogle(RegisGoogle regisGoogle);
        bool DeleteRegisGoogle(int idRegisGoogle);
        RegisGoogle GetRegisGoogle(int idRegisGoogle);
    }
}