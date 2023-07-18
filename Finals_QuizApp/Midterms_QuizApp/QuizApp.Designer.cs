namespace Midterms_QuizApp
{
    partial class QuizApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuizApp));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            crownImage = new PictureBox();
            highscore_text = new Label();
            play_button = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)crownImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)play_button).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(485, 69);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(130, 157);
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Poppins", 28.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(425, 231);
            label1.Name = "label1";
            label1.Size = new Size(250, 82);
            label1.TabIndex = 1;
            label1.Text = "Quiz App";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Poppins", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(271, 299);
            label2.Name = "label2";
            label2.Size = new Size(564, 60);
            label2.TabIndex = 2;
            label2.Text = "Answer 35 questions about C#";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(421, 361);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(259, 75);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // crownImage
            // 
            crownImage.BackColor = Color.Transparent;
            crownImage.BackgroundImage = (Image)resources.GetObject("crownImage.BackgroundImage");
            crownImage.BackgroundImageLayout = ImageLayout.Zoom;
            crownImage.Location = new Point(507, 523);
            crownImage.Name = "crownImage";
            crownImage.Size = new Size(77, 51);
            crownImage.TabIndex = 4;
            crownImage.TabStop = false;
            // 
            // highscore_text
            // 
            highscore_text.AccessibleDescription = "555, 631";
            highscore_text.AutoSize = true;
            highscore_text.BackColor = Color.Transparent;
            highscore_text.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point);
            highscore_text.ForeColor = Color.Black;
            highscore_text.Location = new Point(575, 631);
            highscore_text.Name = "highscore_text";
            highscore_text.Size = new Size(112, 141);
            highscore_text.TabIndex = 5;
            highscore_text.Text = "0";
            highscore_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // play_button
            // 
            play_button.BackColor = Color.Transparent;
            play_button.BackgroundImage = (Image)resources.GetObject("play_button.BackgroundImage");
            play_button.BackgroundImageLayout = ImageLayout.Zoom;
            play_button.Cursor = Cursors.Hand;
            play_button.Location = new Point(154, 691);
            play_button.Name = "play_button";
            play_button.Size = new Size(792, 221);
            play_button.TabIndex = 6;
            play_button.TabStop = false;
            play_button.Click += playbutton_click;
            // 
            // QuizApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1082, 953);
            Controls.Add(play_button);
            Controls.Add(highscore_text);
            Controls.Add(crownImage);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "QuizApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)crownImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)play_button).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox crownImage;
        private Label highscore_text;
        private PictureBox play_button;
    }
}