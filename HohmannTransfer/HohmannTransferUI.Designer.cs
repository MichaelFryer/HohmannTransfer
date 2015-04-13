namespace Hohmann_Transfer
{
    partial class HohmannTransferUI
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
            this.txtInitOrb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFinalOrb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFirstBurn = new System.Windows.Forms.TextBox();
            this.txtSecondBurn = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbBody = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtInitOrb
            // 
            this.txtInitOrb.Location = new System.Drawing.Point(122, 89);
            this.txtInitOrb.MaxLength = 15;
            this.txtInitOrb.Name = "txtInitOrb";
            this.txtInitOrb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtInitOrb.Size = new System.Drawing.Size(100, 20);
            this.txtInitOrb.TabIndex = 0;
            this.txtInitOrb.Text = "80";
            this.txtInitOrb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Initial Orbit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Final Orbit";
            // 
            // txtFinalOrb
            // 
            this.txtFinalOrb.Location = new System.Drawing.Point(122, 115);
            this.txtFinalOrb.MaxLength = 15;
            this.txtFinalOrb.Name = "txtFinalOrb";
            this.txtFinalOrb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFinalOrb.Size = new System.Drawing.Size(100, 20);
            this.txtFinalOrb.TabIndex = 3;
            this.txtFinalOrb.Text = "200";
            this.txtFinalOrb.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(256, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hohmann Transfer Calculator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "First Burn Δv";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Second Burn Δv";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Total Δv";
            // 
            // txtFirstBurn
            // 
            this.txtFirstBurn.Location = new System.Drawing.Point(122, 186);
            this.txtFirstBurn.MaxLength = 15;
            this.txtFirstBurn.Name = "txtFirstBurn";
            this.txtFirstBurn.ReadOnly = true;
            this.txtFirstBurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFirstBurn.Size = new System.Drawing.Size(100, 20);
            this.txtFirstBurn.TabIndex = 8;
            this.txtFirstBurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSecondBurn
            // 
            this.txtSecondBurn.Location = new System.Drawing.Point(122, 212);
            this.txtSecondBurn.MaxLength = 15;
            this.txtSecondBurn.Name = "txtSecondBurn";
            this.txtSecondBurn.ReadOnly = true;
            this.txtSecondBurn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSecondBurn.Size = new System.Drawing.Size(100, 20);
            this.txtSecondBurn.TabIndex = 9;
            this.txtSecondBurn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(122, 238);
            this.txtTotal.MaxLength = 15;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 10;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(122, 146);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(229, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "km";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(228, 115);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(21, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "km";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(228, 189);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "m/s";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(228, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(25, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "m/s";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(228, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "m/s";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Celestial Body";
            // 
            // cbBody
            // 
            this.cbBody.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbBody.FormattingEnabled = true;
            this.cbBody.Location = new System.Drawing.Point(122, 62);
            this.cbBody.Name = "cbBody";
            this.cbBody.Size = new System.Drawing.Size(121, 21);
            this.cbBody.TabIndex = 18;
            // 
            // HohmannTransferUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(295, 275);
            this.Controls.Add(this.cbBody);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtSecondBurn);
            this.Controls.Add(this.txtFirstBurn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFinalOrb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtInitOrb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "HohmannTransferUI";
            this.Text = "Hohmann Transfer Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInitOrb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFinalOrb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFirstBurn;
        private System.Windows.Forms.TextBox txtSecondBurn;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cbBody;
    }
}

