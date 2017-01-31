using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Gawa.ACRender
{
    public class Settings
    {
        /*
        public static FileInfo PortalDatFile = new FileInfo(@"P:\CrackRoot\CellPortal\dump\Dat Files\2006 Core\portal.dat");
        public static DatType PortalDatType = DatType.Portal_ACDM;
        public static FileInfo CellDatFile = new FileInfo(@"P:\CrackRoot\CellPortal\dump\Dat Files\2006 Core\CELL.DAT");
        public static DatType CellDatType = DatType.Cell_ACDM;
        */
        public static FileInfo PortalDatFile = new FileInfo(@"P:\Turbine\Asheron's Call\client_portal.dat");
        public static DatType PortalDatType = DatType.Portal_ToD;

        public static FileInfo CellDatFile = new FileInfo(@"P:\Turbine\Asheron's Call\client_CELL_1.DAT");
        public static DatType CellDatType = DatType.Cell_ToD;

        public static string TreeExportDir = @"P:\CrackRoot\CellPortal\dump\Utilities\ACRender\tmp\";
        public static string FileListCacheDir = @"P:\CrackRoot\CellPortal\dump\Utilities\ACRender\tmp\";


        /*
        public static FileInfo PortalDatFile = new FileInfo(@"E:\gawa\data\acrender\ToD\client_portal.dat");
        public static DatType PortalDatType = DatType.Portal_ToD;
        //public static FileInfo PortalDatFile = new FileInfo(@"E:\Program Files\Turbine\Asheron's Call - Throne of Destiny 2\client_portal.dat");
        //public static DatType PortalDatType = DatType.Portal_ToD;

        public static FileInfo CellDatFile = new FileInfo(@"E:\gawa\data\acrender\ToD\client_cell_1.dat");
        public static DatType CellDatType = DatType.Cell_ToD;
          
        public static string TreeExportDir = @"E:\gawa\data\acrender\ToD";
        public static string FileListCacheDir = @"E:\gawa\data\acrender\ToD\";
         */

    }
}
