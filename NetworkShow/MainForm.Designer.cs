using NetworkShow.Grid;
namespace NetworkShow
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Информация", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("TCP/UDP", 2, 2);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("ICMP", 2, 2);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("IGMP", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Другие IP протоколы");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("IP", 2, 2, new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("ARP", 2, 2);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button1 = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tree = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gsdfgsfdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инструментыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.протоколыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statPanel = new System.Windows.Forms.GroupBox();
            this.labelLengthPacketsARP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsARP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsIGMP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsIGMP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsICMP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsICMP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsUDP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsTCP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsIP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsUDP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsTCP_in = new System.Windows.Forms.Label();
            this.labelCountPacketsIP_in = new System.Windows.Forms.Label();
            this.labelLengthPacketsARP_out = new System.Windows.Forms.Label();
            this.labelCountPacketsARP_out = new System.Windows.Forms.Label();
            this.labelLengthPacketsIGMP_out = new System.Windows.Forms.Label();
            this.labelCountPacketsIGMP_out = new System.Windows.Forms.Label();
            this.labelLengthPacketsICMP_out = new System.Windows.Forms.Label();
            this.labelCountPacketsICMP_out = new System.Windows.Forms.Label();
            this.labelLengthPacketsUDP_out = new System.Windows.Forms.Label();
            this.labelLengthPacketsTCP_out = new System.Windows.Forms.Label();
            this.labelLengthPacketsIP_out = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel10 = new System.Windows.Forms.LinkLabel();
            this.linkLabel11 = new System.Windows.Forms.LinkLabel();
            this.labelLengthPacketsIGMP = new System.Windows.Forms.Label();
            this.labelCountPacketsIGMP = new System.Windows.Forms.Label();
            this.labelCountPacketsUDP_out = new System.Windows.Forms.Label();
            this.labelCountPacketsTCP_out = new System.Windows.Forms.Label();
            this.labelCountPacketsIP_out = new System.Windows.Forms.Label();
            this.linkLabel9 = new System.Windows.Forms.LinkLabel();
            this.linkLabel8 = new System.Windows.Forms.LinkLabel();
            this.linkLabel7 = new System.Windows.Forms.LinkLabel();
            this.linkLabel6 = new System.Windows.Forms.LinkLabel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.labelIP = new System.Windows.Forms.LinkLabel();
            this.labelLengthPacketsIP = new System.Windows.Forms.Label();
            this.labelCountPacketsIP = new System.Windows.Forms.Label();
            this.labelLengthPacketsICMP = new System.Windows.Forms.Label();
            this.labelCountPacketsICMP = new System.Windows.Forms.Label();
            this.labelLengthPacketsARP = new System.Windows.Forms.Label();
            this.labelCountPacketsARP = new System.Windows.Forms.Label();
            this.labelLengthPacketsUDP = new System.Windows.Forms.Label();
            this.labelCountPacketsUDP = new System.Windows.Forms.Label();
            this.labelLengthPacketsTCP = new System.Windows.Forms.Label();
            this.labelCountPacketsTCP = new System.Windows.Forms.Label();
            this.grid = new NetworkShow.Grid.MyDGV();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 52);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Старт";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(114, 29);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(63, 17);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Сокеты";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(78, 17);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "SharpPcap";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Что использовать:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(388, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(15, 84);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statPanel);
            this.splitContainer1.Panel2.Controls.Add(this.grid);
            this.splitContainer1.Size = new System.Drawing.Size(785, 385);
            this.splitContainer1.SplitterDistance = 195;
            this.splitContainer1.TabIndex = 17;
            // 
            // tree
            // 
            this.tree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tree.FullRowSelect = true;
            this.tree.HideSelection = false;
            this.tree.ImageKey = "1362402811_network-connection.png";
            this.tree.ImageList = this.imageList1;
            this.tree.Location = new System.Drawing.Point(0, 0);
            this.tree.Name = "tree";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "Узел0";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Tag = "info";
            treeNode1.Text = "Информация";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "Узел1";
            treeNode2.SelectedImageIndex = 2;
            treeNode2.Tag = "3";
            treeNode2.Text = "TCP/UDP";
            treeNode3.ImageIndex = 2;
            treeNode3.Name = "Узел3";
            treeNode3.SelectedImageIndex = 2;
            treeNode3.Tag = "5";
            treeNode3.Text = "ICMP";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "Узел4";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Tag = "4";
            treeNode4.Text = "IGMP";
            treeNode5.ImageKey = "1362403169_network-group.png";
            treeNode5.Name = "Узел0";
            treeNode5.SelectedImageKey = "1362403169_network-group.png";
            treeNode5.Tag = "0";
            treeNode5.Text = "Другие IP протоколы";
            treeNode6.ImageIndex = 2;
            treeNode6.Name = "Узел0";
            treeNode6.SelectedImageIndex = 2;
            treeNode6.Tag = "3";
            treeNode6.Text = "IP";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "Узел2";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Tag = "6";
            treeNode7.Text = "ARP";
            this.tree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode7});
            this.tree.SelectedImageIndex = 0;
            this.tree.Size = new System.Drawing.Size(195, 385);
            this.tree.TabIndex = 16;
            this.tree.Tag = "";
            this.tree.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tree_NodeMouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1362402811_network-connection.png");
            this.imageList1.Images.SetKeyName(1, "1362403036_data.png");
            this.imageList1.Images.SetKeyName(2, "1362403169_network-group.png");
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gsdfgsfdToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // gsdfgsfdToolStripMenuItem
            // 
            this.gsdfgsfdToolStripMenuItem.Name = "gsdfgsfdToolStripMenuItem";
            this.gsdfgsfdToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.gsdfgsfdToolStripMenuItem.Text = "gsdfgsfd";
            this.gsdfgsfdToolStripMenuItem.Click += new System.EventHandler(this.gsdfgsfdToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(121, 52);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Стоп";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.инструментыToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(812, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // инструментыToolStripMenuItem
            // 
            this.инструментыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.протоколыToolStripMenuItem});
            this.инструментыToolStripMenuItem.Name = "инструментыToolStripMenuItem";
            this.инструментыToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.инструментыToolStripMenuItem.Text = "Инструменты";
            // 
            // протоколыToolStripMenuItem
            // 
            this.протоколыToolStripMenuItem.Name = "протоколыToolStripMenuItem";
            this.протоколыToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.протоколыToolStripMenuItem.Text = "Протоколы...";
            this.протоколыToolStripMenuItem.Click += new System.EventHandler(this.протоколыToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            // 
            // statPanel
            // 
            this.statPanel.Controls.Add(this.labelLengthPacketsARP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsARP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsIGMP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsIGMP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsICMP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsICMP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsUDP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsTCP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsIP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsUDP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsTCP_in);
            this.statPanel.Controls.Add(this.labelCountPacketsIP_in);
            this.statPanel.Controls.Add(this.labelLengthPacketsARP_out);
            this.statPanel.Controls.Add(this.labelCountPacketsARP_out);
            this.statPanel.Controls.Add(this.labelLengthPacketsIGMP_out);
            this.statPanel.Controls.Add(this.labelCountPacketsIGMP_out);
            this.statPanel.Controls.Add(this.labelLengthPacketsICMP_out);
            this.statPanel.Controls.Add(this.labelCountPacketsICMP_out);
            this.statPanel.Controls.Add(this.labelLengthPacketsUDP_out);
            this.statPanel.Controls.Add(this.labelLengthPacketsTCP_out);
            this.statPanel.Controls.Add(this.labelLengthPacketsIP_out);
            this.statPanel.Controls.Add(this.label3);
            this.statPanel.Controls.Add(this.label2);
            this.statPanel.Controls.Add(this.label4);
            this.statPanel.Controls.Add(this.linkLabel10);
            this.statPanel.Controls.Add(this.linkLabel11);
            this.statPanel.Controls.Add(this.labelLengthPacketsIGMP);
            this.statPanel.Controls.Add(this.labelCountPacketsIGMP);
            this.statPanel.Controls.Add(this.labelCountPacketsUDP_out);
            this.statPanel.Controls.Add(this.labelCountPacketsTCP_out);
            this.statPanel.Controls.Add(this.labelCountPacketsIP_out);
            this.statPanel.Controls.Add(this.linkLabel9);
            this.statPanel.Controls.Add(this.linkLabel8);
            this.statPanel.Controls.Add(this.linkLabel7);
            this.statPanel.Controls.Add(this.linkLabel6);
            this.statPanel.Controls.Add(this.linkLabel5);
            this.statPanel.Controls.Add(this.linkLabel4);
            this.statPanel.Controls.Add(this.linkLabel3);
            this.statPanel.Controls.Add(this.linkLabel2);
            this.statPanel.Controls.Add(this.linkLabel1);
            this.statPanel.Controls.Add(this.labelIP);
            this.statPanel.Controls.Add(this.labelLengthPacketsIP);
            this.statPanel.Controls.Add(this.labelCountPacketsIP);
            this.statPanel.Controls.Add(this.labelLengthPacketsICMP);
            this.statPanel.Controls.Add(this.labelCountPacketsICMP);
            this.statPanel.Controls.Add(this.labelLengthPacketsARP);
            this.statPanel.Controls.Add(this.labelCountPacketsARP);
            this.statPanel.Controls.Add(this.labelLengthPacketsUDP);
            this.statPanel.Controls.Add(this.labelCountPacketsUDP);
            this.statPanel.Controls.Add(this.labelLengthPacketsTCP);
            this.statPanel.Controls.Add(this.labelCountPacketsTCP);
            this.statPanel.Location = new System.Drawing.Point(3, 3);
            this.statPanel.Name = "statPanel";
            this.statPanel.Size = new System.Drawing.Size(507, 275);
            this.statPanel.TabIndex = 16;
            this.statPanel.TabStop = false;
            this.statPanel.Text = "Информация";
            this.statPanel.Visible = false;
            // 
            // labelLengthPacketsARP_in
            // 
            this.labelLengthPacketsARP_in.AutoSize = true;
            this.labelLengthPacketsARP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsARP_in.Location = new System.Drawing.Point(279, 248);
            this.labelLengthPacketsARP_in.Name = "labelLengthPacketsARP_in";
            this.labelLengthPacketsARP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsARP_in.TabIndex = 62;
            this.labelLengthPacketsARP_in.Text = "0";
            // 
            // labelCountPacketsARP_in
            // 
            this.labelCountPacketsARP_in.AutoSize = true;
            this.labelCountPacketsARP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsARP_in.Location = new System.Drawing.Point(279, 230);
            this.labelCountPacketsARP_in.Name = "labelCountPacketsARP_in";
            this.labelCountPacketsARP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsARP_in.TabIndex = 61;
            this.labelCountPacketsARP_in.Text = "0";
            // 
            // labelLengthPacketsIGMP_in
            // 
            this.labelLengthPacketsIGMP_in.AutoSize = true;
            this.labelLengthPacketsIGMP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIGMP_in.Location = new System.Drawing.Point(305, 212);
            this.labelLengthPacketsIGMP_in.Name = "labelLengthPacketsIGMP_in";
            this.labelLengthPacketsIGMP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIGMP_in.TabIndex = 60;
            this.labelLengthPacketsIGMP_in.Text = "0";
            // 
            // labelCountPacketsIGMP_in
            // 
            this.labelCountPacketsIGMP_in.AutoSize = true;
            this.labelCountPacketsIGMP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIGMP_in.Location = new System.Drawing.Point(305, 194);
            this.labelCountPacketsIGMP_in.Name = "labelCountPacketsIGMP_in";
            this.labelCountPacketsIGMP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIGMP_in.TabIndex = 59;
            this.labelCountPacketsIGMP_in.Text = "0";
            // 
            // labelLengthPacketsICMP_in
            // 
            this.labelLengthPacketsICMP_in.AutoSize = true;
            this.labelLengthPacketsICMP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsICMP_in.Location = new System.Drawing.Point(305, 175);
            this.labelLengthPacketsICMP_in.Name = "labelLengthPacketsICMP_in";
            this.labelLengthPacketsICMP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsICMP_in.TabIndex = 58;
            this.labelLengthPacketsICMP_in.Text = "0";
            // 
            // labelCountPacketsICMP_in
            // 
            this.labelCountPacketsICMP_in.AutoSize = true;
            this.labelCountPacketsICMP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsICMP_in.Location = new System.Drawing.Point(305, 155);
            this.labelCountPacketsICMP_in.Name = "labelCountPacketsICMP_in";
            this.labelCountPacketsICMP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsICMP_in.TabIndex = 57;
            this.labelCountPacketsICMP_in.Text = "0";
            // 
            // labelLengthPacketsUDP_in
            // 
            this.labelLengthPacketsUDP_in.AutoSize = true;
            this.labelLengthPacketsUDP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsUDP_in.Location = new System.Drawing.Point(305, 136);
            this.labelLengthPacketsUDP_in.Name = "labelLengthPacketsUDP_in";
            this.labelLengthPacketsUDP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsUDP_in.TabIndex = 56;
            this.labelLengthPacketsUDP_in.Text = "0";
            // 
            // labelLengthPacketsTCP_in
            // 
            this.labelLengthPacketsTCP_in.AutoSize = true;
            this.labelLengthPacketsTCP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsTCP_in.Location = new System.Drawing.Point(305, 98);
            this.labelLengthPacketsTCP_in.Name = "labelLengthPacketsTCP_in";
            this.labelLengthPacketsTCP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsTCP_in.TabIndex = 55;
            this.labelLengthPacketsTCP_in.Text = "0";
            // 
            // labelLengthPacketsIP_in
            // 
            this.labelLengthPacketsIP_in.AutoSize = true;
            this.labelLengthPacketsIP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIP_in.Location = new System.Drawing.Point(279, 60);
            this.labelLengthPacketsIP_in.Name = "labelLengthPacketsIP_in";
            this.labelLengthPacketsIP_in.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIP_in.TabIndex = 54;
            this.labelLengthPacketsIP_in.Text = "0";
            // 
            // labelCountPacketsUDP_in
            // 
            this.labelCountPacketsUDP_in.AutoSize = true;
            this.labelCountPacketsUDP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsUDP_in.Location = new System.Drawing.Point(305, 117);
            this.labelCountPacketsUDP_in.Name = "labelCountPacketsUDP_in";
            this.labelCountPacketsUDP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsUDP_in.TabIndex = 53;
            this.labelCountPacketsUDP_in.Text = "0";
            // 
            // labelCountPacketsTCP_in
            // 
            this.labelCountPacketsTCP_in.AutoSize = true;
            this.labelCountPacketsTCP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsTCP_in.Location = new System.Drawing.Point(305, 79);
            this.labelCountPacketsTCP_in.Name = "labelCountPacketsTCP_in";
            this.labelCountPacketsTCP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsTCP_in.TabIndex = 52;
            this.labelCountPacketsTCP_in.Text = "0";
            // 
            // labelCountPacketsIP_in
            // 
            this.labelCountPacketsIP_in.AutoSize = true;
            this.labelCountPacketsIP_in.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIP_in.Location = new System.Drawing.Point(279, 40);
            this.labelCountPacketsIP_in.Name = "labelCountPacketsIP_in";
            this.labelCountPacketsIP_in.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIP_in.TabIndex = 51;
            this.labelCountPacketsIP_in.Text = "0";
            // 
            // labelLengthPacketsARP_out
            // 
            this.labelLengthPacketsARP_out.AutoSize = true;
            this.labelLengthPacketsARP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsARP_out.Location = new System.Drawing.Point(400, 248);
            this.labelLengthPacketsARP_out.Name = "labelLengthPacketsARP_out";
            this.labelLengthPacketsARP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsARP_out.TabIndex = 50;
            this.labelLengthPacketsARP_out.Text = "0";
            // 
            // labelCountPacketsARP_out
            // 
            this.labelCountPacketsARP_out.AutoSize = true;
            this.labelCountPacketsARP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsARP_out.Location = new System.Drawing.Point(400, 230);
            this.labelCountPacketsARP_out.Name = "labelCountPacketsARP_out";
            this.labelCountPacketsARP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsARP_out.TabIndex = 49;
            this.labelCountPacketsARP_out.Text = "0";
            // 
            // labelLengthPacketsIGMP_out
            // 
            this.labelLengthPacketsIGMP_out.AutoSize = true;
            this.labelLengthPacketsIGMP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIGMP_out.Location = new System.Drawing.Point(426, 212);
            this.labelLengthPacketsIGMP_out.Name = "labelLengthPacketsIGMP_out";
            this.labelLengthPacketsIGMP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIGMP_out.TabIndex = 48;
            this.labelLengthPacketsIGMP_out.Text = "0";
            // 
            // labelCountPacketsIGMP_out
            // 
            this.labelCountPacketsIGMP_out.AutoSize = true;
            this.labelCountPacketsIGMP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIGMP_out.Location = new System.Drawing.Point(426, 194);
            this.labelCountPacketsIGMP_out.Name = "labelCountPacketsIGMP_out";
            this.labelCountPacketsIGMP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIGMP_out.TabIndex = 47;
            this.labelCountPacketsIGMP_out.Text = "0";
            // 
            // labelLengthPacketsICMP_out
            // 
            this.labelLengthPacketsICMP_out.AutoSize = true;
            this.labelLengthPacketsICMP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsICMP_out.Location = new System.Drawing.Point(426, 175);
            this.labelLengthPacketsICMP_out.Name = "labelLengthPacketsICMP_out";
            this.labelLengthPacketsICMP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsICMP_out.TabIndex = 46;
            this.labelLengthPacketsICMP_out.Text = "0";
            // 
            // labelCountPacketsICMP_out
            // 
            this.labelCountPacketsICMP_out.AutoSize = true;
            this.labelCountPacketsICMP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsICMP_out.Location = new System.Drawing.Point(426, 155);
            this.labelCountPacketsICMP_out.Name = "labelCountPacketsICMP_out";
            this.labelCountPacketsICMP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsICMP_out.TabIndex = 45;
            this.labelCountPacketsICMP_out.Text = "0";
            // 
            // labelLengthPacketsUDP_out
            // 
            this.labelLengthPacketsUDP_out.AutoSize = true;
            this.labelLengthPacketsUDP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsUDP_out.Location = new System.Drawing.Point(426, 136);
            this.labelLengthPacketsUDP_out.Name = "labelLengthPacketsUDP_out";
            this.labelLengthPacketsUDP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsUDP_out.TabIndex = 44;
            this.labelLengthPacketsUDP_out.Text = "0";
            // 
            // labelLengthPacketsTCP_out
            // 
            this.labelLengthPacketsTCP_out.AutoSize = true;
            this.labelLengthPacketsTCP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsTCP_out.Location = new System.Drawing.Point(426, 98);
            this.labelLengthPacketsTCP_out.Name = "labelLengthPacketsTCP_out";
            this.labelLengthPacketsTCP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsTCP_out.TabIndex = 43;
            this.labelLengthPacketsTCP_out.Text = "0";
            // 
            // labelLengthPacketsIP_out
            // 
            this.labelLengthPacketsIP_out.AutoSize = true;
            this.labelLengthPacketsIP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIP_out.Location = new System.Drawing.Point(400, 60);
            this.labelLengthPacketsIP_out.Name = "labelLengthPacketsIP_out";
            this.labelLengthPacketsIP_out.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIP_out.TabIndex = 42;
            this.labelLengthPacketsIP_out.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(369, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 41;
            this.label3.Text = "Исходящие";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(254, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Входящие";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(159, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Всего";
            // 
            // linkLabel10
            // 
            this.linkLabel10.AutoSize = true;
            this.linkLabel10.Location = new System.Drawing.Point(36, 212);
            this.linkLabel10.Name = "linkLabel10";
            this.linkLabel10.Size = new System.Drawing.Size(123, 13);
            this.linkLabel10.TabIndex = 38;
            this.linkLabel10.TabStop = true;
            this.linkLabel10.Text = "Размер IGMP пакетов:";
            // 
            // linkLabel11
            // 
            this.linkLabel11.AutoSize = true;
            this.linkLabel11.Location = new System.Drawing.Point(36, 194);
            this.linkLabel11.Name = "linkLabel11";
            this.linkLabel11.Size = new System.Drawing.Size(81, 13);
            this.linkLabel11.TabIndex = 37;
            this.linkLabel11.TabStop = true;
            this.linkLabel11.Text = "IGMP пакетов:";
            // 
            // labelLengthPacketsIGMP
            // 
            this.labelLengthPacketsIGMP.AutoSize = true;
            this.labelLengthPacketsIGMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIGMP.Location = new System.Drawing.Point(178, 212);
            this.labelLengthPacketsIGMP.Name = "labelLengthPacketsIGMP";
            this.labelLengthPacketsIGMP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIGMP.TabIndex = 36;
            this.labelLengthPacketsIGMP.Text = "0";
            // 
            // labelCountPacketsIGMP
            // 
            this.labelCountPacketsIGMP.AutoSize = true;
            this.labelCountPacketsIGMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIGMP.Location = new System.Drawing.Point(178, 194);
            this.labelCountPacketsIGMP.Name = "labelCountPacketsIGMP";
            this.labelCountPacketsIGMP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIGMP.TabIndex = 35;
            this.labelCountPacketsIGMP.Text = "0";
            // 
            // labelCountPacketsUDP_out
            // 
            this.labelCountPacketsUDP_out.AutoSize = true;
            this.labelCountPacketsUDP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsUDP_out.Location = new System.Drawing.Point(426, 117);
            this.labelCountPacketsUDP_out.Name = "labelCountPacketsUDP_out";
            this.labelCountPacketsUDP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsUDP_out.TabIndex = 34;
            this.labelCountPacketsUDP_out.Text = "0";
            // 
            // labelCountPacketsTCP_out
            // 
            this.labelCountPacketsTCP_out.AutoSize = true;
            this.labelCountPacketsTCP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsTCP_out.Location = new System.Drawing.Point(426, 79);
            this.labelCountPacketsTCP_out.Name = "labelCountPacketsTCP_out";
            this.labelCountPacketsTCP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsTCP_out.TabIndex = 33;
            this.labelCountPacketsTCP_out.Text = "0";
            // 
            // labelCountPacketsIP_out
            // 
            this.labelCountPacketsIP_out.AutoSize = true;
            this.labelCountPacketsIP_out.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIP_out.Location = new System.Drawing.Point(400, 40);
            this.labelCountPacketsIP_out.Name = "labelCountPacketsIP_out";
            this.labelCountPacketsIP_out.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIP_out.TabIndex = 32;
            this.labelCountPacketsIP_out.Text = "0";
            // 
            // linkLabel9
            // 
            this.linkLabel9.AutoSize = true;
            this.linkLabel9.Location = new System.Drawing.Point(12, 248);
            this.linkLabel9.Name = "linkLabel9";
            this.linkLabel9.Size = new System.Drawing.Size(118, 13);
            this.linkLabel9.TabIndex = 30;
            this.linkLabel9.TabStop = true;
            this.linkLabel9.Text = "Размер ARP пакетов:";
            // 
            // linkLabel8
            // 
            this.linkLabel8.AutoSize = true;
            this.linkLabel8.Location = new System.Drawing.Point(36, 175);
            this.linkLabel8.Name = "linkLabel8";
            this.linkLabel8.Size = new System.Drawing.Size(122, 13);
            this.linkLabel8.TabIndex = 29;
            this.linkLabel8.TabStop = true;
            this.linkLabel8.Text = "Размер ICMP пакетов:";
            // 
            // linkLabel7
            // 
            this.linkLabel7.AutoSize = true;
            this.linkLabel7.Location = new System.Drawing.Point(36, 136);
            this.linkLabel7.Name = "linkLabel7";
            this.linkLabel7.Size = new System.Drawing.Size(119, 13);
            this.linkLabel7.TabIndex = 28;
            this.linkLabel7.TabStop = true;
            this.linkLabel7.Text = "Размер UDP пакетов:";
            // 
            // linkLabel6
            // 
            this.linkLabel6.AutoSize = true;
            this.linkLabel6.Location = new System.Drawing.Point(36, 98);
            this.linkLabel6.Name = "linkLabel6";
            this.linkLabel6.Size = new System.Drawing.Size(117, 13);
            this.linkLabel6.TabIndex = 27;
            this.linkLabel6.TabStop = true;
            this.linkLabel6.Text = "Размер TCP пакетов:";
            // 
            // linkLabel5
            // 
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Location = new System.Drawing.Point(12, 60);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(106, 13);
            this.linkLabel5.TabIndex = 26;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "Размер IP пакетов:";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(12, 230);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(76, 13);
            this.linkLabel4.TabIndex = 25;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "ARP пакетов:";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(36, 155);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(80, 13);
            this.linkLabel3.TabIndex = 24;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "ICMP пакетов:";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(36, 117);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(77, 13);
            this.linkLabel2.TabIndex = 23;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "UDP пакетов:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(36, 79);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(75, 13);
            this.linkLabel1.TabIndex = 22;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "TCP пакетов:";
            // 
            // labelIP
            // 
            this.labelIP.AutoSize = true;
            this.labelIP.Location = new System.Drawing.Point(12, 40);
            this.labelIP.Name = "labelIP";
            this.labelIP.Size = new System.Drawing.Size(64, 13);
            this.labelIP.TabIndex = 21;
            this.labelIP.TabStop = true;
            this.labelIP.Text = "IP пакетов:";
            // 
            // labelLengthPacketsIP
            // 
            this.labelLengthPacketsIP.AutoSize = true;
            this.labelLengthPacketsIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsIP.Location = new System.Drawing.Point(154, 60);
            this.labelLengthPacketsIP.Name = "labelLengthPacketsIP";
            this.labelLengthPacketsIP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsIP.TabIndex = 20;
            this.labelLengthPacketsIP.Text = "0";
            // 
            // labelCountPacketsIP
            // 
            this.labelCountPacketsIP.AutoSize = true;
            this.labelCountPacketsIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsIP.Location = new System.Drawing.Point(154, 40);
            this.labelCountPacketsIP.Name = "labelCountPacketsIP";
            this.labelCountPacketsIP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsIP.TabIndex = 18;
            this.labelCountPacketsIP.Text = "0";
            // 
            // labelLengthPacketsICMP
            // 
            this.labelLengthPacketsICMP.AutoSize = true;
            this.labelLengthPacketsICMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsICMP.Location = new System.Drawing.Point(178, 175);
            this.labelLengthPacketsICMP.Name = "labelLengthPacketsICMP";
            this.labelLengthPacketsICMP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsICMP.TabIndex = 16;
            this.labelLengthPacketsICMP.Text = "0";
            // 
            // labelCountPacketsICMP
            // 
            this.labelCountPacketsICMP.AutoSize = true;
            this.labelCountPacketsICMP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsICMP.Location = new System.Drawing.Point(178, 155);
            this.labelCountPacketsICMP.Name = "labelCountPacketsICMP";
            this.labelCountPacketsICMP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsICMP.TabIndex = 14;
            this.labelCountPacketsICMP.Text = "0";
            // 
            // labelLengthPacketsARP
            // 
            this.labelLengthPacketsARP.AutoSize = true;
            this.labelLengthPacketsARP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsARP.Location = new System.Drawing.Point(154, 248);
            this.labelLengthPacketsARP.Name = "labelLengthPacketsARP";
            this.labelLengthPacketsARP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsARP.TabIndex = 12;
            this.labelLengthPacketsARP.Text = "0";
            // 
            // labelCountPacketsARP
            // 
            this.labelCountPacketsARP.AutoSize = true;
            this.labelCountPacketsARP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsARP.Location = new System.Drawing.Point(154, 230);
            this.labelCountPacketsARP.Name = "labelCountPacketsARP";
            this.labelCountPacketsARP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsARP.TabIndex = 10;
            this.labelCountPacketsARP.Text = "0";
            // 
            // labelLengthPacketsUDP
            // 
            this.labelLengthPacketsUDP.AutoSize = true;
            this.labelLengthPacketsUDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsUDP.Location = new System.Drawing.Point(178, 136);
            this.labelLengthPacketsUDP.Name = "labelLengthPacketsUDP";
            this.labelLengthPacketsUDP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsUDP.TabIndex = 8;
            this.labelLengthPacketsUDP.Text = "0";
            // 
            // labelCountPacketsUDP
            // 
            this.labelCountPacketsUDP.AutoSize = true;
            this.labelCountPacketsUDP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsUDP.Location = new System.Drawing.Point(178, 117);
            this.labelCountPacketsUDP.Name = "labelCountPacketsUDP";
            this.labelCountPacketsUDP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsUDP.TabIndex = 6;
            this.labelCountPacketsUDP.Text = "0";
            // 
            // labelLengthPacketsTCP
            // 
            this.labelLengthPacketsTCP.AutoSize = true;
            this.labelLengthPacketsTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLengthPacketsTCP.Location = new System.Drawing.Point(178, 98);
            this.labelLengthPacketsTCP.Name = "labelLengthPacketsTCP";
            this.labelLengthPacketsTCP.Size = new System.Drawing.Size(14, 13);
            this.labelLengthPacketsTCP.TabIndex = 4;
            this.labelLengthPacketsTCP.Text = "0";
            // 
            // labelCountPacketsTCP
            // 
            this.labelCountPacketsTCP.AutoSize = true;
            this.labelCountPacketsTCP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCountPacketsTCP.Location = new System.Drawing.Point(178, 79);
            this.labelCountPacketsTCP.Name = "labelCountPacketsTCP";
            this.labelCountPacketsTCP.Size = new System.Drawing.Size(14, 13);
            this.labelCountPacketsTCP.TabIndex = 1;
            this.labelCountPacketsTCP.Text = "0";
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToOrderColumns = true;
            this.grid.AllowUserToResizeRows = false;
            this.grid.ContextMenuStrip = this.contextMenuStrip1;
            this.grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grid.Location = new System.Drawing.Point(0, 0);
            this.grid.Name = "grid";
            this.grid.RowHeadersVisible = false;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.grid.Size = new System.Drawing.Size(586, 385);
            this.grid.TabIndex = 0;
            this.grid.VirtualMode = true;
            this.grid.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.grid_CellValueNeeded);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 481);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button1);
            this.Name = "MainForm";
            this.Text = "NetworkShow v0.03";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statPanel.ResumeLayout(false);
            this.statPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private MyDGV grid;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tree;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gsdfgsfdToolStripMenuItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инструментыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem протоколыToolStripMenuItem;
        private System.Windows.Forms.GroupBox statPanel;
        private System.Windows.Forms.Label labelLengthPacketsARP_in;
        private System.Windows.Forms.Label labelCountPacketsARP_in;
        private System.Windows.Forms.Label labelLengthPacketsIGMP_in;
        private System.Windows.Forms.Label labelCountPacketsIGMP_in;
        private System.Windows.Forms.Label labelLengthPacketsICMP_in;
        private System.Windows.Forms.Label labelCountPacketsICMP_in;
        private System.Windows.Forms.Label labelLengthPacketsUDP_in;
        private System.Windows.Forms.Label labelLengthPacketsTCP_in;
        private System.Windows.Forms.Label labelLengthPacketsIP_in;
        private System.Windows.Forms.Label labelCountPacketsUDP_in;
        private System.Windows.Forms.Label labelCountPacketsTCP_in;
        private System.Windows.Forms.Label labelCountPacketsIP_in;
        private System.Windows.Forms.Label labelLengthPacketsARP_out;
        private System.Windows.Forms.Label labelCountPacketsARP_out;
        private System.Windows.Forms.Label labelLengthPacketsIGMP_out;
        private System.Windows.Forms.Label labelCountPacketsIGMP_out;
        private System.Windows.Forms.Label labelLengthPacketsICMP_out;
        private System.Windows.Forms.Label labelCountPacketsICMP_out;
        private System.Windows.Forms.Label labelLengthPacketsUDP_out;
        private System.Windows.Forms.Label labelLengthPacketsTCP_out;
        private System.Windows.Forms.Label labelLengthPacketsIP_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkLabel10;
        private System.Windows.Forms.LinkLabel linkLabel11;
        private System.Windows.Forms.Label labelLengthPacketsIGMP;
        private System.Windows.Forms.Label labelCountPacketsIGMP;
        private System.Windows.Forms.Label labelCountPacketsUDP_out;
        private System.Windows.Forms.Label labelCountPacketsTCP_out;
        private System.Windows.Forms.Label labelCountPacketsIP_out;
        private System.Windows.Forms.LinkLabel linkLabel9;
        private System.Windows.Forms.LinkLabel linkLabel8;
        private System.Windows.Forms.LinkLabel linkLabel7;
        private System.Windows.Forms.LinkLabel linkLabel6;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel labelIP;
        private System.Windows.Forms.Label labelLengthPacketsIP;
        private System.Windows.Forms.Label labelCountPacketsIP;
        private System.Windows.Forms.Label labelLengthPacketsICMP;
        private System.Windows.Forms.Label labelCountPacketsICMP;
        private System.Windows.Forms.Label labelLengthPacketsARP;
        private System.Windows.Forms.Label labelCountPacketsARP;
        private System.Windows.Forms.Label labelLengthPacketsUDP;
        private System.Windows.Forms.Label labelCountPacketsUDP;
        private System.Windows.Forms.Label labelLengthPacketsTCP;
        private System.Windows.Forms.Label labelCountPacketsTCP;
    }
}

