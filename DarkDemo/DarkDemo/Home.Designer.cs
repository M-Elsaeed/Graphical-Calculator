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
            this.button5 = new System.Windows.Forms.Button();
            this.arithmeticBtn = new System.Windows.Forms.Button();
            this.closeBtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mainTxt = new System.Windows.Forms.Label();
            this.graphBtn = new System.Windows.Forms.Button();
            this.matrixBtn = new System.Windows.Forms.Button();
            this.calculusBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(122, 450);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(90, 38);
            this.button5.TabIndex = 4;
            this.button5.Text = "Week";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // arithmeticBtn
            // 
            this.arithmeticBtn.FlatAppearance.BorderSize = 0;
            this.arithmeticBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.arithmeticBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arithmeticBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.arithmeticBtn.Image = ((System.Drawing.Image)(resources.GetObject("arithmeticBtn.Image")));
            this.arithmeticBtn.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.arithmeticBtn.Location = new System.Drawing.Point(67, 125);
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
            this.graphBtn.Location = new System.Drawing.Point(67, 477);
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
            this.matrixBtn.Location = new System.Drawing.Point(442, 125);
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
            this.calculusBtn.Location = new System.Drawing.Point(442, 477);
            this.calculusBtn.Name = "calculusBtn";
            this.calculusBtn.Size = new System.Drawing.Size(266, 283);
            this.calculusBtn.TabIndex = 9;
            this.calculusBtn.Text = "Calculus";
            this.calculusBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.calculusBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.calculusBtn.UseVisualStyleBackColor = true;
            this.calculusBtn.Click += new System.EventHandler(this.calculusBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.checkBox4);
            this.panel1.Controls.Add(this.checkBox3);
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Location = new System.Drawing.Point(798, 82);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 706);
            this.panel1.TabIndex = 10;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 706);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.Location = new System.Drawing.Point(101, 358);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(120, 20);
            this.checkBox4.TabIndex = 6;
            this.checkBox4.Text = "C# UI Academy";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.Location = new System.Drawing.Point(101, 331);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(157, 20);
            this.checkBox3.TabIndex = 7;
            this.checkBox3.Text = "By SaLaaR HuSceyN";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.Location = new System.Drawing.Point(101, 304);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 20);
            this.checkBox2.TabIndex = 8;
            this.checkBox2.Text = "C# UI Designing";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(101, 277);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(204, 20);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "Lorem Ispum is a dummy Text";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = "Options";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1250, 800);
            this.Controls.Add(this.panel1);
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button arithmeticBtn;
        private System.Windows.Forms.Button closeBtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label mainTxt;
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.Button matrixBtn;
        private System.Windows.Forms.Button calculusBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Splitter splitter1;
    }
}

