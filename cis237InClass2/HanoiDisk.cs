using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237InClass2
{
    /// <summary>
    /// Class to hold properties of individual disks.
    /// </summary>
    class HanoiDisk
    {
        #region Variables

        string diskDisplayString;       // What the disk will visually display as.
        int diskNumberInt;              // The disk number (aka ID).
        bool diskPresentBool;           // Bool for if space is empty or not.
        int indexInt;

        #endregion

        #region Constructor

        /// <summary>
        /// Base Constructor.
        /// </summary>
        public HanoiDisk()
        {

        }

        /// <summary>
        /// Constructor which creates a disk and populates all the variables.
        /// </summary>
        /// <param name="diskNumber">Number of disk on tower.</param>
        public HanoiDisk(int diskNumber)
        {
            DiskNumber = diskNumber;

            indexInt = 0;
            diskDisplayString = "";

            // Creates a Display String to visualize the size of the disk.
            while (indexInt < diskNumber)
            {
                diskDisplayString += "|##|";
                indexInt++;
            }

            // Determines if disk is present or spot is empty.
            if (diskNumber == 0)
            {
                diskPresentBool = false;
                //diskDisplayString += "*";
            }
            else
            {
                diskPresentBool = true;
            }
        }

        /// <summary>
        /// Constructor which creates a disk and populates all the variables.
        /// </summary>
        /// <param name="diskNumber">Number of disk on tower.</param>
        public HanoiDisk(int diskNumber, int maxNumberOfDisks)
        {
            DiskNumber = diskNumber;

            indexInt = 0;
            diskDisplayString = "";

            while ((maxNumberOfDisks - diskNumber) > indexInt)
            {
                diskDisplayString += " ";
                indexInt++;
            }

            diskDisplayString += "|";

            indexInt = 0;

            // Creates a Display String to visualize the size of the disk.
            while (indexInt < diskNumber)
            {
                diskDisplayString += "##";
                indexInt++;
            }

            diskDisplayString += "|";

            indexInt = 0;

            while ((maxNumberOfDisks - diskNumber) > indexInt)
            {
                diskDisplayString += " ";
                indexInt++;
            }

            // Determines if disk is present or spot is empty.
            if (diskNumber == 0)
            {
                diskPresentBool = false;
                //diskDisplayString += "*";
            }
            else
            {
                diskPresentBool = true;
            }
        }

        #endregion

        #region Properties

        public int DiskNumber
        {
            set
            {
                diskNumberInt = value;
            }
            get
            {
                return diskNumberInt;
            }
        }

        public string Display
        {
            get
            {
                return diskDisplayString;
            }
        }

        public bool DiskPresent
        {
            get
            {
                return diskPresentBool;
            }
        }

        #endregion

    }
}
