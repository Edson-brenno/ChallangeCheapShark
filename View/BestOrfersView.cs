using ChallangeCheapShark.Controller;
using ChallangeCheapShark.Model;

namespace ChallangeCheapShark.View{
    internal class BestOrfersView{
        private string menuName = @"
█▄▄ █▀▀ █▀ ▀█▀   █▀█ █▀█ █▀▀ █▀▀ █▀█ █▀
█▄█ ██▄ ▄█ ░█░   █▄█ █▀▄ █▀░ ██▄ █▀▄ ▄█";
   
        private async Task ShowTheBestOrfers(){

            GameDealsController gameDealsController = new GameDealsController();
            List<GameDealsModel> orfers = await gameDealsController.GetGamesDeals();
            List<GameDealsModel> bestOrfers = orfers.GroupBy(g => g.Title).Select(select => select.OrderByDescending(d => d.Savings).First()).ToList();

            OrfersPaginationView pagination = new OrfersPaginationView(bestOrfers.Count(),9,bestOrfers);

            await pagination.Main(this.menuName);
        }

        internal async Task Main(){
            SystemPresentationView.ShowObtainingInformationsMensage();

            await this.ShowTheBestOrfers();
            
        }
    }
}