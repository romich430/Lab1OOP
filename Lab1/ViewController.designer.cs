// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Lab1
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		AppKit.NSTextField columns { get; set; }

		[Outlet]
		AppKit.NSTextField rows { get; set; }

		[Outlet]
		AppKit.NSTableView TableView { get; set; }

		[Action ("AddColumn:")]
		partial void AddColumn (Foundation.NSObject sender);

		[Action ("AddRow:")]
		partial void AddRow (Foundation.NSObject sender);

		[Action ("AddRows:")]
		partial void AddRows (Foundation.NSObject sender);

		[Action ("DeleteColumn:")]
		partial void DeleteColumn (Foundation.NSObject sender);

		[Action ("DeleteRow:")]
		partial void DeleteRow (Foundation.NSObject sender);

		[Action ("UpdateButton:")]
		partial void UpdateButton (Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (columns != null) {
				columns.Dispose ();
				columns = null;
			}

			if (rows != null) {
				rows.Dispose ();
				rows = null;
			}

			if (TableView != null) {
				TableView.Dispose ();
				TableView = null;
			}
		}
	}
}
