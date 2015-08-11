// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace BookList
{
	[Register ("ViewController")]
	partial class ViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIButton btnAdd { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView tblBooks { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtISBN { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITextField txtTitle { get; set; }

		[Action ("btnAdd_TouchUpInside:")]
		[GeneratedCode ("iOS Designer", "1.0")]
		partial void btnAdd_TouchUpInside (UIButton sender);

		void ReleaseDesignerOutlets ()
		{
			if (btnAdd != null) {
				btnAdd.Dispose ();
				btnAdd = null;
			}
			if (tblBooks != null) {
				tblBooks.Dispose ();
				tblBooks = null;
			}
			if (txtISBN != null) {
				txtISBN.Dispose ();
				txtISBN = null;
			}
			if (txtTitle != null) {
				txtTitle.Dispose ();
				txtTitle = null;
			}
		}
	}
}
