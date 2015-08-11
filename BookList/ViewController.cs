using System;

using UIKit;
using System.IO;
using SQLite;
using System.Collections.Generic;

namespace BookList
{
	public partial class ViewController : UIViewController
	{
		public ViewController (IntPtr handle) : base (handle)
		{
		}

		string filePath = Path.Combine (Environment.GetFolderPath
		(Environment.SpecialFolder.Personal), "BookList.db3");
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			var db = new SQLiteConnection (filePath);
			db.CreateTable<Book>();
			PopulateTableView ();

			// Perform any additional setup after loading the view, typically from a nib.
		}

		public override void DidReceiveMemoryWarning ()
		{
			base.DidReceiveMemoryWarning ();
			// Release any cached data, images, etc that aren't in use.
		}

		partial void btnAdd_TouchUpInside (UIButton sender)
		{
			if(!string.IsNullOrEmpty(txtTitle.Text))
			{
				var newBook = new Book { BookTitle = txtTitle.Text, ISBN = txtISBN.Text };
				var db = new SQLiteConnection (filePath);
				db.Insert (newBook);

				new UIAlertView("Success", string.Format("Book ID: {0} with Title: {1} has been successfully added!", newBook.BookId, newBook.BookTitle),null, "OK").Show();
				PopulateTableView();
				tblBooks.ReloadData();
			}else
			{
				new UIAlertView("Failed", "Enter a valid Book Title", null, "OK").Show();
			}
		}
		private void PopulateTableView()
		{
			var db = new SQLiteConnection (filePath);
			var bookList = db.Table<Book> ();

			List<string> bookTitles = new List<string> ();

			foreach (var book in bookList) {
				bookTitles.Add (book.BookTitle);
			}
			tblBooks.Source = new BookListTableSource (bookTitles.ToArray ());
		}
		}
}

