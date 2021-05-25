namespace KidsGame.User_Interface
{
    partial class GameMenu
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
            this.goTooPaint = new System.Windows.Forms.Button();
            this.goToFigures = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // goTooPaint
            // 
            this.goTooPaint.Location = new System.Drawing.Point(12, 12);
            this.goTooPaint.Name = "goTooPaint";
            this.goTooPaint.Size = new System.Drawing.Size(179, 63);
            this.goTooPaint.TabIndex = 0;
            this.goTooPaint.Text = "Paint";
            this.goTooPaint.UseVisualStyleBackColor = true;
            this.goTooPaint.Click += new System.EventHandler(this.goTooPaint_Click);
            // 
            // goToFigures
            // 
            this.goToFigures.Location = new System.Drawing.Point(12, 81);
            this.goToFigures.Name = "goToFigures";
            this.goToFigures.Size = new System.Drawing.Size(179, 63);
            this.goToFigures.TabIndex = 1;
            this.goToFigures.Text = "Figure Transferring";
            this.goToFigures.UseVisualStyleBackColor = true;
            this.goToFigures.Click += new System.EventHandler(this.goToFigures_Click);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(211, 156);
            this.Controls.Add(this.goToFigures);
            this.Controls.Add(this.goTooPaint);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.GameMenu_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button goTooPaint;
        private System.Windows.Forms.Button goToFigures;
    }
}