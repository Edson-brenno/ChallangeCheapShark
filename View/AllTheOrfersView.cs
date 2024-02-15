using ChallangeCheapShark.Controller;
using ChallangeCheapShark.Model;

namespace ChallangeCheapShark.View{
    internal class AllTheOrfersView{

        private string menuName = @"
▄▀█ █░░ █░░   ▀█▀ █░█ █▀▀   █▀█ █▀█ █▀▀ █▀▀ █▀█ █▀
█▀█ █▄▄ █▄▄   ░█░ █▀█ ██▄   █▄█ █▀▄ █▀░ ██▄ █▀▄ ▄█";
   
        private async Task ShowAllTheOrfers(){

            GameDealsController gameDealsController = new GameDealsController();
            List<GameDealsModel> orfers = await gameDealsController.GetGamesDeals();

            OrfersPaginationView pagination = new OrfersPaginationView(orfers.Count(),9,orfers);

            await pagination.Main(this.menuName);
        }

        internal async Task Main(){
            SystemPresentationView.ShowObtainingInformationsMensage();

            await this.ShowAllTheOrfers();
            
        }
    }
}