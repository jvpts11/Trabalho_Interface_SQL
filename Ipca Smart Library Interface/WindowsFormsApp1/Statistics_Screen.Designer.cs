namespace WindowsFormsApp1
{
    partial class Statistics_Screen
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
            this.statistics_students_app = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statistics_returned_books = new System.Windows.Forms.Button();
            this.statistics_return_extension = new System.Windows.Forms.Button();
            this.statistics_return_delays = new System.Windows.Forms.Button();
            this.statistics_students_service = new System.Windows.Forms.Button();
            this.registered_students_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statistics_students_app
            // 
            this.statistics_students_app.Location = new System.Drawing.Point(284, 94);
            this.statistics_students_app.Name = "statistics_students_app";
            this.statistics_students_app.Size = new System.Drawing.Size(208, 23);
            this.statistics_students_app.TabIndex = 0;
            this.statistics_students_app.Text = "See How Much students use the app";
            this.statistics_students_app.UseVisualStyleBackColor = true;
            this.statistics_students_app.Click += new System.EventHandler(this.statistics_students_app_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(144, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(510, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // statistics_returned_books
            // 
            this.statistics_returned_books.Location = new System.Drawing.Point(63, 86);
            this.statistics_returned_books.Name = "statistics_returned_books";
            this.statistics_returned_books.Size = new System.Drawing.Size(173, 39);
            this.statistics_returned_books.TabIndex = 2;
            this.statistics_returned_books.Text = "How Much Books where returned";
            this.statistics_returned_books.UseVisualStyleBackColor = true;
            this.statistics_returned_books.Click += new System.EventHandler(this.statistics_returned_books_Click);
            // 
            // statistics_return_extension
            // 
            this.statistics_return_extension.Location = new System.Drawing.Point(534, 84);
            this.statistics_return_extension.Name = "statistics_return_extension";
            this.statistics_return_extension.Size = new System.Drawing.Size(217, 41);
            this.statistics_return_extension.TabIndex = 3;
            this.statistics_return_extension.Text = "How much orders where requested the return date extension";
            this.statistics_return_extension.UseVisualStyleBackColor = true;
            this.statistics_return_extension.Click += new System.EventHandler(this.statistics_return_extension_Click);
            // 
            // statistics_return_delays
            // 
            this.statistics_return_delays.Location = new System.Drawing.Point(144, 153);
            this.statistics_return_delays.Name = "statistics_return_delays";
            this.statistics_return_delays.Size = new System.Drawing.Size(206, 32);
            this.statistics_return_delays.TabIndex = 4;
            this.statistics_return_delays.Text = "Average of return delays";
            this.statistics_return_delays.UseVisualStyleBackColor = true;
            this.statistics_return_delays.Click += new System.EventHandler(this.statistics_return_delays_Click);
            // 
            // statistics_students_service
            // 
            this.statistics_students_service.Location = new System.Drawing.Point(405, 153);
            this.statistics_students_service.Name = "statistics_students_service";
            this.statistics_students_service.Size = new System.Drawing.Size(203, 30);
            this.statistics_students_service.TabIndex = 5;
            this.statistics_students_service.Text = "How much students use the service";
            this.statistics_students_service.UseVisualStyleBackColor = true;
            this.statistics_students_service.Click += new System.EventHandler(this.statistics_students_service_Click);
            // 
            // registered_students_button
            // 
            this.registered_students_button.Location = new System.Drawing.Point(284, 36);
            this.registered_students_button.Name = "registered_students_button";
            this.registered_students_button.Size = new System.Drawing.Size(206, 30);
            this.registered_students_button.TabIndex = 6;
            this.registered_students_button.Text = "List Students registered";
            this.registered_students_button.UseVisualStyleBackColor = true;
            this.registered_students_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Statistics_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.registered_students_button);
            this.Controls.Add(this.statistics_students_service);
            this.Controls.Add(this.statistics_return_delays);
            this.Controls.Add(this.statistics_return_extension);
            this.Controls.Add(this.statistics_returned_books);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.statistics_students_app);
            this.Name = "Statistics_Screen";
            this.Text = "Statistics_Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button statistics_students_app;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button statistics_returned_books;
        private System.Windows.Forms.Button statistics_return_extension;
        private System.Windows.Forms.Button statistics_return_delays;
        private System.Windows.Forms.Button statistics_students_service;
        private System.Windows.Forms.Button registered_students_button;
    }
}