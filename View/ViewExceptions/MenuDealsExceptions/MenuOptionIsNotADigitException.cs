namespace ChallangeCheapShark.ViewExceptions{
    internal class MenuOptionIsNotADigitException:Exception{
        internal MenuOptionIsNotADigitException(){

            MenuExceptionBase.ClearTheCurrentLine();
            System.Console.WriteLine("Error! The menu option cannot be a Character.");
            MenuExceptionBase.PutToSleep();
            MenuExceptionBase.ClearTheCurrentLine();
        }
    }
}