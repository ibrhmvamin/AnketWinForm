using System.Net.Mail;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Text.Json.Serialization;



namespace WinFormsAnket
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public List<Worker> workers = new List<Worker>();
       


        private void save_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < workers.Count; i++)
            {
                if (workers[i].Mail == mailtextBox.Text)
                {
                    MessageBox.Show("This Mail Already Exists");
                    return;
                }
            }
            if (surnameTextBox.Text == null || nameTextBox.Text == null || fatherTextBox.Text == null
                || countryTextBox.Text == null || cityTextBox.Text == null || phoneTextBox.Text == null
                || mailtextBox.Text == null)
            {
                MessageBox.Show("All datas must be fullied");
            }

            Worker worker = new Worker(surnameTextBox.Text, nameTextBox.Text, fatherTextBox.Text,
      countryTextBox.Text, cityTextBox.Text, phoneTextBox.Text, dateTimePicker1.Value, mailtextBox.Text);
            workers.Add(worker);
            MessageBox.Show("Worker added successfully");

            var options = new JsonSerializerOptions { WriteIndented = true };
            string writeTo = System.Text.Json.JsonSerializer.Serialize(workers, options);
            File.WriteAllText("../../../Workers.json", writeTo);
            surnameTextBox.ResetText();
            nameTextBox.ResetText();
            fatherTextBox.ResetText();
            countryTextBox.ResetText();
            cityTextBox.ResetText();
            phoneTextBox.ResetText();
            mailtextBox.ResetText();
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            if (existedMail.Text.EndsWith("@gmail.com"))
            {
                bool IsFound = false;
                for (int i = 0; i < workers?.Count; i++)
                {
                    if (workers[i].Mail == existedMail.Text)
                    {
                        string readFrom = File.ReadAllText("../../../Workers.json");
                        workers = JsonSerializer.Deserialize<List<Worker>>(readFrom);
                        IsFound = true;
                    }
                }
                if (!IsFound)
                {
                    MessageBox.Show("Mail does not exist in Database");
                }
            }
            else
            {
                MessageBox.Show("Valid mail format");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}