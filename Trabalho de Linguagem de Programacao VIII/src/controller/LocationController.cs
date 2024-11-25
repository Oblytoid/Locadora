using Locadora.src.model;
using Locadora.src.services;
using System.Collections.Generic;

namespace Locadora.src.controller
{
    public class LocationController
    {
        private static LocacaoRepository locacaoRepository = new LocacaoRepository();

        public static bool RegisterLocation(LocationItem locacao)
        {
            return locacaoRepository.SaveLocation(locacao);

        }

        public static LocationItem GetLocation(int id)
        {
            return locacaoRepository.GetLocationById(id);
        }

        public static void MarkDelivered(LocationItem lc)
        {
            locacaoRepository.MarkAsDelivered(lc.Id);
        }

        public static List<LocationItem> GetAllLocations()
        {
            return locacaoRepository.GetAllLocations();
        }

        public static bool UpdateLocation(LocationItem locacao)
        {
            if (locacao.UserId <= 0 || locacao.GameId <= 0)
            {
                return false;
            }

            locacaoRepository.UpdateLocation(locacao);
            return true;
        }

        public static bool DeleteLocation(int id)
        {
            locacaoRepository.DeleteLocation(id);
            return true;
        }
    }
}
