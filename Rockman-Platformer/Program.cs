﻿using System;

namespace Lab06_Platformer
{
#if WINDOWS || LINUX
    /// <summary>
    /// The main class.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            using (var game = new PlatformerGame())
                game.Run();
        }
    }
#endif
}
