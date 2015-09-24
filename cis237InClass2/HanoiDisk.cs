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

        string diskDisplayString;
        int diskNumberInt;
        bool diskPresentBool;
        int indexInt;

        #endregion

        #region Constructor

        public HanoiDisk(int diskNumber)
        {
            DiskNumber = diskNumber;

            indexInt = 0;
            diskDisplayString = "";
            while (indexInt < diskNumber)
            {
                diskDisplayString += "|##|";
                indexInt++;
            }

            // Determines if disk is in spot.
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

        #region Methods

        #endregion
    }
}
