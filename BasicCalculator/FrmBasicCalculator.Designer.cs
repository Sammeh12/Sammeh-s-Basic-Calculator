namespace BasicCalculator
{
    partial class FrmBasicCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBasicCalculator));
            this.lblBasicCalculator = new System.Windows.Forms.Label();
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.cbOperator = new System.Windows.Forms.ComboBox();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBasicCalculator
            // 
            this.lblBasicCalculator.AutoSize = true;
            this.lblBasicCalculator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicCalculator.Location = new System.Drawing.Point(20, 21);
            this.lblBasicCalculator.Name = "lblBasicCalculator";
            this.lblBasicCalculator.Size = new System.Drawing.Size(237, 24);
            this.lblBasicCalculator.TabIndex = 0;
            this.lblBasicCalculator.Text = "Sammeh\'s Basic Calculator";
            // 
            // tbInput1
            // 
            this.tbInput1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput1.Location = new System.Drawing.Point(21, 55);
            this.tbInput1.Multiline = true;
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInput1.Size = new System.Drawing.Size(242, 40);
            this.tbInput1.TabIndex = 1;
            this.tbInput1.Text = "0";
            this.tbInput1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbOperator
            // 
            this.cbOperator.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbOperator.FormattingEnabled = true;
            this.cbOperator.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.cbOperator.Location = new System.Drawing.Point(115, 101);
            this.cbOperator.Name = "cbOperator";
            this.cbOperator.Size = new System.Drawing.Size(55, 28);
            this.cbOperator.TabIndex = 2;
            // 
            // tbInput2
            // 
            this.tbInput2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInput2.Location = new System.Drawing.Point(21, 135);
            this.tbInput2.Multiline = true;
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbInput2.Size = new System.Drawing.Size(242, 40);
            this.tbInput2.TabIndex = 3;
            this.tbInput2.Text = "0";
            this.tbInput2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbResults
            // 
            this.tbResults.BackColor = System.Drawing.SystemColors.MenuText;
            this.tbResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbResults.ForeColor = System.Drawing.Color.Lime;
            this.tbResults.Location = new System.Drawing.Point(21, 190);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbResults.Size = new System.Drawing.Size(242, 80);
            this.tbResults.TabIndex = 4;
            // 
            // btnCompute
            // 
            this.btnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompute.Location = new System.Drawing.Point(100, 286);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(85, 30);
            this.btnCompute.TabIndex = 5;
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            // 
            // FrmBasicCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 329);
            this.Controls.Add(this.btnCompute);
            this.Controls.Add(this.tbResults);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.cbOperator);
            this.Controls.Add(this.tbInput1);
            this.Controls.Add(this.lblBasicCalculator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmBasicCalculator";
            this.Text = "Sammeh\'s Basic Calculator";
            this.Load += new System.EventHandler(this.FrmBasicCalculator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasicCalculator;
        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.ComboBox cbOperator;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnCompute;
    }
}

