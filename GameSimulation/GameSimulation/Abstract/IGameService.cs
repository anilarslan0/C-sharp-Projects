using GameSimulation.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulation.Abstract
{
    public interface IGameService
    {
        void GameBuy(PlayersInfo player, Game game, Campaign campaign);

        void GameGiveBack(PlayersInfo player, Game game);

        void AddNewCampaign(Campaign campaign);
        void UpdateCampaign(Campaign campaign);
        void DeleteCampaign(Campaign campaign);
    }
}
