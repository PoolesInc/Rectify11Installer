﻿using System;
using System.IO;

namespace Rectify11Installer.Core
{
    public class Variables
    {
        // folder where rectify11 files are stored
        public static string r11Folder = Path.Combine(windir, "Rectify11");
        // folder which has every resource file
        public static string r11Files = Path.Combine(r11Folder, "files");
        
        // windows directories
        public static string windir = Environment.GetFolderPath(Environment.SpecialFolder.Windows);
        public static string sys32Folder = Environment.SystemDirectory;
        public static string sysWOWFolder = Environment.GetFolderPath(Environment.SpecialFolder.SystemX86);
        public static string sysresdir = Path.Combine(windir, "SystemResources");
        public static string brandingFolder = Path.Combine(windir, "Branding");
        public static string progfiles = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
        public static string progfiles86 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86);
        public static string diag = Path.Combine(windir, "diagnostics", "system");
        public static string winSxS = Path.Combine(windir, "WinSxS");
        public static bool isInstall = false;
    }
}
