using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HaloMCCPCSaveTransferTool
{
    public static class ExtentionMethods
    {
        /// <summary>
        /// Removes a column from a table layout pannel
        /// </summary>
        /// <param name="LayoutPanel">the table to remove the column from</param>
        /// <param name="columnIndex">the index of the column to remove</param>
        public static void RemoveColumnAt(this TableLayoutPanel LayoutPanel, int columnIndex)
        {
            if (columnIndex >= LayoutPanel.ColumnCount)
            {
                return;
            }
            //remove controls 
            for (int i = 0; i < LayoutPanel.RowCount; i++)
            {
                LayoutPanel.Controls.Remove(LayoutPanel.GetControlFromPosition(columnIndex, i));
            }
            //shift other controls
            for (int i = columnIndex + 1; i < LayoutPanel.ColumnCount; i++)
            {
                for (int j = 0; j < LayoutPanel.RowCount; j++)
                {
                    Control control = LayoutPanel.GetControlFromPosition(j, i);
                    if (control != null)
                    {
                        LayoutPanel.SetColumn(control, i - 1);
                    }
                }
            }
            //remove column
            LayoutPanel.ColumnStyles.RemoveAt(LayoutPanel.ColumnCount - 1);
            LayoutPanel.ColumnCount--;
        }
    }
}
