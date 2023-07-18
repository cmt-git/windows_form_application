namespace Midterms_QuizApp
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            happy_emoji = new PictureBox();
            result_text = new Label();
            pictureBox2 = new PictureBox();
            points_text = new Label();
            label2 = new Label();
            best_emoji = new PictureBox();
            sad_emoji = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)happy_emoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)best_emoji).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sad_emoji).BeginInit();
            SuspendLayout();
            // 
            // happy_emoji
            // 
            happy_emoji.BackgroundImage = (Image)resources.GetObject("happy_emoji.BackgroundImage");
            happy_emoji.BackgroundImageLayout = ImageLayout.Zoom;
            happy_emoji.Location = new Point(311, 137);
            happy_emoji.Name = "happy_emoji";
            happy_emoji.Size = new Size(410, 340);
            happy_emoji.TabIndex = 0;
            happy_emoji.TabStop = false;
            // 
            // result_text
            // 
            result_text.AccessibleDescription = "514, 522";
            result_text.AutoSize = true;
            result_text.BackColor = Color.Transparent;
            result_text.Font = new Font("Poppins", 24F, FontStyle.Bold, GraphicsUnit.Point);
            result_text.ForeColor = Color.White;
            result_text.Location = new Point(515, 517);
            result_text.Name = "result_text";
            result_text.Size = new Size(236, 70);
            result_text.TabIndex = 20;
            result_text.Text = "Good Job!";
            result_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(241, 567);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(583, 235);
            pictureBox2.TabIndex = 21;
            pictureBox2.TabStop = false;
            // 
            // points_text
            // 
            points_text.AccessibleDescription = "540, 678";
            points_text.AutoSize = true;
            points_text.BackColor = Color.Black;
            points_text.Font = new Font("Poppins", 48F, FontStyle.Bold, GraphicsUnit.Point);
            points_text.ForeColor = Color.White;
            points_text.Location = new Point(540, 678);
            points_text.Name = "points_text";
            points_text.Size = new Size(239, 141);
            points_text.TabIndex = 22;
            points_text.Text = "7/35";
            points_text.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AccessibleDescription = "538, 250";
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Poppins", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(348, 847);
            label2.Name = "label2";
            label2.Size = new Size(350, 50);
            label2.TabIndex = 23;
            label2.Text = "Tap Here To Play Again";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // best_emoji
            // 
            best_emoji.BackgroundImage = (Image)resources.GetObject("best_emoji.BackgroundImage");
            best_emoji.BackgroundImageLayout = ImageLayout.Zoom;
            best_emoji.Location = new Point(311, 137);
            best_emoji.Name = "best_emoji";
            best_emoji.Size = new Size(410, 340);
            best_emoji.TabIndex = 24;
            best_emoji.TabStop = false;
            // 
            // sad_emoji
            // 
            sad_emoji.BackgroundImage = (Image)resources.GetObject("sad_emoji.BackgroundImage");
            sad_emoji.BackgroundImageLayout = ImageLayout.Zoom;
            sad_emoji.Location = new Point(311, 137);
            sad_emoji.Name = "sad_emoji";
            sad_emoji.Size = new Size(410, 340);
            sad_emoji.TabIndex = 25;
            sad_emoji.TabStop = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GreenYellow;
            ClientSize = new Size(1064, 906);
            Controls.Add(sad_emoji);
            Controls.Add(best_emoji);
            Controls.Add(label2);
            Controls.Add(points_text);
            Controls.Add(pictureBox2);
            Controls.Add(result_text);
            Controls.Add(happy_emoji);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)happy_emoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)best_emoji).EndInit();
            ((System.ComponentModel.ISupportInitialize)sad_emoji).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox happy_emoji;
        private Label result_text;
        private PictureBox pictureBox2;
        private Label points_text;
        private Label label2;
        private PictureBox best_emoji;
        private PictureBox sad_emoji;
    }
}