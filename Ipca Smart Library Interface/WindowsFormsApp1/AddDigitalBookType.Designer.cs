namespace WindowsFormsApp1
{
    partial class AddDigitalBookType
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.db_id_input = new System.Windows.Forms.TextBox();
            this.db_type_name_input = new System.Windows.Forms.TextBox();
            this.db_type_insert_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id of This Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(254, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insert a new Digital Book Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type Name";
            // 
            // db_id_input
            // 
            this.db_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_id_input.Location = new System.Drawing.Point(281, 134);
            this.db_id_input.Name = "db_id_input";
            this.db_id_input.Size = new System.Drawing.Size(196, 29);
            this.db_id_input.TabIndex = 3;
            // 
            // db_type_name_input
            // 
            this.db_type_name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.db_type_name_input.Location = new System.Drawing.Point(281, 176);
            this.db_type_name_input.Name = "db_type_name_input";
            this.db_type_name_input.Size = new System.Drawing.Size(196, 29);
            this.db_type_name_input.TabIndex = 4;
            this.db_type_name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // db_type_insert_button
            // 
            this.db_type_insert_button.Location = new System.Drawing.Point(269, 231);
            this.db_type_insert_button.Name = "db_type_insert_button";
            this.db_type_insert_button.Size = new System.Drawing.Size(219, 40);
            this.db_type_insert_button.TabIndex = 5;
            this.db_type_insert_button.Text = "Insert Digital Book Type";
            this.db_type_insert_button.UseVisualStyleBackColor = true;
            this.db_type_insert_button.Click += new System.EventHandler(this.db_type_insert_button_Click);
            // 
            // AddDigitalBookType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.db_type_insert_button);
            this.Controls.Add(this.db_type_name_input);
            this.Controls.Add(this.db_id_input);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddDigitalBookType";
            this.Text = "AddDigitalBookType";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox db_id_input;
        private System.Windows.Forms.TextBox db_type_name_input;
        private System.Windows.Forms.Button db_type_insert_button;
    }
}