using System;
using ChallangeCheapShark.View;
using ChallangeCheapShark.Controller;

namespace ChallangeCheapShark{
    class ChallangeCheapShark{
        public static void Main(string[] args){
            
            SystemPresentationView.ShowPresentation();
            MenuDelsView menu = new MenuDelsView();
            menu.Main();
        } 
    }
}
