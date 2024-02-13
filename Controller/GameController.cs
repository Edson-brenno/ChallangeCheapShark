using System;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Runtime.InteropServices;
using System.Text.Json;
using ChallangeCheapShark.Model;


namespace ChallangeCheapShark.Controller{
    class GameController{

        private string apiUrl = "https://www.cheapshark.com/api/1.0/deals";
        internal async Task GetGamesSales(){
            System.Console.WriteLine("Chegou aqui");
            try{
                using(HttpClient client = new HttpClient()){
                    System.Console.WriteLine("Iniciou");
                    string answer = await client.GetStringAsync(this.apiUrl);
                    System.Console.WriteLine("CHegou");

                    List<GameModel> sales = JsonSerializer.Deserialize<List<GameModel>>(answer) ?? throw new NoNullAllowedException();

                    sales.Where(b => b.isOnSale == "1").ToList().ForEach(a => {System.Console.WriteLine(a.ToString());});
                  
                }
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.Message);
            }

            return;
        }
    }
}