using System;
using DB;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;
using static DB.Main;

public static class Program
{

    public static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Main());

    }
}