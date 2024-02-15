using System;
using ChallangeCheapShark.View;
using ChallangeCheapShark.Controller;

namespace ChallangeCheapShark{
    class ChallangeCheapShark{
        public static async Task Main(string[] args){
            
            SystemPresentationView.ShowPresentation();
            MenuDelsView menu = new MenuDelsView();
            await menu.Main();
        } 
    }
}
