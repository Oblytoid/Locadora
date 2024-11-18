using Locadora.src.model;
using Locadora.src.model.Locadora.src.model;
using Locadora.src.services;
using System.Collections.Generic;

namespace Locadora.src.controller
{
    public class LocacaoController
    {
        private LocacaoRepository locacaoRepository = new LocacaoRepository();

        public bool RegisterLocation(LocationItem locacao)
        {
            if (locacao.UserId <= 0 || locacao.GameId <= 0)
            {
                return false;
            }

            locacaoRepository.SaveLocation(locacao);
            return true;
        }

        public LocationItem GetLocation(int id)
        {
            return locacaoRepository.GetLocationById(id);
        }

        public List<LocationItem> GetAllLocations()
        {
            return locacaoRepository.GetAllLocations();
        }

        public bool UpdateLocation(LocationItem locacao)
        {
            if (locacao.UserId <= 0 || locacao.GameId <= 0)
            {
                return false;
            }

            locacaoRepository.UpdateLocation(locacao);
            return true;
        }

        public bool DeleteLocation(int id)
        {
            locacaoRepository.DeleteLocation(id);
            return true;
        }
    }
}
