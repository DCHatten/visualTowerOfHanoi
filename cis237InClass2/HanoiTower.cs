using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    /// <summary>
    /// Class which solves Hanoi Tower Problem.
    /// </summary>
    class HanoiTower
    {
        #region Variables

        HanoiDisk tempDisk;

        HanoiDisk[] tower1;
        HanoiDisk[] tower2;
        HanoiDisk[] tower3;

        int numberOfDisksInt;
        int indexInt;

        #endregion

        #region Constructor

        public HanoiTower(int numberOfDisks)
        {
            NumberOfDisks = numberOfDisks;

            tower1 = new HanoiDisk[numberOfDisksInt];
            tower2 = new HanoiDisk[numberOfDisksInt];
            tower3 = new HanoiDisk[numberOfDisksInt];


            CreateStartTower(tower1);
            CreateOtherTower(tower2);
            CreateOtherTower(tower3);

            DisplayAllTowers();
            MoveDisk(numberOfDisksInt, tower1, tower2, tower3);
        }

        #endregion

        #region Properties

        public int NumberOfDisks
        {
            set
            {
                numberOfDisksInt = value;
            }
        }


        #endregion

        #region Methods

        private void CreateStartTower(HanoiDisk[] currentTower)
        {
            indexInt = numberOfDisksInt;

            while (indexInt > 0)
            {
                currentTower[indexInt - 1] = new HanoiDisk(indexInt);
                indexInt--;
            }
        }

        private void CreateOtherTower(HanoiDisk[] currentTower)
        {
            indexInt = 0;
            while (indexInt < currentTower.Length)
            {
                currentTower[indexInt] = new HanoiDisk(0);
                indexInt++;
            }
        }

        public void MoveDisk(int n, HanoiDisk[] source, HanoiDisk[] auxilary, HanoiDisk[] destination)
        {
            
            // Base Case to exit recursive loop.
            if (n == 1)
            {
                UpdateArray(source, destination);
                DisplayAllTowers();
            }
            else
            {
                // Attempt to move (n-1) from source location to auxilary location, using destination as temp.
                MoveDisk(n - 1, source, destination, auxilary);
                // Move source to destination.
                MoveDisk(1, source, auxilary, destination);
                // Attempt to move (n-1) from auxilary location to destination location, using source as temp.
                MoveDisk(n-1, auxilary, source, destination);
            }
        }

        public void DisplayAllTowers()
        {
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            indexInt = 0;
            string displayString = "";
            while (indexInt < numberOfDisksInt)
            {
                displayString +=
                    tower1[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + "  " +
                    tower2[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + "  " +
                    tower3[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + "  " +
                    Environment.NewLine;
                indexInt++;
            }

            indexInt = 0;
            while (indexInt < numberOfDisksInt)
            {
                displayString +=
                    "".PadRight((numberOfDisksInt + 1) * 4, '-') + "" + "  ";
                indexInt++;
            }

            Console.WriteLine(displayString);

            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            /*Console.WriteLine(Environment.NewLine + Environment.NewLine);
            Console.WriteLine(DisplayTower(tower1));
            Console.WriteLine(DisplayTower(tower2));
            Console.WriteLine(DisplayTower(tower3));
            Console.WriteLine(Environment.NewLine + Environment.NewLine);*/
        }

        public string DisplayTower(HanoiDisk[] currentTower)
        {
            indexInt = 0;
            string displayString = "";
            while (indexInt < numberOfDisksInt)
            {
                displayString += currentTower[indexInt].Display + Environment.NewLine;
                indexInt++;
            }

            indexInt = 0;
            displayString += "--";
            while (indexInt < numberOfDisksInt)
            {
                displayString += "----";
                indexInt++;
            }
            displayString += "--" + Environment.NewLine;

            return displayString;
        }

        public int GetTopDisk(HanoiDisk[] currentTower)
        {
            indexInt = 0;
            while (indexInt < numberOfDisksInt - 1)
            {
                if (currentTower[indexInt].DiskPresent)
                {
                    return indexInt;
                }
                indexInt++;
            }
            return indexInt;
        }

        public int GetTopBlank(HanoiDisk[] currentTower)
        {
            indexInt = 0;
            while (indexInt < numberOfDisksInt - 1)
            {
                if (currentTower[indexInt + 1].DiskPresent)
                {
                    return indexInt;
                }
                indexInt++;
            }
            return indexInt;
        }

        public void UpdateArray(HanoiDisk[] source, HanoiDisk[] destination)
        {

            // Move source to destination.
            //MoveDisk(1, source, auxilary, destination);
            int sourceIndex = GetTopDisk(source);
            int destinationIndex = GetTopBlank(destination);

            tempDisk = destination[destinationIndex];
            destination[destinationIndex] = source[sourceIndex];
            source[sourceIndex] = tempDisk;
        }

        #endregion

    }
}
