using System;
using System.Collections;
using System.Windows.Forms;

namespace BestMerge.Core
{
    public class ListViewItemComparer : IComparer
    {
        private readonly int col;
        private readonly SortOrder order;

        public ListViewItemComparer()
        {
            col = 0;
            order = SortOrder.Ascending;
        }

        public ListViewItemComparer(int column, SortOrder order)
        {
            col = column;
            this.order = order;
        }

        public int Compare(object x, object y)
        {
            var num = col != 0
                ? (col != 2
                    ? string.Compare(((ListViewItem) x).SubItems[col].Text, ((ListViewItem) y).SubItems[col].Text)
                    : DateTime.Compare(DateTime.Parse(((ListViewItem) x).SubItems[col].Text),
                        DateTime.Parse(((ListViewItem) y).SubItems[col].Text)))
                : int.Parse(((ListViewItem) x).SubItems[col].Text)
                    .CompareTo(int.Parse(((ListViewItem) y).SubItems[col].Text));
            if (order == SortOrder.Descending)
                num *= -1;
            return num;
        }
    }
}