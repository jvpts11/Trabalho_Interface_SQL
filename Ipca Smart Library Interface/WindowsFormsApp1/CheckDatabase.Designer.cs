namespace WindowsFormsApp1
{
    partial class CheckDatabase
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showEditors = new System.Windows.Forms.Button();
            this.showOrders = new System.Windows.Forms.Button();
            this.showBookOrders = new System.Windows.Forms.Button();
            this.showBookTypes = new System.Windows.Forms.Button();
            this.showDigitalBookTypes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(62, 219);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(670, 197);
            this.dataGridView1.TabIndex = 0;
            // 
            // showEditors
            // 
            this.showEditors.Location = new System.Drawing.Point(62, 95);
            this.showEditors.Name = "showEditors";
            this.showEditors.Size = new System.Drawing.Size(160, 32);
            this.showEditors.TabIndex = 1;
            this.showEditors.Text = "Show Editors in DB";
            this.showEditors.UseVisualStyleBackColor = true;
            this.showEditors.Click += new System.EventHandler(this.showEditors_Click);
            // 
            // showOrders
            // 
            this.showOrders.Location = new System.Drawing.Point(320, 95);
            this.showOrders.Name = "showOrders";
            this.showOrders.Size = new System.Drawing.Size(160, 32);
            this.showOrders.TabIndex = 2;
            this.showOrders.Text = "Show Orders in DB";
            this.showOrders.UseVisualStyleBackColor = true;
            this.showOrders.Click += new System.EventHandler(this.showOrders_Click);
            // 
            // showBookOrders
            // 
            this.showBookOrders.Location = new System.Drawing.Point(572, 95);
            this.showBookOrders.Name = "showBookOrders";
            this.showBookOrders.Size = new System.Drawing.Size(160, 32);
            this.showBookOrders.TabIndex = 3;
            this.showBookOrders.Text = "Show Book Orders in DB";
            this.showBookOrders.UseVisualStyleBackColor = true;
            this.showBookOrders.Click += new System.EventHandler(this.showBookOrders_Click);
            // 
            // showBookTypes
            // 
            this.showBookTypes.Location = new System.Drawing.Point(183, 160);
            this.showBookTypes.Name = "showBookTypes";
            this.showBookTypes.Size = new System.Drawing.Size(160, 32);
            this.showBookTypes.TabIndex = 4;
            this.showBookTypes.Text = "Show Physical Book Types";
            this.showBookTypes.UseVisualStyleBackColor = true;
            this.showBookTypes.Click += new System.EventHandler(this.showBookTypes_Click);
            // 
            // showDigitalBookTypes
            // 
            this.showDigitalBookTypes.Location = new System.Drawing.Point(441, 160);
            this.showDigitalBookTypes.Name = "showDigitalBookTypes";
            this.showDigitalBookTypes.Size = new System.Drawing.Size(160, 32);
            this.showDigitalBookTypes.TabIndex = 5;
            this.showDigitalBookTypes.Text = "Show Digital Book Types";
            this.showDigitalBookTypes.UseVisualStyleBackColor = true;
            this.showDigitalBookTypes.Click += new System.EventHandler(this.showDigitalBookTypes_Click);
            // 
            // CheckDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showDigitalBookTypes);
            this.Controls.Add(this.showBookTypes);
            this.Controls.Add(this.showBookOrders);
            this.Controls.Add(this.showOrders);
            this.Controls.Add(this.showEditors);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CheckDatabase";
            this.Text = "CheckDatabase";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showEditors;
        private System.Windows.Forms.Button showOrders;
        private System.Windows.Forms.Button showBookOrders;
        private System.Windows.Forms.Button showBookTypes;
        private System.Windows.Forms.Button showDigitalBookTypes;
    }
}