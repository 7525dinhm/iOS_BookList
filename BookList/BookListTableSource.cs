using System;
using Foundation;
using UIKit;

namespace BookList
{
	public class BookListTableSource : UITableViewSource
	{
		protected string [] tableItems;
		protected string cellIdentifier = "TableCell";

		public BookListTableSource (string[] items)
		{
			tableItems = items;
		}

		public override nint RowsInSection (UITableView tableview, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
			if (cell == null)
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			cell.TextLabel.Text = tableItems[indexPath.Row];
			return cell;
		}

		public override void RowSelected (UITableView tableView, NSIndexPath indexPath)
		{
			new UIAlertView ("Row Selected", tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow (indexPath, true);
		}
	}
}

