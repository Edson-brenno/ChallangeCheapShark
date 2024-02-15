using ChallangeCheapShark.ViewExceptions;

namespace ChallangeCheapShark.View{
    internal class MenuDelsView{

        private void ShowMenuOptions(){ //Show the menu Options
 
            System.Console.WriteLine("========================================");
            System.Console.WriteLine(" [1] See all the orfers");
            System.Console.WriteLine(" [2] See the best orfers");
            System.Console.WriteLine(" [3] Quit");
            System.Console.WriteLine("========================================");


        }

        private void ClearTheCurrentLine(){ //Will clear the current line
            System.Console.SetCursorPosition(0, Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        private void AskForTheMenuOption(){ //Will ask the user to type the menu option
            while(true){

                try{
                    System.Console.Write("Please, input the selected option: ");
                    string option = System.Console.ReadLine() ?? String.Empty;

                    if (this.ValidateMenuOption(option)){ //If the Menu option chosed is right
                        break;
                    }; 
                }
                catch(Exception ex){

                    System.Console.WriteLine(ex.InnerException);
                    this.ClearTheCurrentLine();
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
        internal void Main(){ //The main Function
        
            SystemPresentationView.ShowSystemName();

            this.ShowMenuOptions();

            this.AskForTheMenuOption();

        }
    }
}