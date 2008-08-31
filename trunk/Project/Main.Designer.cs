using System.Windows.Forms;
namespace WFA_MUA
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.trvAvailableChars = new System.Windows.Forms.TreeView();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.lstSelected = new System.Windows.Forms.ListView();
            this.Position = new System.Windows.Forms.ColumnHeader();
            this.Char = new System.Windows.Forms.ColumnHeader();
            this.Path = new System.Windows.Forms.ColumnHeader();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.lblAvailableChars = new System.Windows.Forms.Label();
            this.lblCurrentPos = new System.Windows.Forms.Label();
            this.lblSelectedChar = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.objMenu = new WFA_MUA.Menu();
            this.btnRemoveAll = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // trvAvailableChars
            // 
            this.trvAvailableChars.Location = new System.Drawing.Point(23, 48);
            this.trvAvailableChars.Name = "trvAvailableChars";
            this.trvAvailableChars.Size = new System.Drawing.Size(261, 448);
            this.trvAvailableChars.TabIndex = 1;
            this.trvAvailableChars.DoubleClick += new System.EventHandler(this.trvAvailableChars_DoubleClick);
            this.trvAvailableChars.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAvailableChars_AfterSelect);
            this.trvAvailableChars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.trvAvailableChars_KeyDown);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(290, 2);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(34, 20);
            this.txtPosition.TabIndex = 3;
            // 
            // lstSelected
            // 
            this.lstSelected.AllowColumnReorder = true;
            this.lstSelected.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Position,
            this.Char,
            this.Path});
            this.lstSelected.GridLines = true;
            this.lstSelected.HoverSelection = true;
            this.lstSelected.Location = new System.Drawing.Point(290, 48);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(188, 448);
            this.lstSelected.TabIndex = 4;
            this.lstSelected.UseCompatibleStateImageBehavior = false;
            this.lstSelected.View = System.Windows.Forms.View.Details;
            this.lstSelected.SelectedIndexChanged += new System.EventHandler(this.lstSelected_SelectedIndexChanged);
            this.lstSelected.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstSelected_ColumnClick);
            this.lstSelected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstSelected_KeyDown);
            // 
            // Position
            // 
            this.Position.Text = "Pos";
            this.Position.Width = 30;
            // 
            // Char
            // 
            this.Char.Text = "Char";
            this.Char.Width = 121;
            // 
            // Path
            // 
            this.Path.Text = "Path";
            this.Path.Width = 0;
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(390, 502);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 25);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(521, 190);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(413, 47);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run Marvel Ultimate Alliance";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDebug.Location = new System.Drawing.Point(23, 533);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(911, 57);
            this.txtDebug.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(109, 502);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(64, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // lblAvailableChars
            // 
            this.lblAvailableChars.AutoSize = true;
            this.lblAvailableChars.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvailableChars.Location = new System.Drawing.Point(88, 32);
            this.lblAvailableChars.Name = "lblAvailableChars";
            this.lblAvailableChars.Size = new System.Drawing.Size(95, 13);
            this.lblAvailableChars.TabIndex = 9;
            this.lblAvailableChars.Text = "Available Chars";
            // 
            // lblCurrentPos
            // 
            this.lblCurrentPos.AutoSize = true;
            this.lblCurrentPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPos.Location = new System.Drawing.Point(179, 5);
            this.lblCurrentPos.Name = "lblCurrentPos";
            this.lblCurrentPos.Size = new System.Drawing.Size(105, 13);
            this.lblCurrentPos.TabIndex = 10;
            this.lblCurrentPos.Text = "Current Position: ";
            // 
            // lblSelectedChar
            // 
            this.lblSelectedChar.AutoSize = true;
            this.lblSelectedChar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedChar.Location = new System.Drawing.Point(372, 32);
            this.lblSelectedChar.Name = "lblSelectedChar";
            this.lblSelectedChar.Size = new System.Drawing.Size(93, 13);
            this.lblSelectedChar.TabIndex = 11;
            this.lblSelectedChar.Text = "Selected Chars";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WFA_MUA.Properties.Resources.Tux;
            this.pictureBox1.Location = new System.Drawing.Point(809, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(136, 159);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 65);
            this.label1.TabIndex = 13;
            this.label1.Text = "Marvel Ultimate Aliance \r\nOpen Hero Select\r\n\r\nMore Information in:\r\nhttp://MUAOpe" +
                "nHeroSelect.googlepages.com\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(718, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Open... because help the community don\'t hurt";
            // 
            // objMenu
            // 
            this.objMenu.Location = new System.Drawing.Point(544, 243);
            this.objMenu.Name = "objMenu";
            this.objMenu.Size = new System.Drawing.Size(353, 215);
            this.objMenu.TabIndex = 2;
            this.objMenu.OnDoubleClickChar += new WFA_MUA.Menu.delegateDoubleClickChar(this.objMenu_OnDoubleClickChar);
            // 
            // btnRemoveAll
            // 
            this.btnRemoveAll.Location = new System.Drawing.Point(294, 501);
            this.btnRemoveAll.Name = "btnRemoveAll";
            this.btnRemoveAll.Size = new System.Drawing.Size(81, 25);
            this.btnRemoveAll.TabIndex = 15;
            this.btnRemoveAll.Text = "Remove All";
            this.btnRemoveAll.UseVisualStyleBackColor = true;
            this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
            // 
            // btnClean
            // 
            this.btnClean.Location = new System.Drawing.Point(775, 499);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(158, 25);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Clean Debug Window";
            this.btnClean.UseVisualStyleBackColor = true;
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 597);
            this.Controls.Add(this.btnClean);
            this.Controls.Add(this.btnRemoveAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSelectedChar);
            this.Controls.Add(this.lblCurrentPos);
            this.Controls.Add(this.lblAvailableChars);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.objMenu);
            this.Controls.Add(this.trvAvailableChars);
            this.Name = "Main";
            this.Text = "MUA Open Hero Select";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void trvAvailableChars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
                trvAvailableChars_DoubleClick(this, e);
        }

        private void lstSelected_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete))
            {
                btnRemove_Click(this, e);
            }
        }

        private void lstSelected_ColumnClick(object sender, System.Windows.Forms.ColumnClickEventArgs e)
        {
            if(lstSelected.ListViewItemSorter==null)
                lstSelected.ListViewItemSorter = lvwColumnSorter;

            if (e.Column == lvwColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvwColumnSorter.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvwColumnSorter.SortColumn = e.Column;
                lvwColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lstSelected.Sort();

        }

        #endregion

        private System.Windows.Forms.TreeView trvAvailableChars;
        private Menu objMenu;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.ListView lstSelected;
        private System.Windows.Forms.ColumnHeader Position;
        private System.Windows.Forms.ColumnHeader Char;
        private System.Windows.Forms.ColumnHeader Path;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtDebug;
        private ListViewColumnSorter lvwColumnSorter = new ListViewColumnSorter();
        private Button btnReload;
        private Label lblAvailableChars;
        private Label lblCurrentPos;
        private Label lblSelectedChar;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button btnRemoveAll;
        private Button btnClean;
    }
}

