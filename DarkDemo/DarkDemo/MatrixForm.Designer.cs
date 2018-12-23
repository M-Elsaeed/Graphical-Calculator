namespace DarkDemo
{
    partial class MatrixForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatrixForm));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.multiplyBtn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.plusBtn = new System.Windows.Forms.Button();
            this.homeBtn = new System.Windows.Forms.Button();
            this.rowTxtBox = new System.Windows.Forms.TextBox();
            this.rowLbl = new System.Windows.Forms.Button();
            this.columnLbl = new System.Windows.Forms.Button();
            this.columnTxtBox = new System.Windows.Forms.TextBox();
            this.makeMatrix = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.splitter2 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 76);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 79);
            this.label2.TabIndex = 3;
            this.label2.Text = "Matrix";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.multiplyBtn);
            this.panel1.Controls.Add(this.minusBtn);
            this.panel1.Controls.Add(this.plusBtn);
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 724);
            this.panel1.TabIndex = 2;
            // 
            // multiplyBtn
            // 
            this.multiplyBtn.FlatAppearance.BorderSize = 0;
            this.multiplyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplyBtn.ForeColor = System.Drawing.Color.White;
            this.multiplyBtn.Image = ((System.Drawing.Image)(resources.GetObject("multiplyBtn.Image")));
            this.multiplyBtn.Location = new System.Drawing.Point(0, 534);
            this.multiplyBtn.Name = "multiplyBtn";
            this.multiplyBtn.Size = new System.Drawing.Size(140, 187);
            this.multiplyBtn.TabIndex = 7;
            this.multiplyBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.multiplyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.multiplyBtn.UseVisualStyleBackColor = true;
            this.multiplyBtn.Click += new System.EventHandler(this.multiplyBtn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.FlatAppearance.BorderSize = 0;
            this.minusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.ForeColor = System.Drawing.Color.White;
            this.minusBtn.Image = ((System.Drawing.Image)(resources.GetObject("minusBtn.Image")));
            this.minusBtn.Location = new System.Drawing.Point(0, 350);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(140, 178);
            this.minusBtn.TabIndex = 6;
            this.minusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.minusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // plusBtn
            // 
            this.plusBtn.FlatAppearance.BorderSize = 0;
            this.plusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusBtn.ForeColor = System.Drawing.Color.White;
            this.plusBtn.Image = ((System.Drawing.Image)(resources.GetObject("plusBtn.Image")));
            this.plusBtn.Location = new System.Drawing.Point(0, 154);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(140, 190);
            this.plusBtn.TabIndex = 5;
            this.plusBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.plusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.FlatAppearance.BorderSize = 0;
            this.homeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.homeBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.homeBtn.ForeColor = System.Drawing.Color.White;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(0, 0);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(143, 155);
            this.homeBtn.TabIndex = 9;
            this.homeBtn.Text = "Home";
            this.homeBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.homeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.homeBtn.UseVisualStyleBackColor = true;
            // 
            // rowTxtBox
            // 
            this.rowTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.rowTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rowTxtBox.Location = new System.Drawing.Point(382, 132);
            this.rowTxtBox.Name = "rowTxtBox";
            this.rowTxtBox.Size = new System.Drawing.Size(62, 20);
            this.rowTxtBox.TabIndex = 1;
            // 
            // rowLbl
            // 
            this.rowLbl.FlatAppearance.BorderSize = 0;
            this.rowLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rowLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.rowLbl.Location = new System.Drawing.Point(255, 128);
            this.rowLbl.Name = "rowLbl";
            this.rowLbl.Size = new System.Drawing.Size(72, 27);
            this.rowLbl.TabIndex = 5;
            this.rowLbl.Text = "Row";
            this.rowLbl.UseVisualStyleBackColor = true;
            // 
            // columnLbl
            // 
            this.columnLbl.FlatAppearance.BorderSize = 0;
            this.columnLbl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnLbl.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.columnLbl.Location = new System.Drawing.Point(675, 128);
            this.columnLbl.Name = "columnLbl";
            this.columnLbl.Size = new System.Drawing.Size(72, 27);
            this.columnLbl.TabIndex = 6;
            this.columnLbl.Text = "Column";
            this.columnLbl.UseVisualStyleBackColor = true;
            // 
            // columnTxtBox
            // 
            this.columnTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.columnTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.columnTxtBox.Location = new System.Drawing.Point(809, 132);
            this.columnTxtBox.Name = "columnTxtBox";
            this.columnTxtBox.Size = new System.Drawing.Size(62, 20);
            this.columnTxtBox.TabIndex = 2;
            // 
            // makeMatrix
            // 
            this.makeMatrix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.makeMatrix.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.makeMatrix.Location = new System.Drawing.Point(991, 122);
            this.makeMatrix.Name = "makeMatrix";
            this.makeMatrix.Size = new System.Drawing.Size(153, 38);
            this.makeMatrix.TabIndex = 3;
            this.makeMatrix.Text = "Make Matrix";
            this.makeMatrix.UseVisualStyleBackColor = true;
            this.makeMatrix.Click += new System.EventHandler(this.makeMatrix_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(991, 312);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(153, 38);
            this.saveBtn.TabIndex = 4;
            this.saveBtn.Text = "Save Matrix";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // splitter2
            // 
            this.splitter2.AutoSize = true;
            this.splitter2.Location = new System.Drawing.Point(182, 183);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(931, 13);
            this.splitter2.TabIndex = 9;
            this.splitter2.Text = "_________________________________________________________________________________" +
    "_________________________________________________________________________";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.splitter1.Location = new System.Drawing.Point(140, 76);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 724);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBtn.Location = new System.Drawing.Point(1143, 12);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(45, 26);
            this.closeBtn.TabIndex = 11;
            this.closeBtn.Text = " X ";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MatrixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.makeMatrix);
            this.Controls.Add(this.columnTxtBox);
            this.Controls.Add(this.columnLbl);
            this.Controls.Add(this.rowLbl);
            this.Controls.Add(this.rowTxtBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MatrixForm";
            this.Text = "Matrix";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button multiplyBtn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rowTxtBox;
        private System.Windows.Forms.Button rowLbl;
        private System.Windows.Forms.Button columnLbl;
        private System.Windows.Forms.TextBox columnTxtBox;
        private System.Windows.Forms.Button makeMatrix;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label splitter2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Button closeBtn;
    }
}