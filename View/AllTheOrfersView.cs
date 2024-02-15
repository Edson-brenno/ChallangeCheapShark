using ChallangeCheapShark.Controller;
using ChallangeCheapShark.Model;

namespace ChallangeCheapShark.View{
    internal class AllTheOrfersView{
        private void ShowMenuOptionName(){ //Will show the menu option name
            System.Console.Clear();

            System.Console.WriteLine(@"
▄▀█ █░░ █░░   ▀█▀ █░█ █▀▀   █▀█ █▀█ █▀▀ █▀▀ █▀█ █▀
█▀█ █▄▄ █▄▄   ░█░ █▀█ ██▄   █▄█ █▀▄ █▀░ ██▄ █▀▄ ▄█");

            System.Console.WriteLine("========================================================");
        }

        private async Task ShowAllTheOrfers(){

            GameDealsController gameDealsController = new GameDealsController();
            List<GameDealsModel> orfers = await gameDealsController.GetGamesDeals();

            OrfersPaginationView pagination = new OrfersPaginationView(61,10);

            pagination.ShowTheTotalOfPages();
        }

        internal async Task Main(){
            this.ShowMenuOptionName();
            await this.ShowAllTheOrfers();
            
        }
    }
}