using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locadora.src.model
{
    namespace Locadora.src.model
    {
        public class LocationItem
        {
            public int Id { get; set; }
            public int UserId { get; set; }
            public int GameId { get; set; }
            public DateTime DataInicio { get; set; }
            public DateTime DataEntrega { get; set; }
            public bool Entregue { get; set; }

            public LocationItem(int userId, int gameId, DateTime dataInicio, DateTime dataEntrega, bool entregue)
            {
                UserId = userId;
                GameId = gameId;
                DataInicio = dataInicio;
                DataEntrega = dataEntrega;
                Entregue = entregue;
            }

            public LocationItem(int id, int userId, int gameId, DateTime dataInicio, DateTime dataEntrega, bool entregue)
            {
                Id = id;
                UserId = userId;
                GameId = gameId;
                DataInicio = dataInicio;
                DataEntrega = dataEntrega;
                Entregue = entregue;
            }
        }
    }

}
