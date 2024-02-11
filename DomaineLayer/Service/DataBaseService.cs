using DomaineLayer.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomaineLayer.Service
{
    public class DataBaseService : IDataBaseService
    {
        public readonly DataLayer.Service.Interface.IDataBaseService _dataBaseService;
        public DataBaseService(DataLayer.Service.Interface.IDataBaseService dataBaseService) 
        {
            _dataBaseService = dataBaseService;
        }

        public void seedData() 
        {
            _dataBaseService.seedData();
            // Appeler l'injection du service DatabaService mais coté Layer
        }
    }
}
