using DataLayer.Service.Interface;
using Microsoft.Extensions.DependencyInjection;
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

        public void seedData(DiabloContext diabloContext) 
        {
            // Récupération des données de l'api GET DE DIABLO SERVICE (POUR exemple)
            var Acts = _diabloService.GetActAsync();
            // Récupération du service et du contexte
            //var context = new DiabloContext();

            //if (acts != null)
            //{
            //    // Insérez les données dans la base de données
            //    foreach (var act in acts.Acts)
            //    {
            //        // Vérifiez si l'acte existe déjà pour éviter les doublons
            //        if (!dbContext.Act.Any(a => a.Id == act.Id))
            //        {
            //            dbContext.Act.Add(act);
            //        }
            //    }

            //    await dbContext.SaveChangesAsync();
            //}
            // Insert dans la base de donnée
        }
    }
}
