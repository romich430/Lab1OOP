using System.Collections.Generic;
using AppKit;

namespace Lab1
{
    static class MainClass
    {
        public static List<string> ColumnName = new List<string>();
        public static int rows = 0;
        public static int columns = 0;

        static void Main(string[] args)
        {
            NSApplication.Init();
            NSApplication.Main(args);
        }

        public static void ColumnInitialize(int columns)
        {
            int n = 1;
            char letter = 'A';
            ColumnName.Add("#");
            do
            {
                ColumnName.Add(letter.ToString());
                letter++;
                ViewController.tableView.AddColumn(new NSTableColumn("Cell")
                {
                    MinWidth = 100,
                    MaxWidth = 2000,
                    Width = 250,
                    Title = ColumnName[n],
                });
                n++;
            }
            while (n <= columns);

            
        }
    }
}
