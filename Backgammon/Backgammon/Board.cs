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

        //private CircularPictureBox[] stones; // hrací kameny
        //private PictureBox[] spikes; // pole pro hrací místa
        //private PictureBox[] prison; // pole pro vězení
        //private PictureBox[] home; // pole pro domečky

        //public Board(PictureBox[] spikeBoxes, PictureBox[] prisonBox, PictureBox[] homeBoxes, CircularPictureBox[] stoneBoxes)
        //{
        //    spikes = spikeBoxes;
        //    prison = prisonBox;
        //    home = homeBoxes;
        //    stones = stoneBoxes;
        //}

        private Stack<bool>[] boardArray;
        public void InitializeBoard()
        {

            boardArray = new Stack<bool>[23];
            for (int i = 0; i < 23; i++)
            {
                boardArray[i] = new Stack<bool>(5);
            }
        }

        private void InitializePositions()
        {
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


        private void SetStonePosition(CircularPictureBox stone)
        {

            int x = xCoordinates[xIndex];
            int y = yCoordinates[yIndex];

            stone.Location = new Point(xCoordinates[xIndex], yCoordinates[yIndex]);

        }


        //private void GetStonesPositions()
        //{

        //    for (int i = 1; i <= 15; i++)
        //    {

        //        string blackStoneName = "BlackStone" + i;
        //        CircularPictureBox blackStone = Controls.Find(blackStoneName, true).FirstOrDefault() as CircularPictureBox;
        //        if (blackStone != null)
        //        {
        //            int xIndex = i - 1;
        //            int yIndex = 0;
        //            int x = xCoordinates[xIndex];
        //            int y = yCoordinates[yIndex];
        //            MessageBox.Show(blackStoneName + " je na pozici: " + x + ", " + y);
        //        }
        //    }


        //    for (int i = 1; i <= 15; i++)
        //    {

        //        string whiteStoneName = "WhiteStone" + i;
        //        CircularPictureBox whiteStone = Controls.Find(whiteStoneName, true).FirstOrDefault() as CircularPictureBox;
        //        if (whiteStone != null)
        //        {
        //            int xIndex = i - 1;
        //            int yIndex = 0;
        //            int x = xCoordinates[xIndex];
        //            int y = yCoordinates[yIndex];
        //            MessageBox.Show(whiteStoneName + " je na pozici: " + x + ", " + y);
        //        }
        //    }

        //}

        //private void GetStonesPositions(List<CircularPictureBox> blackStones, List<CircularPictureBox> whiteStones)
        //{
        //    for (int i = 0; i < blackStones.Count; i++)
        //    {
        //        string blackStoneName = "BlackStone" + (i + 1);
        //        CircularPictureBox blackStone = blackStones[i];
        //        int xIndex = i;
        //        int yIndex = 0;
        //        int x = xCoordinates[xIndex];
        //        int y = yCoordinates[yIndex];
        //        MessageBox.Show(blackStoneName + " je na pozici: " + x + ", " + y);
        //    }

        //    for (int i = 0; i < whiteStones.Count; i++)
        //    {
        //        string whiteStoneName = "WhiteStone" + (i + 1);
        //        CircularPictureBox whiteStone = whiteStones[i];
        //        int xIndex = i;
        //        int yIndex = 0;
        //        int x = xCoordinates[xIndex];
        //        int y = yCoordinates[yIndex];
        //        MessageBox.Show(whiteStoneName + " je na pozici: " + x + ", " + y);
        //    }
        //}

        

        private void UpdateBoard()
        {
            // Aktualizuje vykreslení hrací desky na základě aktuálního stavu hry.
        }

        private void MovePiece()
        {
            // Přesune hrací kámen z jednoho hracího místa na druhé.

        }

        private void AddPieceToPrison()
        {
            // Přidá hrací kámen do vězení pro daného hráče.
        }

        private void RemovePieceFromPrison()
        {
            // Odebere hrací kámen z vězení pro daného hráče.
        }

        private void AddPieceToHome()
        {
            // Přidá hrací kámen do domečku pro daného hráče.
        }

        private void BoardReading()
        {
            // Zaznamenává tahy do nějakého okénka 
        }

        private void ResetBoard()
        {
            // Resetování hrací plochy
        }

    }
}
