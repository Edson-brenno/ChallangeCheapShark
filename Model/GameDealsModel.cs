using System.Text.Json;
using System.Text.Json.Serialization;

namespace ChallangeCheapShark.Model{
    class GameDealsModel{
        [JsonPropertyName("title")]
        public string? Title {get;set;} // Game Tittle
        [JsonPropertyName("SalePrice")]
        public string? SalePrice {get;set;} // Price of sale
        [JsonPropertyName("normalPrice")]
        public string? NormalPrice {get;set;} // Normal price
        [JsonPropertyName("isOnSale")]
        public string? IsOnSale {get;set;} // Tell if it's on sale 1 = true and 0 = false
        [JsonPropertyName("savings")]
        public string? Savings {get;set;} // Tell's how much the user will save in porcent
        [JsonPropertyName("steamRatingText")]
        public string? SteamRatingText {get;set;} // Show's the game rating
        [JsonPropertyName("steamRatingPorcent")]
        public string? SteamRatingPorcent {get;set;} // Show's the game rating in porcent
        [JsonPropertyName("steamRatingCount")]
        public string? SteamRatingCount {get;set;} // Show's how much users have rated this game
        [JsonPropertyName("releaseDate")]
        public long ReleaseDate {get;set;} // Date when the game was launched

        public override string ToString()
        {
            return $"{this.Title} with {decimal.Parse(this.Savings ?? "0").ToString("0.00")}% of discount ---- R$ {this.SalePrice}";
        }
    }
}