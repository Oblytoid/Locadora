using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Locadora.src.services;

namespace Locadora.src.model
{
    public class LocationItem
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int GameId { get; set; }
        public string GameName { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataEntrega { get; set; }
        public bool Entregue { get; set; }

        public LocationItem(int userId, int gameId, DateTime dataInicio, DateTime dataEntrega)
        {
            UserId = userId;
            GameId = gameId;
            DataInicio = dataInicio;
            DataEntrega = dataEntrega;
            Id = LocacaoRepository.GetLocationId(userId, gameId, dataInicio);
        }

        public LocationItem(int id, int userId, int gameId, DateTime dataInicio, DateTime dataEntrega, bool entregue)
        {
            Id = id;
            UserId = userId;
            GameId = gameId;
            DataInicio = dataInicio;
            DataEntrega = dataEntrega;
            Entregue = entregue;
            Id = LocacaoRepository.GetLocationId(userId, gameId, dataInicio);
        }

    }

}
