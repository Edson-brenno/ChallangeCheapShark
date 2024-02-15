using ChallangeCheapShark.ViewInterfaces;

namespace ChallangeCheapShark.ViewExceptions{
    internal class NoNullMenuOptionException:Exception{
        internal NoNullMenuOptionException(){
            
            MenuExceptionBase.ClearTheCurrentLine();

            System.Console.WriteLine("Error! Please select one menu option.");

            MenuExceptionBase.PutToSleep();

            MenuExceptionBase.ClearTheCurrentLine();
        }
    }
}