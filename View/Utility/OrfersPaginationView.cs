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
        private List<GameDealsModel> salesOrfers; //List of sale orfers

        internal OrfersPaginationView(int totalOfItems, int sizePerPage, List<GameDealsModel> orfers){
            this.totalOfRegister = totalOfItems; 
            this.totalPerPage = sizePerPage;
            this.totalOfPages = (int)Math.Ceiling((double)totalOfRegister / sizePerPage); //Calculate the total of pages
            this.startItemIndex = (this.currentPage - 1) * sizePerPage;
            this.endItemIndex = ((this.currentPage - 1) * sizePerPage) + sizePerPage;
            this.salesOrfers = orfers;
        }

        internal void ShowTheTotalOfPages(){
            System.Console.WriteLine(this.totalOfPages);
        }

        private void NextPage(){ //Change the current page, startItemIndex, endItemIndex;
            this.currentPage += 1;
            this.startItemIndex = (this.currentPage - 1) * this.totalPerPage;
            this.endItemIndex = ((this.currentPage - 1) * this.totalPerPage) + this.totalPerPage;
        }

        private void PreviousPage(){ //Change the current page, startItemIndex, endItemIndex;
            if(this.currentPage > 1){
                this.currentPage -= 1;
                this.startItemIndex = (this.currentPage - 1) * this.totalPerPage;
                this.endItemIndex = ((this.currentPage - 1) * this.totalPerPage) + this.totalPerPage;
            }
        }

        private void ShowPaginationOptions(){ //Show the pagination options

            if(this.currentPage == 1){ // If it's the first page
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("          [1] Menu [2] Next Page [3] Quit");
                System.Console.WriteLine("========================================================");
            }
            else if (this.currentPage == this.totalOfPages){ //If it's the last page
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("          [1] Menu [2] Previous Page [3] Quit");
                System.Console.WriteLine("========================================================");
            }
            else{ 
                System.Console.WriteLine("========================================================");
                System.Console.WriteLine("   [1] Menu [2] Previous Page [3] Next Page [4] Quit");
                System.Console.WriteLine("========================================================");
            }
        }
        internal void ShowPage(){



        }
    }
}