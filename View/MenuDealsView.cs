using ChallangeCheapShark.ViewExceptions;

namespace ChallangeCheapShark.View{
    internal class MenuDelsView{

        private int choosedMenuOption;

        private void ShowMenuOptions(){ //Show the menu Options
 
            System.Console.WriteLine("========================================");
            System.Console.WriteLine(" [1] See all the orfers");
            System.Console.WriteLine(" [2] See the best orfers");
            System.Console.WriteLine(" [3] Quit");
            System.Console.WriteLine("========================================");


        }

        private void AskForTheMenuOption(){ //Will ask the user to type the menu option
            while(true){

                try{
                    System.Console.Write("Please, input the selected option: ");
                    string option = System.Console.ReadLine() ?? String.Empty;

                    if (this.ValidateMenuOption(option)){ //If the Menu choosed option is right
                        
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

        private bool ValidateMenuOption(string inputedMenuOption){ // Validate the inputed menu option
            if (string.IsNullOrEmpty(inputedMenuOption) || string.IsNullOrWhiteSpace(inputedMenuOption)){
                throw new NoNullMenuOptionException();
            }
            else if (!char.IsDigit(inputedMenuOption[0])){
                throw new MenuOptionIsNotADigitException();
            }
            else if (char.IsDigit(inputedMenuOption[0]) && int.Parse(inputedMenuOption) > 3 || char.IsDigit(inputedMenuOption[0]) && int.Parse(inputedMenuOption) == 0){
                throw new NotAValidMenuOptionException();
            }
            else{
                return true;
            }
        }

        private void ShowTheChoosedMenuOption(){
            try{

                switch(this.choosedMenuOption){
                    
                    case 1:
                        System.Console.WriteLine("See all the orfers");
                        break;
                    
                    case 2:
                        System.Console.WriteLine("See the best orfers");
                        break;
                    
                    case 3:
                        System.Console.WriteLine("Good Bye");
                        break;
                    default:
                        throw new NotAValidMenuOptionException();
                }
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.InnerException);
            }
        }
        internal void Main(){ //The main Function
        
            SystemPresentationView.ShowSystemName();

            this.ShowMenuOptions();

            this.AskForTheMenuOption();

            this.ShowTheChoosedMenuOption();

        }
    }
}