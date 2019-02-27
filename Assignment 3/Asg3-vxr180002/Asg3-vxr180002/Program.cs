/*
    Written by Vishal Chandar Ramachandran for CS6326.001 Spring 19
    For Assignment 3 - Rebate form evaluation program starting February 24, 2019.
    Netid: vxr180002
    Available on Github@:  https://github.com/vxr180002/CS6326
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asg3_vxr180002
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
