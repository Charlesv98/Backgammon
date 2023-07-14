using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Backgammon
{
    public class Board 
    {
        public Player playerOne;
        public Player playerTwo;

        private Stack<Stone>[] boardArray;
        public void InitializeBoard()

        {

            boardArray = new Stack<Stone>[23];
            for (int i = 0; i < 23; i++)
            {
                boardArray[i] = new Stack<Stone>(5);
            }

            
        }

        private void InitializePositions()
        {
            // black
            for (int i = 0; i < 1; i++)
            {

                boardArray[0].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[5].Push(false);
            }

            for (int i = 0; i < 2; i++)
            {
                boardArray[7].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[11].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[12].Push(false);
            }

            for (int i = 0; i < 2; i++)
            {
                boardArray[16].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[18].Push(false);
            }

            for (int i = 0; i < 1; i++)
            {
                boardArray[23].Push(false);
            }
            // white
            for (int i = 0; i < 1; i++)
            {
                boardArray[0].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[5].Push(false);
            }

            for (int i = 0; i < 2; i++)
            {
                boardArray[7].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[11].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[12].Push(false);
            }

            for (int i = 0; i < 2; i++)
            {
                boardArray[16].Push(false);
            }

            for (int i = 0; i < 4; i++)
            {
                boardArray[18].Push(false);
            }

            for (int i = 0; i < 1; i++)
            {
                boardArray[23].Push(false);
            }
        }

        int[] xCoordinates = { 933, 857, 783, 708, 634, 558, 409, 333, 257, 183, 109, 33 };
        int[] yCoordinates = { 38, 104, 170, 236, 302, 743, 674, 607, 541, 474 };
        int xIndex = 0;
        int yIndex = 0;


    }
}
