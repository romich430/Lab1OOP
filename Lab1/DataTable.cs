using System;
using AppKit;
using System.Collections.Generic;

namespace Lab1
{
    public class DataSource : NSTableViewDataSource
    {
        public List<List<string>> data = new List<List<string>>();

        public DataSource()
        {
            data = new List<List<string>>();
            data.Add(new List<string> {"1", "", "", "", "", ""});
            data.Add(new List<string> {"2", "", "", "", "", ""});
            data.Add(new List<string> {"3", "", "", "", "", ""});
        }

        public DataSource(int rows, int columns)
        {

            for (int n = 0; n < rows; n++)
            {
                data.Add(new List<string>());
                for (int k = 1; k < columns; k++)
                {
                    data[n].Add("");
                }
                data[n][0] = (n + 1).ToString();
            }
        }

        public DataSource(DataSource newData)
        {
            data = newData.data;
        }

        public override nint GetRowCount(NSTableView tableView)
        {
            return data.Count;
        }
    }
}
