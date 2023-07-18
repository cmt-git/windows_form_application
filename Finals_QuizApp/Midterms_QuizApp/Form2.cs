using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Midterms_QuizApp
{
    public partial class Form2 : Form
    {
        private void centerText(Label _textLabel)
        {
            int size_x = _textLabel.Size.Width;
            int size_y = _textLabel.Size.Height;
            int x_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[0]);
            int y_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[1]);

            _textLabel.Location = new Point(x_position - (size_x / 2), y_position - (size_y / 2));
        }

        public Form2(int _points)
        {
            InitializeComponent();

            points_text.Text = _points + " / 35";
            centerText(points_text);

            result_text.Text = "Ngek";
            centerText(result_text);
            this.BackColor = Color.Crimson;
            sad_emoji.BringToFront();
            if (_points >= 18)
            {
                result_text.Text = "Great!";
                centerText(result_text);
                this.BackColor = Color.Gold;
                happy_emoji.BringToFront();
            }

            if (_points >= 25)
            {
                result_text.Text = "Good Job!";
                centerText(result_text);
                this.BackColor = Color.GreenYellow;
                best_emoji.BringToFront();
            }

            string filename = "highscore.txt";
            int highScore;

            if (File.Exists(filename))
            {
                // Read the current high score from the file
                string scoreText = File.ReadAllText(filename);
                if (int.TryParse(scoreText, out highScore))
                {
                    Debug.WriteLine(highScore + " - " + _points);
                    if (highScore < _points)
                    {
                        File.WriteAllText(filename, _points.ToString());
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            QuizApp quiz_app = new QuizApp();
            quiz_app.Show();
            this.Hide();
        }
    }
}
