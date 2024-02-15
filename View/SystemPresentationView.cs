using System;


namespace ChallangeCheapShark.View{
    class SystemPresentationView{
        internal static void ShowPresentation(){ // Will do the System Presentation

            System.Console.Clear();

            System.Console.WriteLine(@"
█▀ █░█ █▀▀ ▄▀█ █▀█ █▀ █░█ ▄▀█ █▀█ █▄▀
▄█ █▀█ ██▄ █▀█ █▀▀ ▄█ █▀█ █▀█ █▀▄ █░█");

            System.Console.WriteLine("Loading...");

            Thread.Sleep(4000);

            System.Console.Clear();
        }

        internal static void ShowSystemName(){ // Will Show the System's name
            System.Console.WriteLine(@"
█▀ █░█ █▀▀ ▄▀█ █▀█ █▀ █░█ ▄▀█ █▀█ █▄▀
▄█ █▀█ ██▄ █▀█ █▀▀ ▄█ █▀█ █▀█ █▀▄ █░█");
        }

        internal static void ShowObtainingInformationsMensage(){
            System.Console.Clear();

            System.Console.WriteLine(@"
█▀ █░█ █▀▀ ▄▀█ █▀█ █▀ █░█ ▄▀█ █▀█ █▄▀
▄█ █▀█ ██▄ █▀█ █▀▀ ▄█ █▀█ █▀█ █▀▄ █░█");

            System.Console.WriteLine("========================================================");

            System.Console.WriteLine("Obtaining informations..");
        }
    }
}