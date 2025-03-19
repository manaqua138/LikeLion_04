using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_Test
{
    public class GameMaster
    {
        Player iPlayer = new Player();
        Field iField = new Field();


        
        public void GameRender()
        {
            iPlayer.SetPlayerJob();

            while (true)
            {
                Console.Clear();
                iPlayer.Render();
                iField.RenderField1();
            }
        }

    }
}
