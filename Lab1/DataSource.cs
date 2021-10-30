using System;
using System.Collections.Generic;
using AppKit;

namespace Lab1
{
    public class DataSource: NSTableViewDataSource
    {
        public List<List<string>> data;

        public DataSource()
        {
            data = new List<List<string>>();
            int n = 0;
            data.Add(new List<string>{"", ""});
            data.Add(new List<string> { "", "" });
            data.Add(new List<string> { "", "" });
            data.Add(new List<string> { "", "" });
            foreach (List<string> row in data)
            {
                foreach (string cell in row)
                {
                    row[n] = "1";
                    n++;
                }
            }
        }

        public override nint GetRowCount(NSTableView tableView)
        {
            return data.Count;
        }
    }
}
