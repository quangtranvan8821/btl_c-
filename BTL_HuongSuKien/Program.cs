﻿using BTL_HuongSuKien.Forms;
using System;
using System.Windows.Forms;

namespace BTL_HuongSuKien
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new QuanLiNhanVien());
        }
    }
}
