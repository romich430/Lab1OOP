using System;
using AppKit;

namespace Lab1
{
    public class TableDelegate: NSTableViewDelegate
    {
        public TableDelegate()
        {

        }
        private const string CellIdentifier = "Cell";
        private DataSource DataSource;

        public TableDelegate(DataSource datasource)
        {
            this.DataSource = datasource;
        }

        public override NSView GetViewForItem(NSTableView tableView, NSTableColumn tableColumn, nint row)
        {
            NSTextField view = (NSTextField)tableView.MakeView(CellIdentifier, this);
            if (view == null)
            {
                view = new NSTextField();
                view.Identifier = CellIdentifier;
                view.BackgroundColor = NSColor.Clear;
                view.Bordered = false;
                view.Selectable = false;
                view.Editable = false;
            }

            if (MainClass.ColumnName.Contains(tableColumn.Title))
            {
                view.StringValue = DataSource.data[(int)row][MainClass.ColumnName.IndexOf(tableColumn.Title)];
            }

            return view;
        }
    }
}