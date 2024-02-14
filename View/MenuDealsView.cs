using ChallangeCheapShark.ViewExceptions;

namespace ChallangeCheapShark.View{
    internal class MenuDelsView{

        private void ShowMenuOptions(){

            System.Console.WriteLine("========================================");
            System.Console.WriteLine(" [1] See all the orfers");
            System.Console.WriteLine(" [2] See the best orfers");
            System.Console.WriteLine(" [3] Quit");
            System.Console.WriteLine("========================================");


        }

        private void AskForTheMenuOption(){
            try{
                System.Console.Write("Please, input the selected option: ");
                string option = System.Console.ReadLine() ?? String.Empty;
                System.Console.WriteLine($"You wrote {option}");
                this.ValidateMenuOption(option); 
            }
            catch(Exception ex){
                System.Console.WriteLine(ex.InnerException);
            }
            
        }

        private void ValidateMenuOption(string inputedMenuOption){
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
                System.Console.WriteLine("Everything is alright");
            }
        }
        internal void Main(){
            SystemPresentationView.ShowSystemName();

            this.ShowMenuOptions();

            this.AskForTheMenuOption();

            System.Console.Read();
        }
    }
}