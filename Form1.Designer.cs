namespace InvoiceTotal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.netAmountTextbox = new System.Windows.Forms.TextBox();
            this.discountAmountTextbox = new System.Windows.Forms.TextBox();
            this.discountPresentTextbox = new System.Windows.Forms.TextBox();
            this.invoiceTextbox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.grandTotalTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Invoice Total :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount Present :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Discount Amount :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Net Amount :";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 163);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 23);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(93, 163);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.SystemColors.Control;
            this.exitButton.ForeColor = System.Drawing.Color.Red;
            this.exitButton.Location = new System.Drawing.Point(174, 163);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // netAmountTextbox
            // 
            this.netAmountTextbox.Location = new System.Drawing.Point(149, 115);
            this.netAmountTextbox.Name = "netAmountTextbox";
            this.netAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.netAmountTextbox.TabIndex = 7;
            this.netAmountTextbox.TabStop = false;
            // 
            // discountAmountTextbox
            // 
            this.discountAmountTextbox.Location = new System.Drawing.Point(149, 82);
            this.discountAmountTextbox.Name = "discountAmountTextbox";
            this.discountAmountTextbox.Size = new System.Drawing.Size(100, 20);
            this.discountAmountTextbox.TabIndex = 8;
            this.discountAmountTextbox.TabStop = false;
            // 
            // discountPresentTextbox
            // 
            this.discountPresentTextbox.Location = new System.Drawing.Point(149, 49);
            this.discountPresentTextbox.Name = "discountPresentTextbox";
            this.discountPresentTextbox.Size = new System.Drawing.Size(100, 20);
            this.discountPresentTextbox.TabIndex = 1;
            // 
            // invoiceTextbox
            // 
            this.invoiceTextbox.Location = new System.Drawing.Point(149, 16);
            this.invoiceTextbox.Name = "invoiceTextbox";
            this.invoiceTextbox.Size = new System.Drawing.Size(100, 20);
            this.invoiceTextbox.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Grand Total:";
            // 
            // grandTotalTextbox
            // 
            this.grandTotalTextbox.Location = new System.Drawing.Point(149, 202);
            this.grandTotalTextbox.Name = "grandTotalTextbox";
            this.grandTotalTextbox.Size = new System.Drawing.Size(100, 20);
            this.grandTotalTextbox.TabIndex = 10;
            this.grandTotalTextbox.TabStop = false;
            this.grandTotalTextbox.TextChanged += new System.EventHandler(this.grandTotalTextbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 234);
            this.Controls.Add(this.grandTotalTextbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.invoiceTextbox);
            this.Controls.Add(this.discountPresentTextbox);
            this.Controls.Add(this.discountAmountTextbox);
            this.Controls.Add(this.netAmountTextbox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Total Invoice";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox netAmountTextbox;
        private System.Windows.Forms.TextBox discountAmountTextbox;
        private System.Windows.Forms.TextBox discountPresentTextbox;
        private System.Windows.Forms.TextBox invoiceTextbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox grandTotalTextbox;
    }
}

