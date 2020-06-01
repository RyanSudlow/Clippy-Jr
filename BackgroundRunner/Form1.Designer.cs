namespace BackgroundRunner
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
            this.SqlSplitBtn = new System.Windows.Forms.Button();
            this.JSONBtn = new System.Windows.Forms.Button();
            this.XMLBtn = new System.Windows.Forms.Button();
            this.NumSplitBtn = new System.Windows.Forms.Button();
            this.StringSplitBtn = new System.Windows.Forms.Button();
            this.SqlQueryBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SqlSplitBtn
            // 
            this.SqlSplitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SqlSplitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SqlSplitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlSplitBtn.ForeColor = System.Drawing.Color.White;
            this.SqlSplitBtn.Location = new System.Drawing.Point(0, 0);
            this.SqlSplitBtn.Name = "SqlSplitBtn";
            this.SqlSplitBtn.Size = new System.Drawing.Size(140, 30);
            this.SqlSplitBtn.TabIndex = 0;
            this.SqlSplitBtn.Text = "SQL Split";
            this.SqlSplitBtn.UseVisualStyleBackColor = false;
            this.SqlSplitBtn.Click += new System.EventHandler(this.SqlSplitBtn_Click);
            // 
            // JSONBtn
            // 
            this.JSONBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JSONBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.JSONBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.JSONBtn.ForeColor = System.Drawing.Color.White;
            this.JSONBtn.Location = new System.Drawing.Point(0, 30);
            this.JSONBtn.Name = "JSONBtn";
            this.JSONBtn.Size = new System.Drawing.Size(140, 30);
            this.JSONBtn.TabIndex = 1;
            this.JSONBtn.Text = "JSON";
            this.JSONBtn.UseVisualStyleBackColor = false;
            this.JSONBtn.Click += new System.EventHandler(this.JSONBtn_Click);
            // 
            // XMLBtn
            // 
            this.XMLBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.XMLBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.XMLBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.XMLBtn.ForeColor = System.Drawing.Color.White;
            this.XMLBtn.Location = new System.Drawing.Point(0, 60);
            this.XMLBtn.Name = "XMLBtn";
            this.XMLBtn.Size = new System.Drawing.Size(140, 30);
            this.XMLBtn.TabIndex = 2;
            this.XMLBtn.Text = "XML";
            this.XMLBtn.UseVisualStyleBackColor = false;
            this.XMLBtn.Click += new System.EventHandler(this.XMLBtn_Click);
            // 
            // NumSplitBtn
            // 
            this.NumSplitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NumSplitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.NumSplitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NumSplitBtn.ForeColor = System.Drawing.Color.White;
            this.NumSplitBtn.Location = new System.Drawing.Point(0, 120);
            this.NumSplitBtn.Name = "NumSplitBtn";
            this.NumSplitBtn.Size = new System.Drawing.Size(70, 39);
            this.NumSplitBtn.TabIndex = 4;
            this.NumSplitBtn.Text = "(1,2)";
            this.NumSplitBtn.UseVisualStyleBackColor = false;
            this.NumSplitBtn.Click += new System.EventHandler(this.NumSplitBtn_Click);
            // 
            // StringSplitBtn
            // 
            this.StringSplitBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StringSplitBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.StringSplitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StringSplitBtn.ForeColor = System.Drawing.Color.White;
            this.StringSplitBtn.Location = new System.Drawing.Point(70, 120);
            this.StringSplitBtn.Name = "StringSplitBtn";
            this.StringSplitBtn.Size = new System.Drawing.Size(70, 39);
            this.StringSplitBtn.TabIndex = 5;
            this.StringSplitBtn.Text = "(\'1\',\'2\')";
            this.StringSplitBtn.UseVisualStyleBackColor = false;
            this.StringSplitBtn.Click += new System.EventHandler(this.StringSplitBtn_Click);
            // 
            // SqlQueryBtn
            // 
            this.SqlQueryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SqlQueryBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.SqlQueryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SqlQueryBtn.ForeColor = System.Drawing.Color.White;
            this.SqlQueryBtn.Location = new System.Drawing.Point(0, 90);
            this.SqlQueryBtn.Name = "SqlQueryBtn";
            this.SqlQueryBtn.Size = new System.Drawing.Size(140, 30);
            this.SqlQueryBtn.TabIndex = 3;
            this.SqlQueryBtn.Text = "SQL Query";
            this.SqlQueryBtn.UseVisualStyleBackColor = false;
            this.SqlQueryBtn.Click += new System.EventHandler(this.SqlQueryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(140, 160);
            this.Controls.Add(this.SqlQueryBtn);
            this.Controls.Add(this.StringSplitBtn);
            this.Controls.Add(this.NumSplitBtn);
            this.Controls.Add(this.XMLBtn);
            this.Controls.Add(this.JSONBtn);
            this.Controls.Add(this.SqlSplitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SqlSplitBtn;
        private System.Windows.Forms.Button JSONBtn;
        private System.Windows.Forms.Button XMLBtn;
        private System.Windows.Forms.Button NumSplitBtn;
        private System.Windows.Forms.Button StringSplitBtn;
        private System.Windows.Forms.Button SqlQueryBtn;
    }
}

