using Locadora.src.model;
using Locadora.src.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.controller
{
    class PlataformController
    {
        static PlataformRepository plataformRepository = new PlataformRepository();

        public static PlataformItem GetPlataformById(int id)
        {
            return plataformRepository.GetPlataformById(id);
        }

        public static string GetPlataformNameById(int id)
        {
            return plataformRepository.GetPlataformNameById(id);
        }

        public static List<PlataformItem> GetAll()
        {
            return plataformRepository.GetAllPlataforms();
        }
    }
}
