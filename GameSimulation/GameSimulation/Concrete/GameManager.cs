using GameSimulation.Abstract;
using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Concrete
{
    public class GameManager : IGameService , ICampaignService
    {
        public void AddNewCampaign(Campaign campaign)
        {
            Console.WriteLine("Yeni Kampanya Eklendi");
        }

        public void CampaignApply(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName+" Kampanya Görüntülendi");
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }

        public void GameBuy(PlayersInfo player,Game game, Campaign campaign)
        {
            Console.WriteLine(player.Name+" Adlı kullanıcı "+ game.GameName+" oyununu satın alındı.( "+campaign.CampaignName+" Kampanya kuponu uygulandı.)" );
        }

        public void GameGiveBack(PlayersInfo player, Game game)
        {
            Console.WriteLine(player.Name+" Adlı kullanıcı"+game.GameName + " oyununu iade etti.");
        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
