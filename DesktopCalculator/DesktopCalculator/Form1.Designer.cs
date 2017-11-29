namespace DesktopCalculator
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
            this.lblFirstNumber = new System.Windows.Forms.Label();
            this.lblSecondNumber = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.inptFirstNumber = new System.Windows.Forms.NumericUpDown();
            this.inptSecondNumber = new System.Windows.Forms.NumericUpDown();
            this.inptResult = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubstract = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFirstNumber
            // 
            this.lblFirstNumber.AutoSize = true;
            this.lblFirstNumber.Location = new System.Drawing.Point(39, 46);
            this.lblFirstNumber.Name = "lblFirstNumber";
            this.lblFirstNumber.Size = new System.Drawing.Size(51, 13);
            this.lblFirstNumber.TabIndex = 0;
            this.lblFirstNumber.Text = "Prvi broj: ";
            // 
            // lblSecondNumber
            // 
            this.lblSecondNumber.AutoSize = true;
            this.lblSecondNumber.Location = new System.Drawing.Point(39, 76);
            this.lblSecondNumber.Name = "lblSecondNumber";
            this.lblSecondNumber.Size = new System.Drawing.Size(58, 13);
            this.lblSecondNumber.TabIndex = 1;
            this.lblSecondNumber.Text = "Drugi broj: ";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(38, 132);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(52, 13);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Rezultat: ";
            // 
            // inptFirstNumber
            // 
            this.inptFirstNumber.Location = new System.Drawing.Point(96, 44);
            this.inptFirstNumber.Name = "inptFirstNumber";
            this.inptFirstNumber.Size = new System.Drawing.Size(72, 20);
            this.inptFirstNumber.TabIndex = 3;
            // 
            // inptSecondNumber
            // 
            this.inptSecondNumber.Location = new System.Drawing.Point(95, 74);
            this.inptSecondNumber.Name = "inptSecondNumber";
            this.inptSecondNumber.Size = new System.Drawing.Size(73, 20);
            this.inptSecondNumber.TabIndex = 4;
            // 
            // inptResult
            // 
            this.inptResult.Location = new System.Drawing.Point(92, 129);
            this.inptResult.Name = "inptResult";
            this.inptResult.ReadOnly = true;
            this.inptResult.Size = new System.Drawing.Size(76, 20);
            this.inptResult.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(239, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 24);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "(+) Zbrajanje";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubstract
            // 
            this.btnSubstract.Location = new System.Drawing.Point(238, 65);
            this.btnSubstract.Name = "btnSubstract";
            this.btnSubstract.Size = new System.Drawing.Size(106, 24);
            this.btnSubstract.TabIndex = 7;
            this.btnSubstract.Text = "(-) Oduzimanje";
            this.btnSubstract.UseVisualStyleBackColor = true;
            this.btnSubstract.Click += new System.EventHandler(this.btnSubstract_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(238, 95);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(106, 24);
            this.btnMultiply.TabIndex = 8;
            this.btnMultiply.Text = "(*) Množenje";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btnMultiply_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(239, 125);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(105, 24);
            this.btnDivide.TabIndex = 9;
            this.btnDivide.Text = "(/) Dijeljenje";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(381, 306);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubstract);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.inptResult);
            this.Controls.Add(this.inptSecondNumber);
            this.Controls.Add(this.inptFirstNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblSecondNumber);
            this.Controls.Add(this.lblFirstNumber);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Desktop Calculator";
            ((System.ComponentModel.ISupportInitialize)(this.inptFirstNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inptSecondNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFirstNumber;
        private System.Windows.Forms.Label lblSecondNumber;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown inptFirstNumber;
        private System.Windows.Forms.NumericUpDown inptSecondNumber;
        private System.Windows.Forms.TextBox inptResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubstract;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
    }
}

