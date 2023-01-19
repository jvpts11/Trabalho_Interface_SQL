namespace WindowsFormsApp1
{
    partial class AddPhysicalBookType
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
            this.physical_book_type_insert_button = new System.Windows.Forms.Button();
            this.physical_book_type_name_input = new System.Windows.Forms.TextBox();
            this.physical_book_id_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // physical_book_type_insert_button
            // 
            this.physical_book_type_insert_button.Location = new System.Drawing.Point(297, 247);
            this.physical_book_type_insert_button.Name = "physical_book_type_insert_button";
            this.physical_book_type_insert_button.Size = new System.Drawing.Size(219, 40);
            this.physical_book_type_insert_button.TabIndex = 11;
            this.physical_book_type_insert_button.Text = "Insert Physical Book Type";
            this.physical_book_type_insert_button.UseVisualStyleBackColor = true;
            this.physical_book_type_insert_button.Click += new System.EventHandler(this.physical_book_type_insert_button_Click);
            // 
            // physical_book_type_name_input
            // 
            this.physical_book_type_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physical_book_type_name_input.Location = new System.Drawing.Point(309, 192);
            this.physical_book_type_name_input.Name = "physical_book_type_name_input";
            this.physical_book_type_name_input.Size = new System.Drawing.Size(196, 29);
            this.physical_book_type_name_input.TabIndex = 10;
            // 
            // physical_book_id_input
            // 
            this.physical_book_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.physical_book_id_input.Location = new System.Drawing.Point(309, 150);
            this.physical_book_id_input.Name = "physical_book_id_input";
            this.physical_book_id_input.Size = new System.Drawing.Size(196, 29);
            this.physical_book_id_input.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(152, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Type Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(281, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Insert a new Physical Book Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Id of This Type";
            // 
            // AddPhysicalBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.physical_book_type_insert_button);
            this.Controls.Add(this.physical_book_type_name_input);
            this.Controls.Add(this.physical_book_id_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPhysicalBookType";
            this.Text = "AddPhysicalBookType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button physical_book_type_insert_button;
        private System.Windows.Forms.TextBox physical_book_type_name_input;
        private System.Windows.Forms.TextBox physical_book_id_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}