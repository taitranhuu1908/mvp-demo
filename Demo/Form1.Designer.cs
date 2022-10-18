namespace Demo
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
            this.Calculator = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumberOne = new System.Windows.Forms.TextBox();
            this.TxtNumberTwo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubtract = new System.Windows.Forms.Button();
            this.btnMultiple = new System.Windows.Forms.Button();
            this.btnDiviton = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AutoSize = true;
            this.Calculator.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Calculator.Location = new System.Drawing.Point(118, 9);
            this.Calculator.Name = "Calculator";
            this.Calculator.Size = new System.Drawing.Size(124, 32);
            this.Calculator.TabIndex = 0;
            this.Calculator.Text = "Calculator";
            this.Calculator.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number One";
            // 
            // TxtNumberOne
            // 
            this.TxtNumberOne.Location = new System.Drawing.Point(119, 62);
            this.TxtNumberOne.Name = "TxtNumberOne";
            this.TxtNumberOne.Size = new System.Drawing.Size(229, 23);
            this.TxtNumberOne.TabIndex = 2;
            // 
            // TxtNumberTwo
            // 
            this.TxtNumberTwo.Location = new System.Drawing.Point(119, 91);
            this.TxtNumberTwo.Name = "TxtNumberTwo";
            this.TxtNumberTwo.Size = new System.Drawing.Size(229, 23);
            this.TxtNumberTwo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number Two";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(127, 178);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(50, 50);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubtract
            // 
            this.btnSubtract.Location = new System.Drawing.Point(183, 178);
            this.btnSubtract.Name = "btnSubtract";
            this.btnSubtract.Size = new System.Drawing.Size(50, 50);
            this.btnSubtract.TabIndex = 6;
            this.btnSubtract.Text = "-";
            this.btnSubtract.UseVisualStyleBackColor = true;
            this.btnSubtract.Click += new System.EventHandler(this.btnSubtract_Click);
            // 
            // btnMultiple
            // 
            this.btnMultiple.Location = new System.Drawing.Point(239, 178);
            this.btnMultiple.Name = "btnMultiple";
            this.btnMultiple.Size = new System.Drawing.Size(50, 50);
            this.btnMultiple.TabIndex = 7;
            this.btnMultiple.Text = "*";
            this.btnMultiple.UseVisualStyleBackColor = true;
            this.btnMultiple.Click += new System.EventHandler(this.btnMultiple_Click);
            // 
            // btnDiviton
            // 
            this.btnDiviton.Location = new System.Drawing.Point(295, 178);
            this.btnDiviton.Name = "btnDiviton";
            this.btnDiviton.Size = new System.Drawing.Size(50, 50);
            this.btnDiviton.TabIndex = 8;
            this.btnDiviton.Text = "/";
            this.btnDiviton.UseVisualStyleBackColor = true;
            this.btnDiviton.Click += new System.EventHandler(this.btnDiviton_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(119, 128);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(229, 23);
            this.TxtResult.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 279);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDiviton);
            this.Controls.Add(this.btnMultiple);
            this.Controls.Add(this.btnSubtract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.TxtNumberTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TxtNumberOne);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Calculator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Calculator;
        private Label label1;
        private TextBox TxtNumberOne;
        private TextBox TxtNumberTwo;
        private Label label2;
        private Button btnAdd;
        private Button btnSubtract;
        private Button btnMultiple;
        private Button btnDiviton;
        private TextBox TxtResult;
        private Label label3;
        //private Label TxtResult;
    }
}