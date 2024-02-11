using DataLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Service
{
    public class DataBaseService : IDataBaseService
    {
        private IDiabloService _diabloService { get; set; }
        public DataBaseService(IDiabloService diabloService) 
        {
            _diabloService = diabloService;
        }

        public void seedData() 
        {
            // Récupération des données de l'api GET DE DIABLO SERVICE (POUR exemple)
            var Acts = _diabloService.GetActAsync();

            // Insert dans la base de donnée
        }
    }
}
