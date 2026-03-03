namespace WindowsForms_06_TreeView_MenuStrip_Controls
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("MCPD Yazılım Eğitimi");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Grafik Tasarım");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("SQL Raporlama");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Mobile Uygulama Geliştirme");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Kurslar", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("C# Eğitimi");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("SQL Eğitimleir ");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Yazılım Eğitim Konuları", new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7});
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Eğitim İçerikleri", new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(145, 67);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "MCPD Yazılım Eğitimi";
            treeNode2.Name = "Node2";
            treeNode2.Text = "Grafik Tasarım";
            treeNode3.Name = "Node3";
            treeNode3.Text = "SQL Raporlama";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Mobile Uygulama Geliştirme";
            treeNode5.Name = "Node0";
            treeNode5.Text = "Kurslar";
            treeNode6.Name = "Node8";
            treeNode6.Text = "C# Eğitimi";
            treeNode7.Name = "Node9";
            treeNode7.Text = "SQL Eğitimleir ";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Yazılım Eğitim Konuları";
            treeNode9.Name = "Node5";
            treeNode9.Text = "Eğitim İçerikleri";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode9});
            this.treeView1.Size = new System.Drawing.Size(284, 218);
            this.treeView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Treeview Kullanımı";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
    }
}

