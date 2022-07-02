namespace HWIDCheckerForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.logo_text = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.copy = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(246)))));
            this.panel1.Controls.Add(this.logo_text);
            this.panel1.Controls.Add(this.close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 36);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouse_Down);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouse_Move);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouse_Up);
            // 
            // logo_text
            // 
            this.logo_text.AutoSize = true;
            this.logo_text.BackColor = System.Drawing.Color.Transparent;
            this.logo_text.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logo_text.ForeColor = System.Drawing.Color.White;
            this.logo_text.Location = new System.Drawing.Point(3, 0);
            this.logo_text.Name = "logo_text";
            this.logo_text.Size = new System.Drawing.Size(166, 35);
            this.logo_text.TabIndex = 3;
            this.logo_text.Text = "@heitorrosa";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.Font = new System.Drawing.Font("Segoe UI Black", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(693, 1);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(33, 35);
            this.close.TabIndex = 1;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // copy
            // 
            this.copy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(246)))));
            this.copy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(46)))), ((int)(((byte)(246)))));
            this.copy.Image = global::HWIDCheckerForms.Properties.Resources.image;
            this.copy.Location = new System.Drawing.Point(608, 93);
            this.copy.Name = "copy";
            this.copy.Size = new System.Drawing.Size(44, 39);
            this.copy.TabIndex = 1;
            this.copy.UseVisualStyleBackColor = false;
            this.copy.Click += new System.EventHandler(this.copy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(55, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "HWID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(47)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(726, 209);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.copy);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label logo_text;
        private System.Windows.Forms.Button copy;
        private System.Windows.Forms.Label label1;
    }
}

