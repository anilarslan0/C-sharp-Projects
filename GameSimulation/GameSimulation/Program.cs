using GameSimulation.Concrete;
using GameSimulation.Entity;
using System;
using System.Collections.Generic;

namespace GameSimulation
{
    class Program
    {
        static void Main(string[] args)
        {


            PlayersInfo player1 = new PlayersInfo() { Name = "Anıl", Surname = "ARSLAN", Birthday = 1998, IdentityNo = "15896587458", Password = "1234" };
            PlayersInfo player2 = new PlayersInfo() { Name = "Melih", Surname = "Ustun", Birthday = 1996, IdentityNo = "2", Password = "4321" };
            PlayersInfo player3 = new PlayersInfo() { Name = "Umut", Surname = "Bozkurt", Birthday = 2002, IdentityNo = "3151621656", Password = "1111" };

            PlayerManager playerManager = new PlayerManager();
            playerManager.SignUp(player1);
            playerManager.SignUp(player3);
            playerManager.Login(player1);

            Game game1 = new Game() { GameName="CS GO",GamePrice=75};
            Game game2 = new Game() { GameName = "COD", GamePrice = 180 };
            Game game3 = new Game() { GameName = "NFS", GamePrice = 278 };

            Campaign winter= new Campaign() { CampaignName = "Winter", CampaignType = "%25" };
            Campaign summer = new Campaign() { CampaignName = "Summer", CampaignType = "%35" };
            Campaign legend = new Campaign() { CampaignName = "LegendNovember", CampaignType = "%15" };
            

            GameManager gameManager = new GameManager();
            gameManager.GameBuy(player1,game2,winter);
            gameManager.GameBuy(player2, game1, legend);

            playerManager.DeleteAccount(player3);



            List<PlayersInfo> players = new List<PlayersInfo>();
            players.Add(player1);
            players.Add(player2);
            players.Add(player3);
            players.Reverse();

    

            List<Game> games = new List<Game>();
            games.Add(game1);
            games.Add(game2);
            games.Add(game3);

        

            List<Campaign> campaigns = new List<Campaign>();
            campaigns.Add(winter);
            campaigns.Add(summer);
            campaigns.Add(legend);

         


            


        }
    }
}
