namespace ChallangeCheapShark.ViewExceptions{
    internal class MenuExceptionBase{
        internal static void ClearTheCurrentLine(){
            
            System.Console.SetCursorPosition(0, Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
        
        internal static void PutToSleep(){
            Thread.Sleep(2500);
        }
    }
}