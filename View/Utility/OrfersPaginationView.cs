using System.Dynamic;
using ChallangeCheapShark.Model;

namespace ChallangeCheapShark.View{
    internal class OrfersPaginationView{

        private int totalOfRegister; //Total of items
        private int totalOfPages; // Total of pages
        private int totalPerPage; // Total per pages
        private int currentPage = 1; // Current Page
        private int startItemIndex; //The start item index
        private int endItemIndex; // The End item index

        internal OrfersPaginationView(int totalOfItems, int sizePerPage){
            this.totalOfRegister = totalOfItems; 
            this.totalPerPage = sizePerPage;
            this.totalOfPages = (int)Math.Ceiling((double)totalOfRegister / sizePerPage); //Calculate the total of pages
            this.startItemIndex = (this.currentPage - 1) * sizePerPage;
            this.endItemIndex = ((this.currentPage - 1) * sizePerPage) + sizePerPage;
        }

        internal void ShowTheTotalOfPages(){
            System.Console.WriteLine(this.totalOfPages);
        }


        internal void ShowPage(int page, List<GameDealsModel> orfers){


        }
    }
}