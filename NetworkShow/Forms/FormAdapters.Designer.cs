namespace N_etworkShow.Forms
{
    partial class FormAdapters
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.adapterInfo = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listBoxAdapters = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // adapterInfo
            // 
            this.adapterInfo.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.adapterInfo.Location = new System.Drawing.Point(12, 114);
            this.adapterInfo.Name = "adapterInfo";
            this.adapterInfo.Size = new System.Drawing.Size(457, 165);
            this.adapterInfo.TabIndex = 12;
            this.adapterInfo.UseCompatibleStateImageBehavior = false;
            this.adapterInfo.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Свойство";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Значение";
            this.columnHeader2.Width = 260;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 285);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Отмена";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(305, 285);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Ок";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBoxAdapters
            // 
            this.listBoxAdapters.FormattingEnabled = true;
            this.listBoxAdapters.Location = new System.Drawing.Point(12, 8);
            this.listBoxAdapters.Name = "listBoxAdapters";
            this.listBoxAdapters.Size = new System.Drawing.Size(457, 95);
            this.listBoxAdapters.TabIndex = 9;
            this.listBoxAdapters.SelectedIndexChanged += new System.EventHandler(this.listBoxAdapters_SelectedIndexChanged);
            // 
            // FormAdapters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 315);
            this.Controls.Add(this.adapterInfo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxAdapters);
            this.Name = "FormAdapters";
            this.Text = "Адаптеры";
            this.Shown += new System.EventHandler(this.FormAdapters_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView adapterInfo;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox listBoxAdapters;
    }
}