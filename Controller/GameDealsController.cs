using System;
using System.Data;
using System.Text.Json;
using ChallangeCheapShark.Model;
using ChallangeCheapShark.ControllerException;


namespace ChallangeCheapShark.Controller{
    class GameDealsController{

        private string apiUrl = "https://www.cheapshark.com/api/1.0/deals"; //The api url
        internal async Task GetGamesDeals(){ // Will return the sales
            try{

                using(HttpClient client = new HttpClient()){
                    
                    string answer = await client.GetStringAsync(this.apiUrl);
                    
                    List<GameDealsModel> sales = JsonSerializer.Deserialize<List<GameDealsModel>>(answer) ?? throw new NotNullDealsException();

                    sales.Where(b => b.isOnSale == "1").GroupBy(c => c.title).Select(group => group.OrderByDescending(order => order.savings).First()).ToList().ForEach(a => {System.Console.WriteLine(a.ToString());});
                  
                }

            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

        }
    }
}