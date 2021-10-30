using System;
using System.Collections.Generic;
using AppKit;
using Foundation;

namespace Lab1
{
    public partial class ViewController : NSViewController
    {
        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
        }

        public override NSObject RepresentedObject
        {
            get
            {
                return base.RepresentedObject;
            }
            set
            {
                base.RepresentedObject = value;
            }
        }

        public DataSource DataSource;
        public static NSTableView tableView = new NSTableView();

        public override void AwakeFromNib()
        {
            tableView = TableView;
        }

        partial void UpdateButton(NSObject sender)
        {
            DataSource = new DataSource(Int32.Parse(rows.StringValue), Int32.Parse(columns.StringValue));
            MainClass.ColumnInitialize(Int32.Parse(columns.StringValue));
            //DataSource newDataSource = new DataSource(DataSource);

            TableView.DataSource = DataSource;
            TableView.Delegate = new TableDelegate(DataSource);
        }
    }
}
