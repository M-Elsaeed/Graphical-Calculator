namespace DarkDemo
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.arithmeticBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainTxt = new System.Windows.Forms.Label();
            this.graphBtn = new System.Windows.Forms.Button();
            this.matrixBtn = new System.Windows.Forms.Button();
            this.calculusBtn = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // arithmeticBtn
            // 
            this.arithmeticBtn.FlatAppearance.BorderSize = 0;
            this.arithmeticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arithmeticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arithmeticBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.arithmeticBtn.Image = ((System.Drawing.Image)(resources.GetObject("arithmeticBtn.Image")));
            this.arithmeticBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.arithmeticBtn.Location = new System.Drawing.Point(166, 125);
            this.arithmeticBtn.Name = "arithmeticBtn";
            this.arithmeticBtn.Size = new System.Drawing.Size(266, 283);
            this.arithmeticBtn.TabIndex = 1;
            this.arithmeticBtn.Text = "Arithmetic";
            this.arithmeticBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.arithmeticBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.arithmeticBtn.UseVisualStyleBackColor = true;
            this.arithmeticBtn.Click += new System.EventHandler(this.arithmeticBtn_Click);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(180)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.mainTxt);
            this.panel3.Controls.Add(this.closeBtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1250, 76);
            this.panel3.TabIndex = 6;
            // 
            // mainTxt
            // 
            this.mainTxt.AutoSize = true;
            this.mainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTxt.Location = new System.Drawing.Point(3, 0);
            this.mainTxt.Name = "mainTxt";
            this.mainTxt.Size = new System.Drawing.Size(330, 73);
            this.mainTxt.TabIndex = 3;
            this.mainTxt.Text = "Sci-Graph";
            // 
            // graphBtn
            // 
            this.graphBtn.FlatAppearance.BorderSize = 0;
            this.graphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.graphBtn.Image = ((System.Drawing.Image)(resources.GetObject("graphBtn.Image")));
            this.graphBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.graphBtn.Location = new System.Drawing.Point(166, 477);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(266, 283);
            this.graphBtn.TabIndex = 7;
            this.graphBtn.Text = "Graph";
            this.graphBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.graphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // matrixBtn
            // 
            this.matrixBtn.FlatAppearance.BorderSize = 0;
            this.matrixBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.matrixBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matrixBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.matrixBtn.Image = ((System.Drawing.Image)(resources.GetObject("matrixBtn.Image")));
            this.matrixBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.matrixBtn.Location = new System.Drawing.Point(812, 125);
            this.matrixBtn.Name = "matrixBtn";
            this.matrixBtn.Size = new System.Drawing.Size(266, 283);
            this.matrixBtn.TabIndex = 8;
            this.matrixBtn.Text = "Matrix";
            this.matrixBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.matrixBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.matrixBtn.UseVisualStyleBackColor = true;
            this.matrixBtn.Click += new System.EventHandler(this.matrixBtn_Click);
            // 
            // calculusBtn
            // 
            this.calculusBtn.FlatAppearance.BorderSize = 0;
            this.calculusBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculusBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.calculusBtn.Image = ((System.Drawing.Image)(resources.GetObject("calculusBtn.Image")));
            this.calculusBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.calculusBtn.Location = new System.Drawing.Point(812, 477);
            this.calculusBtn.Name = "calculusBtn";
            this.calculusBtn.Size = new System.Drawing.Size(266, 283);
            this.calculusBtn.TabIndex = 9;
            this.calculusBtn.Text = "Calculus";
            this.calculusBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.calculusBtn.UseVisualStyleBackColor = true;
            this.calculusBtn.Click += new System.EventHandler(this.calculusBtn_Click);
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.calculusBtn);
            this.Controls.Add(this.matrixBtn);
            this.Controls.Add(this.graphBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.arithmeticBtn);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button arithmeticBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mainTxt;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button matrixBtn;
        private System.Windows.Forms.Button calculusBtn;
    }
}

