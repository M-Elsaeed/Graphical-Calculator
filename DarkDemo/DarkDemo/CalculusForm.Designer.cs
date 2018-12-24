namespace DarkDemo
{
    partial class CalculusForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculusForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.Button();
            this.mainTxt = new System.Windows.Forms.Label();
            this.closeBtn = new System.Windows.Forms.Button();
            this.differentiationBtn = new System.Windows.Forms.Button();
            this.differentiationPnl = new System.Windows.Forms.Panel();
            this.limitTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.resultLbl = new System.Windows.Forms.Label();
            this.differentiateBtn = new System.Windows.Forms.Button();
            this.difeqnTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.integrationBtn = new System.Windows.Forms.Button();
            this.integrationPnl = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.toTxtBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fromTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.intResultLbl = new System.Windows.Forms.Label();
            this.integrateBtn = new System.Windows.Forms.Button();
            this.intequTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.differentiationPnl.SuspendLayout();
            this.integrationPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.homeBtn);
            this.panel3.Controls.Add(this.mainTxt);
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 76);
            this.panel3.TabIndex = 7;
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(2, 3);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(93, 70);
            this.homeBtn.TabIndex = 6;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // mainTxt
            // 
            this.mainTxt.AutoSize = true;
            this.mainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTxt.Location = new System.Drawing.Point(100, 3);
            this.mainTxt.Name = "mainTxt";
            this.mainTxt.Size = new System.Drawing.Size(286, 73);
            this.mainTxt.TabIndex = 3;
            this.mainTxt.Text = "Calculas";
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1193, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 26);
            this.closeBtn.TabIndex = 5;
            this.closeBtn.Text = " X ";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // differentiationBtn
            // 
            this.differentiationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.differentiationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentiationBtn.Location = new System.Drawing.Point(132, 191);
            this.differentiationBtn.Name = "differentiationBtn";
            this.differentiationBtn.Size = new System.Drawing.Size(214, 70);
            this.differentiationBtn.TabIndex = 8;
            this.differentiationBtn.Text = "Differentiation";
            this.differentiationBtn.UseVisualStyleBackColor = true;
            this.differentiationBtn.Click += new System.EventHandler(this.differentiationBtn_Click);
            // 
            // differentiationPnl
            // 
            this.differentiationPnl.Controls.Add(this.limitTxtBox);
            this.differentiationPnl.Controls.Add(this.label4);
            this.differentiationPnl.Controls.Add(this.splitter2);
            this.differentiationPnl.Controls.Add(this.resultLbl);
            this.differentiationPnl.Controls.Add(this.differentiateBtn);
            this.differentiationPnl.Controls.Add(this.difeqnTextBox);
            this.differentiationPnl.Controls.Add(this.label1);
            this.differentiationPnl.Location = new System.Drawing.Point(487, 82);
            this.differentiationPnl.Name = "differentiationPnl";
            this.differentiationPnl.Size = new System.Drawing.Size(751, 706);
            this.differentiationPnl.TabIndex = 9;
            // 
            // limitTxtBox
            // 
            this.limitTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.limitTxtBox.Location = new System.Drawing.Point(410, 193);
            this.limitTxtBox.Name = "limitTxtBox";
            this.limitTxtBox.Size = new System.Drawing.Size(66, 49);
            this.limitTxtBox.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(276, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 42);
            this.label4.TabIndex = 15;
            this.label4.Text = "At X :";
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 706);
            this.splitter2.TabIndex = 14;
            this.splitter2.TabStop = false;
            // 
            // resultLbl
            // 
            this.resultLbl.AutoSize = true;
            this.resultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.resultLbl.Location = new System.Drawing.Point(371, 582);
            this.resultLbl.Name = "resultLbl";
            this.resultLbl.Size = new System.Drawing.Size(0, 13);
            this.resultLbl.TabIndex = 12;
            // 
            // differentiateBtn
            // 
            this.differentiateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.differentiateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.differentiateBtn.Location = new System.Drawing.Point(283, 364);
            this.differentiateBtn.Name = "differentiateBtn";
            this.differentiateBtn.Size = new System.Drawing.Size(214, 70);
            this.differentiateBtn.TabIndex = 11;
            this.differentiateBtn.Text = "Differentiate";
            this.differentiateBtn.UseVisualStyleBackColor = true;
            this.differentiateBtn.Click += new System.EventHandler(this.differentiateBtn_Click);
            // 
            // difeqnTextBox
            // 
            this.difeqnTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.difeqnTextBox.Location = new System.Drawing.Point(233, 92);
            this.difeqnTextBox.Name = "difeqnTextBox";
            this.difeqnTextBox.Size = new System.Drawing.Size(485, 49);
            this.difeqnTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Equation :";
            // 
            // integrationBtn
            // 
            this.integrationBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.integrationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrationBtn.Location = new System.Drawing.Point(132, 551);
            this.integrationBtn.Name = "integrationBtn";
            this.integrationBtn.Size = new System.Drawing.Size(214, 70);
            this.integrationBtn.TabIndex = 10;
            this.integrationBtn.Text = "Integration";
            this.integrationBtn.UseVisualStyleBackColor = true;
            this.integrationBtn.Click += new System.EventHandler(this.integrationBtn_Click);
            // 
            // integrationPnl
            // 
            this.integrationPnl.Controls.Add(this.label7);
            this.integrationPnl.Controls.Add(this.toTxtBox);
            this.integrationPnl.Controls.Add(this.label6);
            this.integrationPnl.Controls.Add(this.fromTxtBox);
            this.integrationPnl.Controls.Add(this.label5);
            this.integrationPnl.Controls.Add(this.splitter1);
            this.integrationPnl.Controls.Add(this.intResultLbl);
            this.integrationPnl.Controls.Add(this.integrateBtn);
            this.integrationPnl.Controls.Add(this.intequTxtBox);
            this.integrationPnl.Controls.Add(this.label3);
            this.integrationPnl.Location = new System.Drawing.Point(487, 82);
            this.integrationPnl.Name = "integrationPnl";
            this.integrationPnl.Size = new System.Drawing.Size(751, 706);
            this.integrationPnl.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 42);
            this.label7.TabIndex = 18;
            this.label7.Text = "Limits";
            // 
            // toTxtBox
            // 
            this.toTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.toTxtBox.Location = new System.Drawing.Point(624, 282);
            this.toTxtBox.Name = "toTxtBox";
            this.toTxtBox.Size = new System.Drawing.Size(77, 49);
            this.toTxtBox.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(536, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 42);
            this.label6.TabIndex = 16;
            this.label6.Text = "To :";
            // 
            // fromTxtBox
            // 
            this.fromTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.fromTxtBox.Location = new System.Drawing.Point(242, 282);
            this.fromTxtBox.Name = "fromTxtBox";
            this.fromTxtBox.Size = new System.Drawing.Size(77, 49);
            this.fromTxtBox.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(112, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 42);
            this.label5.TabIndex = 14;
            this.label5.Text = "From :";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 706);
            this.splitter1.TabIndex = 13;
            this.splitter1.TabStop = false;
            // 
            // intResultLbl
            // 
            this.intResultLbl.AutoSize = true;
            this.intResultLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.intResultLbl.Location = new System.Drawing.Point(407, 582);
            this.intResultLbl.Name = "intResultLbl";
            this.intResultLbl.Size = new System.Drawing.Size(0, 13);
            this.intResultLbl.TabIndex = 12;
            // 
            // integrateBtn
            // 
            this.integrateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.integrateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.integrateBtn.Location = new System.Drawing.Point(339, 393);
            this.integrateBtn.Name = "integrateBtn";
            this.integrateBtn.Size = new System.Drawing.Size(214, 70);
            this.integrateBtn.TabIndex = 11;
            this.integrateBtn.Text = "integrate";
            this.integrateBtn.UseVisualStyleBackColor = true;
            this.integrateBtn.Click += new System.EventHandler(this.integrateBtn_Click);
            // 
            // intequTxtBox
            // 
            this.intequTxtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F);
            this.intequTxtBox.Location = new System.Drawing.Point(233, 92);
            this.intequTxtBox.Name = "intequTxtBox";
            this.intequTxtBox.Size = new System.Drawing.Size(485, 49);
            this.intequTxtBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Equation :";
            // 
            // CalculusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.integrationPnl);
            this.Controls.Add(this.integrationBtn);
            this.Controls.Add(this.differentiationPnl);
            this.Controls.Add(this.differentiationBtn);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalculusForm";
            this.Text = "Calculus";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.differentiationPnl.ResumeLayout(false);
            this.differentiationPnl.PerformLayout();
            this.integrationPnl.ResumeLayout(false);
            this.integrationPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mainTxt;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Button differentiationBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Panel differentiationPnl;
        private System.Windows.Forms.Button integrationBtn;
        private System.Windows.Forms.TextBox difeqnTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLbl;
        private System.Windows.Forms.Button differentiateBtn;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Panel integrationPnl;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label intResultLbl;
        private System.Windows.Forms.Button integrateBtn;
        private System.Windows.Forms.TextBox intequTxtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox limitTxtBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox toTxtBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fromTxtBox;
        private System.Windows.Forms.Label label5;
    }
}