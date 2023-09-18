namespace Application_Calculator
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
            txtBoxInput1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtBoxInput2 = new TextBox();
            cbOperator = new ComboBox();
            label3 = new Label();
            lblDisplayTotal = new Label();
            btnEqual = new Button();
            SuspendLayout();
            // 
            // txtBoxInput1
            // 
            txtBoxInput1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput1.Location = new Point(212, 30);
            txtBoxInput1.Name = "txtBoxInput1";
            txtBoxInput1.Size = new Size(108, 27);
            txtBoxInput1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(164, 18);
            label1.TabIndex = 1;
            label1.Text = "Enter first number:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 101);
            label2.Name = "label2";
            label2.Size = new Size(188, 18);
            label2.TabIndex = 3;
            label2.Text = "Enter second number:";
            // 
            // txtBoxInput2
            // 
            txtBoxInput2.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxInput2.Location = new Point(212, 92);
            txtBoxInput2.Name = "txtBoxInput2";
            txtBoxInput2.Size = new Size(106, 27);
            txtBoxInput2.TabIndex = 2;
            // 
            // cbOperator
            // 
            cbOperator.FormattingEnabled = true;
            cbOperator.Items.AddRange(new object[] { "+", "-", "*", "/" });
            cbOperator.Location = new Point(261, 63);
            cbOperator.Name = "cbOperator";
            cbOperator.Size = new Size(57, 23);
            cbOperator.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 138);
            label3.Name = "label3";
            label3.Size = new Size(74, 18);
            label3.TabIndex = 5;
            label3.Text = "Answer:";
            // 
            // lblDisplayTotal
            // 
            lblDisplayTotal.AutoSize = true;
            lblDisplayTotal.Font = new Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDisplayTotal.Location = new Point(212, 138);
            lblDisplayTotal.Name = "lblDisplayTotal";
            lblDisplayTotal.Size = new Size(108, 18);
            lblDisplayTotal.TabIndex = 6;
            lblDisplayTotal.Text = "__________";
            // 
            // btnEqual
            // 
            btnEqual.Location = new Point(213, 176);
            btnEqual.Name = "btnEqual";
            btnEqual.Size = new Size(105, 23);
            btnEqual.TabIndex = 7;
            btnEqual.Text = "button1";
            btnEqual.UseVisualStyleBackColor = true;
            btnEqual.Click += btnEqual_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(330, 206);
            Controls.Add(btnEqual);
            Controls.Add(lblDisplayTotal);
            Controls.Add(label3);
            Controls.Add(cbOperator);
            Controls.Add(label2);
            Controls.Add(txtBoxInput2);
            Controls.Add(label1);
            Controls.Add(txtBoxInput1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBoxInput1;
        private Label label1;
        private Label label2;
        private TextBox txtBoxInput2;
        private ComboBox cbOperator;
        private Label label3;
        private Label lblDisplayTotal;
        private Button btnEqual;
    }
}