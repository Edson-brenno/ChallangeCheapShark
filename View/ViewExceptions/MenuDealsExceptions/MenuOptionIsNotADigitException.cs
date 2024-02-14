namespace ChallangeCheapShark.ViewExceptions{
    internal class MenuOptionIsNotADigitException:Exception{
        internal MenuOptionIsNotADigitException(){
            System.Console.WriteLine("Error! The menu option cannot be a Character.");
        }
    }
}