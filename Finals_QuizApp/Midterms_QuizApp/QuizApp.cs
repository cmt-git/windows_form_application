using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;

namespace Midterms_QuizApp
{
    public partial class QuizApp : Form
    {
        private void centerText(Label _textLabel)
        {
            int size_x = _textLabel.Size.Width;
            int size_y = _textLabel.Size.Height;
            int x_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[0]);
            int y_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[1]);

            _textLabel.Location = new Point(x_position - (size_x / 2), y_position - (size_y / 2));
        }

        public QuizApp()
        {
            InitializeComponent();
            crownImage.BringToFront();

            string filename = "highscore.txt";
            int highScore;

            if (File.Exists(filename))
            {
                // Read the current high score from the file
                string scoreText = File.ReadAllText(filename);
                if (int.TryParse(scoreText, out highScore))
                {
                    highscore_text.Text = highScore.ToString();
                }
            }
            else
            {
                // Create the file with an initial high score of 0
                highScore = 0;
                File.WriteAllText(filename, highScore.ToString());
            }

            centerText(highscore_text);
        }

        private void playbutton_click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}