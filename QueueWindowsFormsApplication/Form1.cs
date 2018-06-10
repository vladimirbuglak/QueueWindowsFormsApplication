using System;
using System.Windows.Forms;

namespace QueueWindowsFormsApplication
{
    public partial class Form1 : Form
    {
        private Queue<User> Queue;

        public Form1()
        {
            InitializeComponent();

            Queue = new Queue<User>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void CreateQueueBtn_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Create queue-- {Environment.NewLine}";

            Queue = GenerateRandomQueue(5);

            QueueTextBox.Text += Queue.ToString();
        }

        public static Queue<User> GenerateRandomQueue(int size)
        {
            var queue = new Queue<User>();
            var rand = new Random();

            for (var i = 0; i < size; i++)
            {
                queue.Enqueue(new User
                {
                    Name = $"User {i + 1}",
                    Age = rand.Next(18, 50)
                });
            }

            return queue;
        }

        private void SortByAge_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Sort by user age-- {Environment.NewLine}";

            Queue.Sort(x => x.Age);

            QueueTextBox.Text += Queue.ToString();
        }

        private void SortByName_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Sort by user name-- {Environment.NewLine}";

            Queue.Sort(x => x.Name);

            QueueTextBox.Text += Queue.ToString();
        }

        private void ClearQueueTextBox_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text = string.Empty;
        }

        private void GetUserFromQueue_Click(object sender, EventArgs e)
        {
            var user = Queue.Dequeue();
            if (user != null)
            {
                QueueTextBox.Text += $"--User from queue-- {Environment.NewLine}";
                QueueTextBox.Text += user.ToString();
                QueueTextBox.Text += Environment.NewLine;
            }
        }

        private void AddUser_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Add user-- {Environment.NewLine}";

            Queue.Enqueue(new User
            {
                Name = UserName.Text,
                Age = int.Parse(UserAge.Text)
            });

            QueueTextBox.Text += Queue.ToString();
        }

        private void PrintQueue_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Print-- {Environment.NewLine}";

            QueueTextBox.Text += Queue.ToString();
        }

        private void ClearQueue_Click(object sender, EventArgs e)
        {
            QueueTextBox.Text += $"--Clear-- {Environment.NewLine}";

            Queue.Clear();
        }
    }
}
