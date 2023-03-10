namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.queryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.specialQueryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addIntoDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.digitalBookTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.physicalBookTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penaltiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booksAssignedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registerStudentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "IPCA Smart Library Interface";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.newToolStripMenuItem,
            this.checkToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.registerStudentToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.quitToolStripMenuItem.Text = "File";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.queryToolStripMenuItem,
            this.bookOrderToolStripMenuItem,
            this.addIntoDatabaseToolStripMenuItem});
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.newToolStripMenuItem.Text = "New";
            // 
            // queryToolStripMenuItem
            // 
            this.queryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.specialQueryToolStripMenuItem,
            this.digitalBookToolStripMenuItem});
            this.queryToolStripMenuItem.Name = "queryToolStripMenuItem";
            this.queryToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.queryToolStripMenuItem.Text = "Query";
            // 
            // bookToolStripMenuItem
            // 
            this.bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            this.bookToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.bookToolStripMenuItem.Text = "Book";
            this.bookToolStripMenuItem.Click += new System.EventHandler(this.bookToolStripMenuItem_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // specialQueryToolStripMenuItem
            // 
            this.specialQueryToolStripMenuItem.Name = "specialQueryToolStripMenuItem";
            this.specialQueryToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.specialQueryToolStripMenuItem.Text = "Special Query";
            this.specialQueryToolStripMenuItem.Click += new System.EventHandler(this.specialQueryToolStripMenuItem_Click);
            // 
            // digitalBookToolStripMenuItem
            // 
            this.digitalBookToolStripMenuItem.Name = "digitalBookToolStripMenuItem";
            this.digitalBookToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.digitalBookToolStripMenuItem.Text = "Digital Book";
            // 
            // bookOrderToolStripMenuItem
            // 
            this.bookOrderToolStripMenuItem.Name = "bookOrderToolStripMenuItem";
            this.bookOrderToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.bookOrderToolStripMenuItem.Text = "Book Order";
            this.bookOrderToolStripMenuItem.Click += new System.EventHandler(this.bookOrderToolStripMenuItem_Click);
            // 
            // addIntoDatabaseToolStripMenuItem
            // 
            this.addIntoDatabaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editorToolStripMenuItem,
            this.digitalBookTypeToolStripMenuItem,
            this.physicalBookTypeToolStripMenuItem});
            this.addIntoDatabaseToolStripMenuItem.Name = "addIntoDatabaseToolStripMenuItem";
            this.addIntoDatabaseToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.addIntoDatabaseToolStripMenuItem.Text = "Add into Database";
            // 
            // editorToolStripMenuItem
            // 
            this.editorToolStripMenuItem.Name = "editorToolStripMenuItem";
            this.editorToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.editorToolStripMenuItem.Text = "Editor";
            this.editorToolStripMenuItem.Click += new System.EventHandler(this.editorToolStripMenuItem_Click);
            // 
            // digitalBookTypeToolStripMenuItem
            // 
            this.digitalBookTypeToolStripMenuItem.Name = "digitalBookTypeToolStripMenuItem";
            this.digitalBookTypeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.digitalBookTypeToolStripMenuItem.Text = "Digital Book Type";
            this.digitalBookTypeToolStripMenuItem.Click += new System.EventHandler(this.digitalBookTypeToolStripMenuItem_Click);
            // 
            // physicalBookTypeToolStripMenuItem
            // 
            this.physicalBookTypeToolStripMenuItem.Name = "physicalBookTypeToolStripMenuItem";
            this.physicalBookTypeToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.physicalBookTypeToolStripMenuItem.Text = "Physical Book Type";
            this.physicalBookTypeToolStripMenuItem.Click += new System.EventHandler(this.physicalBookTypeToolStripMenuItem_Click);
            // 
            // checkToolStripMenuItem
            // 
            this.checkToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penaltiesToolStripMenuItem,
            this.booksAssignedToolStripMenuItem,
            this.checkDatabaseToolStripMenuItem});
            this.checkToolStripMenuItem.Name = "checkToolStripMenuItem";
            this.checkToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.checkToolStripMenuItem.Text = "Check";
            // 
            // penaltiesToolStripMenuItem
            // 
            this.penaltiesToolStripMenuItem.Name = "penaltiesToolStripMenuItem";
            this.penaltiesToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.penaltiesToolStripMenuItem.Text = "Penalties";
            this.penaltiesToolStripMenuItem.Click += new System.EventHandler(this.penaltiesToolStripMenuItem_Click);
            // 
            // booksAssignedToolStripMenuItem
            // 
            this.booksAssignedToolStripMenuItem.Name = "booksAssignedToolStripMenuItem";
            this.booksAssignedToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.booksAssignedToolStripMenuItem.Text = "Books Provided";
            this.booksAssignedToolStripMenuItem.Click += new System.EventHandler(this.booksAssignedToolStripMenuItem_Click);
            // 
            // checkDatabaseToolStripMenuItem
            // 
            this.checkDatabaseToolStripMenuItem.Name = "checkDatabaseToolStripMenuItem";
            this.checkDatabaseToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.checkDatabaseToolStripMenuItem.Text = "Check Database";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // registerStudentToolStripMenuItem
            // 
            this.registerStudentToolStripMenuItem.Name = "registerStudentToolStripMenuItem";
            this.registerStudentToolStripMenuItem.Size = new System.Drawing.Size(105, 20);
            this.registerStudentToolStripMenuItem.Text = "Register Student";
            this.registerStudentToolStripMenuItem.Click += new System.EventHandler(this.registerStudentToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(323, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select an option in the menu";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ipca Smart Library Interface";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem queryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem orderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addIntoDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penaltiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksAssignedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registerStudentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalBookTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem physicalBookTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem specialQueryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem digitalBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkDatabaseToolStripMenuItem;
    }
}

