using DataLayer.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service.Interface
{
    public interface IDiabloService
    {
        Task<DiabloActs?> GetActAsync();

    }
}
