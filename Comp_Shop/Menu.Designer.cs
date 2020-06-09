namespace Comp_Shop
{
    partial class Menu
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
            this.buttonCat = new System.Windows.Forms.Button();
            this.buttonProf = new System.Windows.Forms.Button();
            this.buttonReg = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.labelHello = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonCat
            // 
            this.buttonCat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonCat.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCat.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonCat.Location = new System.Drawing.Point(12, 52);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(287, 71);
            this.buttonCat.TabIndex = 0;
            this.buttonCat.Text = "Каталог";
            this.buttonCat.UseVisualStyleBackColor = false;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // buttonProf
            // 
            this.buttonProf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonProf.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonProf.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonProf.Location = new System.Drawing.Point(12, 129);
            this.buttonProf.Name = "buttonProf";
            this.buttonProf.Size = new System.Drawing.Size(287, 71);
            this.buttonProf.TabIndex = 1;
            this.buttonProf.Text = "Профиль";
            this.buttonProf.UseVisualStyleBackColor = false;
            this.buttonProf.Click += new System.EventHandler(this.buttonProf_Click);
            // 
            // buttonReg
            // 
            this.buttonReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonReg.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReg.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonReg.Location = new System.Drawing.Point(12, 283);
            this.buttonReg.Name = "buttonReg";
            this.buttonReg.Size = new System.Drawing.Size(287, 71);
            this.buttonReg.TabIndex = 2;
            this.buttonReg.Text = "РЕГИСТРАЦИЯ";
            this.buttonReg.UseVisualStyleBackColor = false;
            this.buttonReg.Click += new System.EventHandler(this.buttonReg_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.buttonLog.Font = new System.Drawing.Font("Roboto Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLog.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonLog.Location = new System.Drawing.Point(12, 206);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(287, 71);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "Войти";
            this.buttonLog.UseVisualStyleBackColor = false;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // labelHello
            // 
            this.labelHello.AutoSize = true;
            this.labelHello.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHello.Location = new System.Drawing.Point(9, 20);
            this.labelHello.Name = "labelHello";
            this.labelHello.Size = new System.Drawing.Size(53, 18);
            this.labelHello.TabIndex = 4;
            this.labelHello.Text = "label1";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(317, 398);
            this.Controls.Add(this.labelHello);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonReg);
            this.Controls.Add(this.buttonProf);
            this.Controls.Add(this.buttonCat);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное меню";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.Button buttonProf;
        private System.Windows.Forms.Button buttonReg;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.Label labelHello;
    }
}