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
        int waitTimerInt = 900;        // Delay between outputs. 1000 = 1 second.

        #endregion

        #region Constructor

        /// <summary>
        /// Base Constructor.
        /// </summary>
        public HanoiTower()
        {

        }

        /// <summary>
        /// Constructor which creates the three towers with the specified number of disks.
        /// Then runs recursion to solve. Displays all moves in console.
        /// </summary>
        /// <param name="numberOfDisks"></param>
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

        /// <summary>
        /// Creates tower with all the disks at start.
        /// </summary>
        /// <param name="currentTower">Name of full tower (at start).</param>
        private void CreateStartTower(HanoiDisk[] currentTower)
        {
            indexInt = numberOfDisksInt;

            while (indexInt > 0)
            {
                currentTower[indexInt - 1] = new HanoiDisk(indexInt);
                indexInt--;
            }
        }

        /// <summary>
        /// Creates towers with no disks at start.
        /// </summary>
        /// <param name="currentTower">Name of empty towers (at start).</param>
        private void CreateOtherTower(HanoiDisk[] currentTower)
        {
            indexInt = 0;
            while (indexInt < currentTower.Length)
            {
                currentTower[indexInt] = new HanoiDisk(0);
                indexInt++;
            }
        }

        /// <summary>
        /// Method that actually solves the problem.
        /// If n == 1, then updates the towers (visually) and displays result.
        /// Otherwise, recursively calls itself 3 times to take a step further into problem.
        /// </summary>
        /// <param name="n">Current n. Initially is the total number of disks.</param>
        /// <param name="source">The "source" tower. Initally is the tower with disks, or first tower.</param>
        /// <param name="auxilary">The "auxilary" tower. Initially is the first empty tower.</param>
        /// <param name="destination">the "destination" tower. Initially is the second empty tower.</param>
        private void MoveDisk(int n, HanoiDisk[] source, HanoiDisk[] auxilary, HanoiDisk[] destination)
        {
            // Base Case to exit recursive loop.
            if (n == 1)
            {
                Task.Delay(waitTimerInt).Wait();
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

        /// <summary>
        /// Display of all tower's current state.
        /// </summary>
        private void DisplayAllTowers()
        {
            Console.WriteLine(Environment.NewLine + Environment.NewLine);

            indexInt = 0;
            string displayString = "";
            // Each pass adds the contents of all towers (at current index) into a single, padded line.
            while (indexInt < numberOfDisksInt)
            {
                displayString +=
                    " " + tower1[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + " " +
                    " " + tower2[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + " " +
                    " " + tower3[indexInt].Display.PadRight((numberOfDisksInt + 1) * 4) + " " +
                    Environment.NewLine;
                indexInt++;
            }

            indexInt = 0;
            // Adds the "floor" to the display string as well. 
            while (indexInt < 3)
            {
                displayString +=
                    "".PadRight((numberOfDisksInt + 1) * 4, '-') + "" + "  ";
                indexInt++;
            }

            Console.WriteLine(displayString);

            Console.WriteLine(Environment.NewLine + Environment.NewLine);
        }

        /// <summary>
        /// Determines the index of the top-most disk in specified tower.
        /// </summary>
        /// <param name="currentTower">The tower to determine the disk index of.</param>
        /// <returns>The index which matches the top disk in the tower.</returns>
        private int GetTopDisk(HanoiDisk[] currentTower)
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

        /// <summary>
        /// Determines the index of the bottom-most free space in specified tower.
        /// </summary>
        /// <param name="currentTower">The tower to determine the free index of.</param>
        /// <returns>The index which matches the bottom free space in the tower.</returns>
        private int GetBottomBlank(HanoiDisk[] currentTower)
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

        /// <summary>
        /// Updates the contents of each array for when disks are moved.
        /// </summary>
        /// <param name="source">The tower a disk is comming off of.</param>
        /// <param name="destination">The tower a disk is being added to.</param>
        private void UpdateArray(HanoiDisk[] source, HanoiDisk[] destination)
        {
            int sourceIndex = GetTopDisk(source);
            int destinationIndex = GetBottomBlank(destination);

            tempDisk = destination[destinationIndex];
            destination[destinationIndex] = source[sourceIndex];
            source[sourceIndex] = tempDisk;
        }

        #endregion

    }
}
