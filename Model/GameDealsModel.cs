namespace ChallangeCheapShark.Model{
    class GameDealsModel{
        public string? title {get;set;} // Game Tittle
        public string? salePrice {get;set;} // Price of sale
        public string? normalPrice {get;set;} // Normal price
        public string? isOnSale {get;set;} // Tell if it's on sale 1 = true and 0 = false
        public string? savings {get;set;} // Tell's how much the user will save in porcent
        public string? steamRatingText {get;set;} // Show's the game rating
        public string? steamRatingPorcent {get;set;} // Show's the game rating in porcent
        public string? steamRatingCount {get;set;} // Show's how much users have rated this game
        public long releaseDate {get;set;} // Date when the game was launched

        public override string ToString()
        {
            return $"{this.title} with {this.savings}% of discount ---- R$ {this.salePrice}";
        }
    }
}