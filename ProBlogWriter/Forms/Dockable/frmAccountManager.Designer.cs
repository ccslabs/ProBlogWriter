namespace ProBlogWriter.Forms.Dockable
{
    partial class frmAccountManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Wordpress");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Twitter");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Facebook");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Accounts", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6,
            treeNode7});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccountManager));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tvAccounts = new System.Windows.Forms.TreeView();
            this.ilTreeView = new System.Windows.Forms.ImageList(this.components);
            this.cmsAccountsTreeView = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.cmsAccountsTreeView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tvAccounts);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(759, 395);
            this.splitContainer1.SplitterDistance = 253;
            this.splitContainer1.TabIndex = 0;
            // 
            // tvAccounts
            // 
            this.tvAccounts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvAccounts.ImageIndex = 5;
            this.tvAccounts.ImageList = this.ilTreeView;
            this.tvAccounts.Location = new System.Drawing.Point(0, 0);
            this.tvAccounts.Name = "tvAccounts";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "Node1";
            treeNode5.Text = "Wordpress";
            treeNode6.ImageIndex = 3;
            treeNode6.Name = "Node2";
            treeNode6.Text = "Twitter";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "nFacebook";
            treeNode7.Text = "Facebook";
            treeNode8.Name = "Node0";
            treeNode8.Text = "Accounts";
            this.tvAccounts.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvAccounts.SelectedImageIndex = 0;
            this.tvAccounts.Size = new System.Drawing.Size(253, 395);
            this.tvAccounts.TabIndex = 0;
            // 
            // ilTreeView
            // 
            this.ilTreeView.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilTreeView.ImageStream")));
            this.ilTreeView.TransparentColor = System.Drawing.Color.Transparent;
            this.ilTreeView.Images.SetKeyName(0, "feather-146506_640.png");
            this.ilTreeView.Images.SetKeyName(1, "5431299df40cc.png");
            this.ilTreeView.Images.SetKeyName(2, "Facebook-120x120px.png");
            this.ilTreeView.Images.SetKeyName(3, "social_twitter_box_blue.png");
            this.ilTreeView.Images.SetKeyName(4, "keyboard.png");
            this.ilTreeView.Images.SetKeyName(5, "table_multiple.png");
            // 
            // cmsAccountsTreeView
            // 
            this.cmsAccountsTreeView.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.listToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripSeparator1,
            this.removeToolStripMenuItem});
            this.cmsAccountsTreeView.Name = "cmsAccountsTreeView";
            this.cmsAccountsTreeView.Size = new System.Drawing.Size(118, 98);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(114, 6);
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Image = global::ProBlogWriter.Properties.Resources.add;
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // listToolStripMenuItem
            // 
            this.listToolStripMenuItem.Image = global::ProBlogWriter.Properties.Resources.text_list_bullets;
            this.listToolStripMenuItem.Name = "listToolStripMenuItem";
            this.listToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.listToolStripMenuItem.Text = "List";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = global::ProBlogWriter.Properties.Resources.vcard_edit;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Image = global::ProBlogWriter.Properties.Resources.delete;
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(502, 395);
            this.dataGridView1.TabIndex = 0;
            // 
            // frmAccountManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 395);
            this.Controls.Add(this.splitContainer1);
            this.DockAreas = ((WeifenLuo.WinFormsUI.Docking.DockAreas)((WeifenLuo.WinFormsUI.Docking.DockAreas.Float | WeifenLuo.WinFormsUI.Docking.DockAreas.Document)));
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "frmAccountManager";
            this.Text = "Account Manager";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.cmsAccountsTreeView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView tvAccounts;
        private System.Windows.Forms.ImageList ilTreeView;
        private System.Windows.Forms.ContextMenuStrip cmsAccountsTreeView;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}