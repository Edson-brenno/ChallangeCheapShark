using System.Dynamic;
using ChallangeCheapShark.Model;
using ChallangeCheapShark.ViewExceptions;

namespace ChallangeCheapShark.View{
    internal class OrfersPaginationView{

        private int totalOfRegister; //Total of items
        private int totalOfPages; // Total of pages
        private int totalPerPage; // Total per pages
        private int currentPage = 1; // Current Page
        private int startItemIndex; //The start item index
        private int endItemIndex; // The End item index
        private List<GameDealsModel> salesOrfers; //List of sale orfers

        private int choosedMenuOption;

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

        private void AskForThePaginationOption(){ //Ask the user the choosed pagination option

            while(true){
                try{
                    System.Console.Write("Write, the option: ");
                    string option = System.Console.ReadLine() ?? String.Empty;

                    if (this.ValidateThePaginationOption(option)){ //If the Menu choosed option is right
                        
                        this.choosedMenuOption = int.Parse(option);
                        break;
                    }; 
                }
                catch(Exception ex){
                    System.Console.WriteLine(ex.InnerException);
                    BaseView.ClearTheCurrentLine();
                }
            }
        }

        private bool ValidateThePaginationOption(string inputedPaginationOption){ //validate the user inputed option
            if (string.IsNullOrEmpty(inputedPaginationOption) || string.IsNullOrWhiteSpace(inputedPaginationOption)){
                throw new NoNullMenuOptionException();
            }
            else if (!char.IsDigit(inputedPaginationOption[0])){
                throw new MenuOptionIsNotADigitException();
            }
            else if (char.IsDigit(inputedPaginationOption[0]) && int.Parse(inputedPaginationOption) == 0){
                throw new NotAValidMenuOptionException();
            }
            else if ((this.currentPage == 1 || this.currentPage == this.totalOfPages) && char.IsDigit(inputedPaginationOption[0]) && int.Parse(inputedPaginationOption) > 3){
                throw new NotAValidMenuOptionException();
            }
            else if ((this.currentPage != 1 || this.currentPage != this.totalOfPages) && char.IsDigit(inputedPaginationOption[0]) && int.Parse(inputedPaginationOption) > 4){
                throw new NotAValidMenuOptionException();
            }
            else{
                return true;
            }
        }
        internal void ShowPage(){



        }
    }
}