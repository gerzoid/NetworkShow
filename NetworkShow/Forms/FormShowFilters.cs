using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetworkShow.Forms
{
    public partial class FormShowFilters : Form
    {
        DBFShowLib.DBF db;

        const int POS_ID = 0;
        const int POS_NAME = 1;
        const int POS_PORTS = 2;
        const int POS_KOMM = 3;
        const int POS_PROTO = 4;

        public FormShowFilters()
        {
            InitializeComponent();
            db = new DBFShowLib.DBF();
            db.OpenFile("ports.dbf");
        }

        private void FormShowFilters_Shown(object sender, EventArgs e)
        {
            this.Icon = Properties.Resources.network;
            grid.Columns.Add("№", "№");
            grid.Columns.Add("NAME", "Имя");
            grid.Columns.Add("PORTS", "Порты");
            grid.Columns.Add("KOMM", "Описание");
            grid.Columns.Add("PROTO", "Протокол");
            grid.RowCount = db.GetCountRows;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.Columns[POS_ID].Width = 25;
            grid.Columns[POS_ID].ReadOnly = true;
            grid.Columns[POS_KOMM].Width = 190;
            grid.Columns[POS_PROTO].Visible = false;
        }

        private void FormShowFilters_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void grid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            e.Value = db.GetValue(e.RowIndex, e.ColumnIndex);
        }

        private void grid_CellValuePushed(object sender, DataGridViewCellValueEventArgs e)
        {
            db.SetValue(e.RowIndex, e.ColumnIndex, Convert.ToString(e.Value), db.GetColumnType(e.ColumnIndex));
            grid.Refresh();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            db.AddRow();
            grid.Rows.Add();
            grid.Rows[grid.Rows.Count - 1].Cells[POS_ID].Value = grid.Rows.Count;
            grid.Rows[grid.Rows.Count - 1].Cells[POS_PROTO].Value = 3;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            if (grid.SelectedCells.Count <= 0)
                return;
            if (MessageBox.Show("Удалить?", "Внимание", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                db.DeleteRow(grid.SelectedCells[0].RowIndex, false);
                db.Zap();
                grid.RowCount--;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void grid_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void grid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == POS_PORTS)
            {
                string value = Convert.ToString(e.FormattedValue);
            }
        }




        private void grid_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (grid.CurrentCell.ColumnIndex == POS_PORTS)
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress += new KeyPressEventHandler(tb_KeyPress);
            }
            else
            {
                TextBox tb = (TextBox)e.Control;
                tb.KeyPress -= tb_KeyPress;
            }
        }

        void tb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!Char.IsNumber(e.KeyChar) && (e.KeyChar != '-') && (e.KeyChar != ',')))
            {
                if ((e.KeyChar != (char)Keys.Back) || (e.KeyChar != (char)Keys.Delete))
                { e.Handled = true; }
            }

        }
    }
}
