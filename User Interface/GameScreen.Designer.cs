namespace KidsGame
{
    partial class GameScreen
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.firstCanvas = new System.Windows.Forms.PictureBox();
            this.secondCanvas = new System.Windows.Forms.PictureBox();
            this.clearCanvasButton = new System.Windows.Forms.Button();
            this.savePictureDialog = new System.Windows.Forms.SaveFileDialog();
            this.saveFileButton = new System.Windows.Forms.Button();
            this.firstCheckBox = new System.Windows.Forms.CheckBox();
            this.secondCheckBox = new System.Windows.Forms.CheckBox();
            this.firstImage = new System.Windows.Forms.PictureBox();
            this.secondImage = new System.Windows.Forms.PictureBox();
            this.randomButton = new System.Windows.Forms.Button();
            this.changeColor = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.paletteButton = new System.Windows.Forms.Button();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.firstCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondImage)).BeginInit();
            this.SuspendLayout();
            // 
            // firstCanvas
            // 
            this.firstCanvas.BackColor = System.Drawing.Color.LightGray;
            this.firstCanvas.Location = new System.Drawing.Point(324, 12);
            this.firstCanvas.Name = "firstCanvas";
            this.firstCanvas.Size = new System.Drawing.Size(150, 150);
            this.firstCanvas.TabIndex = 0;
            this.firstCanvas.TabStop = false;
            this.firstCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.firstCanvas_MouseDown);
            this.firstCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.firstCanvas_MouseMove);
            this.firstCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.firstCanvas_MouseUp);
            // 
            // secondCanvas
            // 
            this.secondCanvas.BackColor = System.Drawing.Color.LightGray;
            this.secondCanvas.Location = new System.Drawing.Point(324, 183);
            this.secondCanvas.Name = "secondCanvas";
            this.secondCanvas.Size = new System.Drawing.Size(150, 150);
            this.secondCanvas.TabIndex = 1;
            this.secondCanvas.TabStop = false;
            this.secondCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.secondCanvas_MouseDown);
            this.secondCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.secondCanvas_MouseMove);
            this.secondCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.secondCanvas_MouseUp);
            // 
            // clearCanvasButton
            // 
            this.clearCanvasButton.Location = new System.Drawing.Point(12, 339);
            this.clearCanvasButton.Name = "clearCanvasButton";
            this.clearCanvasButton.Size = new System.Drawing.Size(99, 40);
            this.clearCanvasButton.TabIndex = 2;
            this.clearCanvasButton.Text = "Clear";
            this.clearCanvasButton.UseVisualStyleBackColor = true;
            this.clearCanvasButton.Click += new System.EventHandler(this.clearCanvasButton_Click);
            // 
            // saveFileButton
            // 
            this.saveFileButton.Location = new System.Drawing.Point(117, 339);
            this.saveFileButton.Name = "saveFileButton";
            this.saveFileButton.Size = new System.Drawing.Size(99, 40);
            this.saveFileButton.TabIndex = 3;
            this.saveFileButton.Text = "Save";
            this.saveFileButton.UseVisualStyleBackColor = true;
            this.saveFileButton.Click += new System.EventHandler(this.saveFileButton_Click);
            // 
            // firstCheckBox
            // 
            this.firstCheckBox.AutoSize = true;
            this.firstCheckBox.Location = new System.Drawing.Point(307, 148);
            this.firstCheckBox.Name = "firstCheckBox";
            this.firstCheckBox.Size = new System.Drawing.Size(15, 14);
            this.firstCheckBox.TabIndex = 4;
            this.firstCheckBox.UseVisualStyleBackColor = true;
            // 
            // secondCheckBox
            // 
            this.secondCheckBox.AutoSize = true;
            this.secondCheckBox.Location = new System.Drawing.Point(307, 319);
            this.secondCheckBox.Name = "secondCheckBox";
            this.secondCheckBox.Size = new System.Drawing.Size(15, 14);
            this.secondCheckBox.TabIndex = 5;
            this.secondCheckBox.UseVisualStyleBackColor = true;
            // 
            // firstImage
            // 
            this.firstImage.BackColor = System.Drawing.Color.LightGray;
            this.firstImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.firstImage.Location = new System.Drawing.Point(12, 12);
            this.firstImage.Name = "firstImage";
            this.firstImage.Size = new System.Drawing.Size(246, 150);
            this.firstImage.TabIndex = 6;
            this.firstImage.TabStop = false;
            // 
            // secondImage
            // 
            this.secondImage.BackColor = System.Drawing.Color.LightGray;
            this.secondImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.secondImage.Location = new System.Drawing.Point(12, 183);
            this.secondImage.Name = "secondImage";
            this.secondImage.Size = new System.Drawing.Size(246, 150);
            this.secondImage.TabIndex = 7;
            this.secondImage.TabStop = false;
            // 
            // randomButton
            // 
            this.randomButton.Location = new System.Drawing.Point(375, 339);
            this.randomButton.Name = "randomButton";
            this.randomButton.Size = new System.Drawing.Size(99, 40);
            this.randomButton.TabIndex = 8;
            this.randomButton.Text = "Refresh";
            this.randomButton.UseVisualStyleBackColor = true;
            this.randomButton.Click += new System.EventHandler(this.randomButton_Click);
            // 
            // changeColor
            // 
            this.changeColor.BackColor = System.Drawing.Color.White;
            this.changeColor.Location = new System.Drawing.Point(480, 12);
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(35, 35);
            this.changeColor.TabIndex = 9;
            this.changeColor.UseVisualStyleBackColor = false;
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Fuchsia;
            this.button2.Location = new System.Drawing.Point(480, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(35, 35);
            this.button2.TabIndex = 10;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Blue;
            this.button3.Location = new System.Drawing.Point(480, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 11;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Aqua;
            this.button4.Location = new System.Drawing.Point(480, 135);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 12;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(480, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(35, 35);
            this.button5.TabIndex = 13;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(480, 217);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(35, 35);
            this.button6.TabIndex = 14;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Yellow;
            this.button7.Location = new System.Drawing.Point(480, 258);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(35, 35);
            this.button7.TabIndex = 15;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // paletteButton
            // 
            this.paletteButton.BackColor = System.Drawing.Color.White;
            this.paletteButton.Location = new System.Drawing.Point(480, 298);
            this.paletteButton.Name = "paletteButton";
            this.paletteButton.Size = new System.Drawing.Size(35, 35);
            this.paletteButton.TabIndex = 16;
            this.paletteButton.UseVisualStyleBackColor = false;
            this.paletteButton.Click += new System.EventHandler(this.paletteButton_Click);
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 385);
            this.Controls.Add(this.paletteButton);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.changeColor);
            this.Controls.Add(this.randomButton);
            this.Controls.Add(this.secondImage);
            this.Controls.Add(this.firstImage);
            this.Controls.Add(this.secondCheckBox);
            this.Controls.Add(this.firstCheckBox);
            this.Controls.Add(this.saveFileButton);
            this.Controls.Add(this.clearCanvasButton);
            this.Controls.Add(this.secondCanvas);
            this.Controls.Add(this.firstCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Paint4Kids";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.firstCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox firstCanvas;
        private System.Windows.Forms.PictureBox secondCanvas;
        private System.Windows.Forms.Button clearCanvasButton;
        private System.Windows.Forms.SaveFileDialog savePictureDialog;
        private System.Windows.Forms.Button saveFileButton;
        private System.Windows.Forms.CheckBox firstCheckBox;
        private System.Windows.Forms.CheckBox secondCheckBox;
        private System.Windows.Forms.PictureBox firstImage;
        private System.Windows.Forms.PictureBox secondImage;
        private System.Windows.Forms.Button randomButton;
        private System.Windows.Forms.Button changeColor;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button paletteButton;
        private System.Windows.Forms.ColorDialog colorDialog;
    }
}

