using System;
using ChallangeCheapShark.View;
using ChallangeCheapShark.Controller;

namespace ChallangeCheapShark{
    class ChallangeCheapShark{
        public static async Task Main(string[] args){
            SystemPresentationView.ShowPresentation();
            SystemPresentationView.ShowSystemName();
            GameDealsController game = new GameDealsController();
            await game.GetGamesDeals();
        } 
    }
}
