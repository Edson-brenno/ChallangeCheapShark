namespace ChallangeCheapShark.ControllerException{
    class NotNullDealsException:Exception{
        internal NotNullDealsException(){
            System.Console.WriteLine("There's no deals promotion");
        }
    }
}