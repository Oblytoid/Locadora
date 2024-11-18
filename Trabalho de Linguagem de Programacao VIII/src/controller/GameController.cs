using Locadora.src.model;
using Locadora.src.services;
using System;
using System.Collections.Generic;

namespace Locadora.src.controller
{
    class GameController
    {
        public static List<Game> GetAllGames()
        {
            return GameRepository.GetAllGame();
        }

        public static void RegisterGame(Game game)
        {
            GameRepository.SaveGame(game);
        }

        public static List<Game> SearchGames(string search)
        {
            return GameRepository.SearchGames( search);
        }

        public static List<Game> GetGamesByPlatform(int platformId)
        {
            return GameRepository.GetGamesByPlatform(platformId);
        }

        public static List<Game> GetGamesByPublisher(int publisherId)
        {
            return GameRepository.GetGamesByPublisher(publisherId);
        }

        public static void UpdateGame(Game game)
        {
            GameRepository.UpdateGame(game);
        }

        public static void DeleteGame(Game game)
        {
            GameRepository.DeleteGame(game.Id);
        }
    }
}
