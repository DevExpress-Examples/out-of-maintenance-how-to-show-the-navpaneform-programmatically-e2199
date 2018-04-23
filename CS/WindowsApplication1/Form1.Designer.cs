namespace WindowsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Contacts", 1, 1);
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Deleted Items", 8, 8);
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Drafts", 9, 9);
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Inbox", 10, 10);
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Journal", 3, 3);
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Notes", 5, 5);
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Outbox", 12, 12);
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Sent Items", 15, 15);
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Tasks", 7, 7);
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Personal Folders", 13, 13, new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18,
            treeNode19});
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.navBarGroupControlContainer2 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.navBarGroupControlContainer3 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.treeView1 = new DevExpress.Utils.Design.DXTreeView();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup5 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup6 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup7 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup8 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup9 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem2 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem3 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem4 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem5 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem6 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem7 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem8 = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem9 = new DevExpress.XtraNavBar.NavBarItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            this.navBarControl1.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.navBarGroupControlContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList2.Images.SetKeyName(0, "");
            this.imageList2.Images.SetKeyName(1, "");
            this.imageList2.Images.SetKeyName(2, "");
            this.imageList2.Images.SetKeyName(3, "");
            this.imageList2.Images.SetKeyName(4, "");
            this.imageList2.Images.SetKeyName(5, "");
            this.imageList2.Images.SetKeyName(6, "");
            this.imageList2.Images.SetKeyName(7, "");
            this.imageList2.Images.SetKeyName(8, "");
            this.imageList2.Images.SetKeyName(9, "");
            this.imageList2.Images.SetKeyName(10, "");
            this.imageList2.Images.SetKeyName(11, "");
            this.imageList2.Images.SetKeyName(12, "");
            this.imageList2.Images.SetKeyName(13, "");
            this.imageList2.Images.SetKeyName(14, "");
            this.imageList2.Images.SetKeyName(15, "");
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup9;
            this.navBarControl1.ContentButtonHint = null;
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer1);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer2);
            this.navBarControl1.Controls.Add(this.navBarGroupControlContainer3);
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4,
            this.navBarGroup5,
            this.navBarGroup6,
            this.navBarGroup7,
            this.navBarGroup8,
            this.navBarGroup9});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.navBarItem1,
            this.navBarItem2,
            this.navBarItem3,
            this.navBarItem4,
            this.navBarItem5,
            this.navBarItem6,
            this.navBarItem7,
            this.navBarItem8,
            this.navBarItem9});
            this.navBarControl1.LargeImages = this.imageList1;
            this.navBarControl1.LinkSelectionMode = DevExpress.XtraNavBar.LinkSelectionModeType.OneInGroup;
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.NavigationPaneGroupClientHeight = 160;
            this.navBarControl1.NavigationPaneMaxVisibleGroups = 5;
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 200;
            this.navBarControl1.OptionsNavPane.NavPaneState = DevExpress.XtraNavBar.NavPaneState.Collapsed;
            this.navBarControl1.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.navBarControl1.Size = new System.Drawing.Size(46, 624);
            this.navBarControl1.SmallImages = this.imageList2;
            this.navBarControl1.StoreDefaultPaintStyleName = true;
            this.navBarControl1.TabIndex = 6;
            this.navBarControl1.Text = "navBarControl1";
            
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "Calendar";
            this.navBarGroup3.ControlContainer = this.navBarGroupControlContainer1;
            this.navBarGroup3.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup3.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup3.GroupClientHeight = 160;
            this.navBarGroup3.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem3)});
            this.navBarGroup3.LargeImageIndex = 0;
            this.navBarGroup3.Name = "navBarGroup3";
            this.navBarGroup3.SelectedLinkIndex = 0;
            this.navBarGroup3.SmallImageIndex = 0;
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Controls.Add(this.panel2);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(200, 334);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 334);
            this.panel2.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 8);
            this.panel1.TabIndex = 1;
            // 
            // navBarGroupControlContainer2
            // 
            this.navBarGroupControlContainer2.Name = "navBarGroupControlContainer2";
            this.navBarGroupControlContainer2.Size = new System.Drawing.Size(200, 334);
            this.navBarGroupControlContainer2.TabIndex = 1;
            // 
            // navBarGroupControlContainer3
            // 
            this.navBarGroupControlContainer3.Controls.Add(this.treeView1);
            this.navBarGroupControlContainer3.Name = "navBarGroupControlContainer3";
            this.navBarGroupControlContainer3.Size = new System.Drawing.Size(200, 334);
            this.navBarGroupControlContainer3.TabIndex = 2;
            // 
            // treeView1
            // 
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.DefaultExpandCollapseButtonOffset = 5;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList2;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode11.ImageIndex = 1;
            treeNode11.Name = "";
            treeNode11.SelectedImageIndex = 1;
            treeNode11.Text = "Contacts";
            treeNode12.ImageIndex = 8;
            treeNode12.Name = "";
            treeNode12.SelectedImageIndex = 8;
            treeNode12.Text = "Deleted Items";
            treeNode13.ImageIndex = 9;
            treeNode13.Name = "";
            treeNode13.SelectedImageIndex = 9;
            treeNode13.Text = "Drafts";
            treeNode14.ImageIndex = 10;
            treeNode14.Name = "";
            treeNode14.SelectedImageIndex = 10;
            treeNode14.Text = "Inbox";
            treeNode15.ImageIndex = 3;
            treeNode15.Name = "";
            treeNode15.SelectedImageIndex = 3;
            treeNode15.Text = "Journal";
            treeNode16.ImageIndex = 5;
            treeNode16.Name = "";
            treeNode16.SelectedImageIndex = 5;
            treeNode16.Text = "Notes";
            treeNode17.ImageIndex = 12;
            treeNode17.Name = "";
            treeNode17.SelectedImageIndex = 12;
            treeNode17.Text = "Outbox";
            treeNode18.ImageIndex = 15;
            treeNode18.Name = "";
            treeNode18.SelectedImageIndex = 15;
            treeNode18.Text = "Sent Items";
            treeNode19.ImageIndex = 7;
            treeNode19.Name = "";
            treeNode19.SelectedImageIndex = 7;
            treeNode19.Text = "Tasks";
            treeNode20.ImageIndex = 13;
            treeNode20.Name = "";
            treeNode20.SelectedImageIndex = 13;
            treeNode20.Text = "Personal Folders";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode20});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.SelectionMode = DevExpress.Utils.Design.DXTreeSelectionMode.MultiSelectChildrenSameBranch;
            this.treeView1.Size = new System.Drawing.Size(200, 334);
            this.treeView1.TabIndex = 0;
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "Mail";
            this.navBarGroup2.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup2.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.SmallIconsText;
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem2),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup2.LargeImageIndex = 4;
            this.navBarGroup2.Name = "navBarGroup2";
            this.navBarGroup2.SelectedLinkIndex = 0;
            this.navBarGroup2.SmallImageIndex = 4;
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "Contacts";
            this.navBarGroup4.ControlContainer = this.navBarGroupControlContainer2;
            this.navBarGroup4.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup4.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup4.GroupClientHeight = 160;
            this.navBarGroup4.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem5)});
            this.navBarGroup4.LargeImageIndex = 1;
            this.navBarGroup4.Name = "navBarGroup4";
            this.navBarGroup4.SelectedLinkIndex = 0;
            this.navBarGroup4.SmallImageIndex = 1;
            // 
            // navBarGroup5
            // 
            this.navBarGroup5.Caption = "Tasks";
            this.navBarGroup5.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup5.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup5.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem6)});
            this.navBarGroup5.LargeImageIndex = 7;
            this.navBarGroup5.Name = "navBarGroup5";
            this.navBarGroup5.SelectedLinkIndex = 0;
            this.navBarGroup5.SmallImageIndex = 7;
            // 
            // navBarGroup6
            // 
            this.navBarGroup6.Caption = "Notes";
            this.navBarGroup6.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup6.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup6.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem7)});
            this.navBarGroup6.LargeImageIndex = 5;
            this.navBarGroup6.Name = "navBarGroup6";
            this.navBarGroup6.SelectedLinkIndex = 0;
            this.navBarGroup6.SmallImageIndex = 5;
            // 
            // navBarGroup7
            // 
            this.navBarGroup7.Caption = "Folder List";
            this.navBarGroup7.ControlContainer = this.navBarGroupControlContainer3;
            this.navBarGroup7.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup7.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup7.GroupClientHeight = 160;
            this.navBarGroup7.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.navBarGroup7.LargeImageIndex = 2;
            this.navBarGroup7.Name = "navBarGroup7";
            this.navBarGroup7.SmallImageIndex = 2;
            // 
            // navBarGroup8
            // 
            this.navBarGroup8.Caption = "Shortcuts";
            this.navBarGroup8.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup8.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup8.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem8)});
            this.navBarGroup8.LargeImageIndex = 6;
            this.navBarGroup8.Name = "navBarGroup8";
            this.navBarGroup8.SelectedLinkIndex = 0;
            this.navBarGroup8.SmallImageIndex = 6;
            // 
            // navBarGroup9
            // 
            this.navBarGroup9.Caption = "Journal";
            this.navBarGroup9.DragDropFlags = DevExpress.XtraNavBar.NavBarDragDrop.None;
            this.navBarGroup9.Expanded = true;
            this.navBarGroup9.GroupCaptionUseImage = DevExpress.XtraNavBar.NavBarImage.Large;
            this.navBarGroup9.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem9)});
            this.navBarGroup9.LargeImageIndex = 3;
            this.navBarGroup9.Name = "navBarGroup9";
            this.navBarGroup9.SelectedLinkIndex = 0;
            this.navBarGroup9.SmallImageIndex = 3;
            this.navBarGroup9.Visible = false;
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Inbox";
            this.navBarItem1.Name = "navBarItem1";
            this.navBarItem1.SmallImageIndex = 10;
            // 
            // navBarItem2
            // 
            this.navBarItem2.Caption = "Outbox";
            this.navBarItem2.Name = "navBarItem2";
            this.navBarItem2.SmallImageIndex = 12;
            // 
            // navBarItem3
            // 
            this.navBarItem3.Caption = "Sent Items";
            this.navBarItem3.Name = "navBarItem3";
            this.navBarItem3.SmallImageIndex = 15;
            // 
            // navBarItem4
            // 
            this.navBarItem4.Caption = "Deleted Items";
            this.navBarItem4.Name = "navBarItem4";
            this.navBarItem4.SmallImageIndex = 8;
            // 
            // navBarItem5
            // 
            this.navBarItem5.Caption = "Drafts";
            this.navBarItem5.Name = "navBarItem5";
            this.navBarItem5.SmallImageIndex = 9;
            // 
            // navBarItem6
            // 
            this.navBarItem6.Caption = "Tasks";
            this.navBarItem6.Name = "navBarItem6";
            this.navBarItem6.SmallImageIndex = 7;
            // 
            // navBarItem7
            // 
            this.navBarItem7.Caption = "Notes";
            this.navBarItem7.Name = "navBarItem7";
            this.navBarItem7.SmallImageIndex = 5;
            // 
            // navBarItem8
            // 
            this.navBarItem8.Caption = "Shortcuts";
            this.navBarItem8.Name = "navBarItem8";
            this.navBarItem8.SmallImageIndex = 6;
            // 
            // navBarItem9
            // 
            this.navBarItem9.Caption = "Juornal";
            this.navBarItem9.Name = "navBarItem9";
            this.navBarItem9.SmallImageIndex = 3;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList1.Images.SetKeyName(0, "");
            this.imageList1.Images.SetKeyName(1, "");
            this.imageList1.Images.SetKeyName(2, "");
            this.imageList1.Images.SetKeyName(3, "");
            this.imageList1.Images.SetKeyName(4, "");
            this.imageList1.Images.SetKeyName(5, "");
            this.imageList1.Images.SetKeyName(6, "");
            this.imageList1.Images.SetKeyName(7, "");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Magenta;
            this.imageList3.Images.SetKeyName(0, "");
            this.imageList3.Images.SetKeyName(1, "");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 624);
            this.Controls.Add(this.navBarControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            this.navBarControl1.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.navBarGroupControlContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList2;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer2;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer3;
        private DevExpress.Utils.Design.DXTreeView treeView1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup5;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup6;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup7;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup8;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup9;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraNavBar.NavBarItem navBarItem2;
        private DevExpress.XtraNavBar.NavBarItem navBarItem3;
        private DevExpress.XtraNavBar.NavBarItem navBarItem4;
        private DevExpress.XtraNavBar.NavBarItem navBarItem5;
        private DevExpress.XtraNavBar.NavBarItem navBarItem6;
        private DevExpress.XtraNavBar.NavBarItem navBarItem7;
        private DevExpress.XtraNavBar.NavBarItem navBarItem8;
        private DevExpress.XtraNavBar.NavBarItem navBarItem9;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList3;
    }
}

