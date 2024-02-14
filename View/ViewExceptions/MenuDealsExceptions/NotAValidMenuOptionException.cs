namespace ChallangeCheapShark.ViewExceptions{
    internal class NotAValidMenuOptionException:Exception{
        internal NotAValidMenuOptionException(){
            System.Console.WriteLine("Error! Please, select a valid option.");
        }
    }
}