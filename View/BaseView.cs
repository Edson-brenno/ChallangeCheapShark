namespace ChallangeCheapShark.View{
    internal class BaseView{
        internal static void ClearTheCurrentLine(){
            System.Console.SetCursorPosition(0, Console.CursorTop - 1);

            System.Console.WriteLine(new string(' ', Console.WindowWidth));

            System.Console.SetCursorPosition(0, Console.CursorTop - 1);
        }
    }
}