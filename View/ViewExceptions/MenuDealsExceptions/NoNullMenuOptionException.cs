namespace ChallangeCheapShark.ViewExceptions{
    internal class NoNullMenuOptionException:Exception{
        internal NoNullMenuOptionException(){
            System.Console.WriteLine("Error! Please select one menu option.");
        }
    }
}