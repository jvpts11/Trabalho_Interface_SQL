namespace WindowsFormsApp1
{
    partial class MakeBookOrder
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.order_id_input = new System.Windows.Forms.TextBox();
            this.amount_to_buy_input = new System.Windows.Forms.TextBox();
            this.price_input = new System.Windows.Forms.TextBox();
            this.editor_id_input = new System.Windows.Forms.TextBox();
            this.make_book_order_add_order_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Request the library to buy new Books";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Order Id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Amount to Buy";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(162, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Price Estimation";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(259, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Editor id from which books will be bough";
            // 
            // order_id_input
            // 
            this.order_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.order_id_input.Location = new System.Drawing.Point(286, 121);
            this.order_id_input.Name = "order_id_input";
            this.order_id_input.Size = new System.Drawing.Size(294, 23);
            this.order_id_input.TabIndex = 5;
            // 
            // amount_to_buy_input
            // 
            this.amount_to_buy_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_to_buy_input.Location = new System.Drawing.Point(286, 150);
            this.amount_to_buy_input.Name = "amount_to_buy_input";
            this.amount_to_buy_input.Size = new System.Drawing.Size(294, 23);
            this.amount_to_buy_input.TabIndex = 6;
            // 
            // price_input
            // 
            this.price_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_input.Location = new System.Drawing.Point(286, 180);
            this.price_input.Name = "price_input";
            this.price_input.Size = new System.Drawing.Size(294, 23);
            this.price_input.TabIndex = 7;
            // 
            // editor_id_input
            // 
            this.editor_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editor_id_input.Location = new System.Drawing.Point(286, 209);
            this.editor_id_input.Name = "editor_id_input";
            this.editor_id_input.Size = new System.Drawing.Size(294, 23);
            this.editor_id_input.TabIndex = 8;
            // 
            // make_book_order_add_order_button
            // 
            this.make_book_order_add_order_button.Location = new System.Drawing.Point(273, 252);
            this.make_book_order_add_order_button.Name = "make_book_order_add_order_button";
            this.make_book_order_add_order_button.Size = new System.Drawing.Size(232, 23);
            this.make_book_order_add_order_button.TabIndex = 9;
            this.make_book_order_add_order_button.Text = "Add Order";
            this.make_book_order_add_order_button.UseVisualStyleBackColor = true;
            this.make_book_order_add_order_button.Click += new System.EventHandler(this.make_book_order_add_order_button_Click);
            // 
            // MakeBookOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.make_book_order_add_order_button);
            this.Controls.Add(this.editor_id_input);
            this.Controls.Add(this.price_input);
            this.Controls.Add(this.amount_to_buy_input);
            this.Controls.Add(this.order_id_input);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MakeBookOrder";
            this.Text = "MakeBookOrder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox order_id_input;
        private System.Windows.Forms.TextBox amount_to_buy_input;
        private System.Windows.Forms.TextBox price_input;
        private System.Windows.Forms.TextBox editor_id_input;
        private System.Windows.Forms.Button make_book_order_add_order_button;
    }
}