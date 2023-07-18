using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Npgsql;

namespace Midterms_QuizApp
{
    public partial class Form1 : Form
    {
        List<String> questions = new List<string>();
        List<String> answers = new List<string>();
        List<int> question_sequence = new List<int>();

        int question_index = 0;
        int current_correct_answer = 0;
        int points = 0;

        private void ConnectToDatabase()
        {
            string connectionString = "Host=localhost;Port=5432;Username=admin;Password=admin;Database=sample_db";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM questions";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        foreach (DataRow row in dataTable.Rows)
                        {
                            string line = row["question"].ToString();
                            string current_question = line.Split("(-)")[0];
                            int starting_length = current_question.Length + 3;
                            string current_answer = line.Substring(starting_length, line.Length - starting_length);

                            questions.Add(current_question.ToString());
                            answers.Add(current_answer.ToString());
                        }
                    }
                }
            }

            Console.ReadLine();
        }

        private string filterText(string _sentence, int length_limit)
        {
            string filtered_text = String.Empty;
            int current_limit = 0;
            for (int i = 0; i < _sentence.Length; i++)
            {
                current_limit += 1;

                filtered_text += _sentence[i];

                if (current_limit >= length_limit && _sentence[i] == ' ')
                {
                    current_limit = 0;
                    filtered_text += "\n";
                }
            }
            return filtered_text;
        }
        private void centerText(Label _textLabel)
        {
            int size_x = _textLabel.Size.Width;
            int size_y = _textLabel.Size.Height;
            int x_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[0]);
            int y_position = int.Parse(_textLabel.AccessibleDescription.Split(",")[1]);

            _textLabel.Location = new Point(x_position - (size_x / 2), y_position - (size_y / 2));
        }

        private void LoadQuestions()
        {
            if (question_index < 35) {
                Random random = new Random();
                int randomNumber = random.Next(0, questions.Count());
                while (question_sequence.Contains(randomNumber))
                {
                    randomNumber = random.Next(0, questions.Count());
                }
                question_sequence.Add(randomNumber);
                question_text.Text = filterText(questions[randomNumber], 30);
                centerText(question_text);

                String[] current_answers = answers[randomNumber].Split("(-)");
                List<int> label_index = new List<int> { 1, 2, 3, 4 };
                for (int i = 0; i < current_answers.Count(); i++)
                {
                    String filtered_answer = current_answers[i];
                    int rand_label_index = random.Next(0, label_index.Count());
                    int rand_label = label_index[rand_label_index];
                    label_index.RemoveAt(rand_label_index);

                    if (current_answers[i].Split("]")[0].ToLower() == " [correct")
                    {
                        current_correct_answer = rand_label;
                        filtered_answer = current_answers[i].Substring(" [correct".Length, current_answers[i].Length - " [correct".Length);
                    }

                    filtered_answer = filterText(filtered_answer, 15);
                    if (rand_label == 1)
                    {
                        answer_1.Text = filtered_answer;
                        centerText(answer_1);
                    }

                    if (rand_label == 2)
                    {
                        answer_2.Text = filtered_answer;
                        centerText(answer_2);
                    }

                    if (rand_label == 3)
                    {
                        answer_3.Text = filtered_answer;
                        centerText(answer_3);
                    }

                    if (rand_label == 4)
                    {
                        answer_4.Text = filtered_answer;
                        centerText(answer_4);
                    }
                }

                question_index += 1;
                question_index_label.Text = "Question #" + question_index;

                Debug.WriteLine("current correct answer: " + current_correct_answer);
            }
            else
            {
                Form2 form2 = new Form2(points);
                form2.Show();
                this.Hide();
            }
        }

        private void checkCorrectAnswer(int _index)
        {
            if (_index == current_correct_answer)
            {
                points++;
                Debug.WriteLine("answer is correct! current points: "+ points);
            }

            LoadQuestions();
        }

        public Form1()
        {
            InitializeComponent();

            ConnectToDatabase();
            LoadQuestions();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(1);
        }

        private void answer_1_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(2);
        }

        private void answer_2_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(3);
        }

        private void answer_3_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(4);
        }

        private void answer_4_Click(object sender, EventArgs e)
        {
            checkCorrectAnswer(4);
        }
    }
}
