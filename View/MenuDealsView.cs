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
            System.Console.Write("Please, input the selected option: ");
            string option = System.Console.ReadLine() ?? "";
            System.Console.WriteLine($"You wrote {option}");
        }
        internal void Main(){
            SystemPresentationView.ShowSystemName();

            this.ShowMenuOptions();

            this.AskForTheMenuOption();

            System.Console.Read();
        }
    }
}