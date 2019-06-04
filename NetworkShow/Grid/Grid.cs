using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace NetworkShow.Grid
{
    class MyDGV : DataGridView
    {

        /*[DllImport("gdi32.dll")]
        static extern bool TextOut(IntPtr hdc, int nXStart, int nYStart, string lpString, int cbString);

        [DllImport("GDI32.dll")]        
        public static extern IntPtr SelectObject(IntPtr hdc, IntPtr hgdiobj);

        [DllImport("GDI32.dll")]
        public static extern bool DeleteObject(IntPtr objectHandle);
        */
        public MyDGV()
        {

            base.DoubleBuffered = true;
            //perform any necessary customization initialization here
        } //end default constructor

        //protected override void OnRowPrePaint(DataGridViewRowPrePaintEventArgs e)
        //{
        //  if (((DataGridView)this)["__DEL__", e.RowIndex].Value == null)
        //    return;
        //if ((bool)((DataGridView)this)["__DEL__", e.RowIndex].Value != false)
        //{
        //  ((DataGridView)this).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Gray;
        //((DataGridView)sender).Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
        //}
        //else
        //  ((DataGridView)this).Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Black;
        //OnRowPrePaint(e);*/
        //}

        /*protected override void OnCellPainting(DataGridViewCellPaintingEventArgs e)
        {
            SizeF size = e.Graphics.MeasureString(Convert.ToString(e.Value), this.Font);
            IntPtr HDC = e.Graphics.GetHdc();
            IntPtr last_font = SelectObject(HDC, Font.ToHfont());
            TextOut(HDC, e.CellBounds.Location.X + 15, Convert.ToInt32(e.CellBounds.Location.Y + ((e.CellBounds.Height - size.Height) / 2)), Convert.ToString(e.Value), Convert.ToString(e.Value).Length);            
            DeleteObject(SelectObject(HDC, last_font));
            e.Graphics.ReleaseHdc(HDC);                        
            base.OnCellPainting(e);
        }*/

        protected override void OnRowPostPaint(DataGridViewRowPostPaintEventArgs e)
        { //this method overrides the DataGridView's RowPostPaint event 
            //in order to automatically draw numbers on the row header cells
            //and to automatically adjust the width of the column containing
            //the row header cells so that it can accommodate the new row
            //numbers,

            //store a string representation of the row number in 'strRowNumber'
            /*  string strRowNumber = (e.RowIndex + 1).ToString();

              //prepend leading zeros to the string if necessary to improve
              //appearance. For example, if there are ten rows in the grid,
              //row seven will be numbered as "07" instead of "7". Similarly, if 
              //there are 100 rows in the grid, row seven will be numbered as "007".
              while (strRowNumber.Length < this.RowCount.ToString().Length) strRowNumber = "0" + strRowNumber;

              //determine the display size of the row number string using
              //the DataGridView's current font.
              SizeF size = e.Graphics.MeasureString(strRowNumber, this.Font);

              //adjust the width of the column that contains the row header cells 
              //if necessary
              if (this.RowHeadersWidth < (int)(size.Width + 20)) this.RowHeadersWidth = (int)(size.Width + 20);

              //this brush will be used to draw the row number string on the
              //row header cell using the system's current ControlText color
              Brush b = SystemBrushes.ControlText;

              //draw the row number string on the current row header cell using
              //the brush defined above and the DataGridView's default font

              /*IntPtr HDC = e.Graphics.GetHdc();
              IntPtr last_font = SelectObject(HDC, Font.ToHfont());
              TextOut(HDC, e.RowBounds.Location.X + 15, Convert.ToInt32(e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2)), strRowNumber, strRowNumber.Length);            
              DeleteObject(SelectObject(HDC, last_font));
              e.Graphics.ReleaseHdc(HDC);
              */

            /*    e.Graphics.DrawString(strRowNumber, this.Font, b, e.RowBounds.Location.X + 15, e.RowBounds.Location.Y + ((e.RowBounds.Height - size.Height) / 2));
                //call the base object's OnRowPostPaint method
                base.OnRowPostPaint(e);*/
        } //end OnRowPostPaint method
    } //end class}
}
