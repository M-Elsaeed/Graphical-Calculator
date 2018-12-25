namespace DarkDemo
{
    partial class ExponentialForm
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
            this.mainTxt = new System.Windows.Forms.Label();
            this.donebtn = new System.Windows.Forms.Button();
            this.angleTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // mainTxt
            // 
            this.mainTxt.AutoSize = true;
            this.mainTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTxt.Location = new System.Drawing.Point(22, 23);
            this.mainTxt.Name = "mainTxt";
            this.mainTxt.Size = new System.Drawing.Size(357, 39);
            this.mainTxt.TabIndex = 45;
            this.mainTxt.Text = "Please entre number";
            // 
            // donebtn
            // 
            this.donebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.donebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donebtn.Location = new System.Drawing.Point(117, 141);
            this.donebtn.Name = "donebtn";
            this.donebtn.Size = new System.Drawing.Size(158, 39);
            this.donebtn.TabIndex = 44;
            this.donebtn.Text = "DONE !";
            this.donebtn.UseVisualStyleBackColor = true;
            this.donebtn.Click += new System.EventHandler(this.donebtn_Click_1);
            // 
            // angleTxtBox
            // 
            this.angleTxtBox.Location = new System.Drawing.Point(153, 89);
            this.angleTxtBox.Name = "angleTxtBox";
            this.angleTxtBox.Size = new System.Drawing.Size(92, 20);
            this.angleTxtBox.TabIndex = 43;
            this.angleTxtBox.TextChanged += new System.EventHandler(this.angleTxtBox_TextChanged_1);
            // 
            // ExponentialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.mainTxt);
            this.Controls.Add(this.donebtn);
            this.Controls.Add(this.angleTxtBox);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExponentialForm";
            this.Text = "ExponentialForm";
            this.Load += new System.EventHandler(this.ExponentialForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mainTxt;
        private System.Windows.Forms.Button donebtn;
        private System.Windows.Forms.TextBox angleTxtBox;
    }
}