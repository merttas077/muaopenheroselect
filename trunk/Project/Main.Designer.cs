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
            this.objMenu = new WFA_MUA.Menu();
            this.btnRun = new System.Windows.Forms.Button();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.btnReload = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // trvAvailableChars
            // 
            this.trvAvailableChars.Location = new System.Drawing.Point(23, 48);
            this.trvAvailableChars.Name = "trvAvailableChars";
            this.trvAvailableChars.Size = new System.Drawing.Size(261, 412);
            this.trvAvailableChars.TabIndex = 1;
            this.trvAvailableChars.DoubleClick += new System.EventHandler(this.trvAvailableChars_DoubleClick);
            this.trvAvailableChars.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvAvailableChars_AfterSelect);
            // 
            // txtPosition
            // 
            this.txtPosition.Location = new System.Drawing.Point(290, 22);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.Size = new System.Drawing.Size(100, 20);
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
            this.lstSelected.Size = new System.Drawing.Size(286, 364);
            this.lstSelected.TabIndex = 4;
            this.lstSelected.UseCompatibleStateImageBehavior = false;
            this.lstSelected.View = System.Windows.Forms.View.Details;
            this.lstSelected.SelectedIndexChanged += new System.EventHandler(this.lstSelected_SelectedIndexChanged);
            this.lstSelected.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lstSelected_ColumnClick);
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
            this.btnRemove.Location = new System.Drawing.Point(464, 421);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 25);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // objMenu
            // 
            this.objMenu.Location = new System.Drawing.Point(582, 257);
            this.objMenu.Name = "objMenu";
            this.objMenu.Size = new System.Drawing.Size(353, 215);
            this.objMenu.TabIndex = 2;
            this.objMenu.OnDoubleClickChar += new WFA_MUA.Menu.delegateDoubleClickChar(this.objMenu_OnDoubleClickChar);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(847, 214);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 6;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // txtDebug
            // 
            this.txtDebug.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDebug.Location = new System.Drawing.Point(23, 466);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ReadOnly = true;
            this.txtDebug.Size = new System.Drawing.Size(911, 57);
            this.txtDebug.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(220, 22);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(64, 23);
            this.btnReload.TabIndex = 8;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 542);
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
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}

