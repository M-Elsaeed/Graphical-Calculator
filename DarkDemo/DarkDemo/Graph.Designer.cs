namespace DarkDemo
{
    partial class Graph
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Graph));
            this.graphBtn = new System.Windows.Forms.Button();
            this.eqnText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.graphPnl = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fromText = new System.Windows.Forms.TextBox();
            this.toText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // graphBtn
            // 
            this.graphBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.graphBtn.FlatAppearance.BorderSize = 5;
            this.graphBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.graphBtn.ForeColor = System.Drawing.Color.White;
            this.graphBtn.Location = new System.Drawing.Point(772, 39);
            this.graphBtn.Name = "graphBtn";
            this.graphBtn.Size = new System.Drawing.Size(135, 77);
            this.graphBtn.TabIndex = 2;
            this.graphBtn.Text = "Graph Equation";
            this.graphBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.graphBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.graphBtn.UseVisualStyleBackColor = true;
            this.graphBtn.Click += new System.EventHandler(this.graphBtn_Click);
            // 
            // eqnText
            // 
            this.eqnText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eqnText.Location = new System.Drawing.Point(205, 49);
            this.eqnText.Name = "eqnText";
            this.eqnText.Size = new System.Drawing.Size(168, 39);
            this.eqnText.TabIndex = 13;
            this.eqnText.Text = "In terms of X";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 14;
            this.label1.Text = "Y = ";
            // 
            // graphPnl
            // 
            this.graphPnl.Location = new System.Drawing.Point(12, 135);
            this.graphPnl.Name = "graphPnl";
            this.graphPnl.Size = new System.Drawing.Size(895, 472);
            this.graphPnl.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(596, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "To";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(12, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 79);
            this.button1.TabIndex = 2;
            this.button1.Text = "Home";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fromText
            // 
            this.fromText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromText.Location = new System.Drawing.Point(490, 50);
            this.fromText.Name = "fromText";
            this.fromText.Size = new System.Drawing.Size(100, 39);
            this.fromText.TabIndex = 17;
            // 
            // toText
            // 
            this.toText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toText.Location = new System.Drawing.Point(652, 53);
            this.toText.Name = "toText";
            this.toText.Size = new System.Drawing.Size(100, 39);
            this.toText.TabIndex = 18;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1680, 1050);
            this.Controls.Add(this.toText);
            this.Controls.Add(this.fromText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.graphPnl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.eqnText);
            this.Controls.Add(this.graphBtn);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graph";
            this.Text = "Graph";
            this.Load += new System.EventHandler(this.Graph_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button graphBtn;
        private System.Windows.Forms.TextBox eqnText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel graphPnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fromText;
        private System.Windows.Forms.TextBox toText;
    }
}