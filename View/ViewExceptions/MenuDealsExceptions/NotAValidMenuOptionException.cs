namespace ChallangeCheapShark.ViewExceptions{
    internal class NotAValidMenuOptionException:Exception{
        internal NotAValidMenuOptionException(){
            MenuExceptionBase.ClearTheCurrentLine();
            System.Console.WriteLine("Error! Please, select a valid option.");
            MenuExceptionBase.PutToSleep();
            MenuExceptionBase.ClearTheCurrentLine();
        }
    }
}