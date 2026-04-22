namespace Utility_Bill_Estimator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lblTotal = new Label();
            txtUsageKwh = new TextBox();
            txtRatePerKwh = new TextBox();
            btnCalculate = new Button();
            btnClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 65);
            label1.Name = "label1";
            label1.Size = new Size(149, 15);
            label1.TabIndex = 0;
            label1.Text = "UTILITY BILL CALCULATOR";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(92, 165);
            label2.Name = "label2";
            label2.Size = new Size(141, 15);
            label2.TabIndex = 1;
            label2.Text = "ELECTRICITY USED (kWh)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(92, 205);
            label3.Name = "label3";
            label3.Size = new Size(144, 15);
            label3.TabIndex = 2;
            label3.Text = "COST OF ELECTRICITY (R)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(92, 248);
            label4.Name = "label4";
            label4.Size = new Size(163, 15);
            label4.TabIndex = 3;
            label4.Text = "TOTAL AMOUNT PAYABLE (R)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(92, 292);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(35, 15);
            lblTotal.TabIndex = 4;
            lblTotal.Text = "R0.00";
            // 
            // txtUsageKwh
            // 
            txtUsageKwh.Location = new Point(248, 162);
            txtUsageKwh.Name = "txtUsageKwh";
            txtUsageKwh.Size = new Size(100, 23);
            txtUsageKwh.TabIndex = 5;
            // 
            // txtRatePerKwh
            // 
            txtRatePerKwh.Location = new Point(248, 205);
            txtRatePerKwh.Name = "txtRatePerKwh";
            txtRatePerKwh.Size = new Size(100, 23);
            txtRatePerKwh.TabIndex = 6;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(251, 338);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 23);
            btnCalculate.TabIndex = 7;
            btnCalculate.Text = "Calculate bill";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(460, 338);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(btnCalculate);
            Controls.Add(txtRatePerKwh);
            Controls.Add(txtUsageKwh);
            Controls.Add(lblTotal);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lblTotal;
        private TextBox txtUsageKwh;
        private TextBox txtRatePerKwh;
        private Button btnCalculate;
        private Button btnClear;
    }
}
