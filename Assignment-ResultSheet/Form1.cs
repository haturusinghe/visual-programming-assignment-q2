namespace Assignment_ResultSheet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradeSinhala.Text = getGrade(inSinhala.Text);
            gradeEnglish.Text = getGrade(inEng.Text);
            gradeHistory.Text = getGrade(inHistory.Text);
            gradeMath.Text = getGrade(inMath.Text);
            gradeScience.Text = getGrade(inScience.Text);

        }

        private string getGrade(string m)
        {
            int marks = int.Parse(m);
            if(marks >= 75)
            {
                return "A";
            }
            else if(marks >= 65)
            {
                return "B";
            }
            else if(marks >= 55)
            {
                return "C";
            }
            else if(marks >= 35)
            {
                return "S";
            }
            
            return "F";
          
          
        }

        private float getTotalMarks()
        {
            int maths = int.Parse(inMath.Text);
            int english = int.Parse(inEng.Text);
            int science = int.Parse(inScience.Text);
            int sinhala = int.Parse(inSinhala.Text);
            int history = int.Parse(inHistory.Text);

            float total = maths + english + science + sinhala + history;
            return total;
        }

        private float getAverage()
        {
            return getTotalMarks() / 5.0f;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            disTotal.Text = getTotalMarks().ToString();
        }

        private void btnAvg_Click(object sender, EventArgs e)
        {

            disAvg.Text = getAverage().ToString();
        }

        private void btnClr_Click(object sender, EventArgs e)
        {
            foreach (TextBox textBox in this.Controls.OfType<TextBox>())
            {
                textBox.Clear();
            }
            gradeSinhala.Text = "";
            gradeEnglish.Text = "";
            gradeHistory.Text = "";
            gradeMath.Text = "";
            gradeScience.Text = "";

            disAvg.Text = "";
            disTotal.Text = "";
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            string message = "Student Name: " + inName.Text + ", Student Number: " + inNumber.Text + ", Total: " + getTotalMarks() + ", Average: " + getAverage() + ".";
            string title = "Student Results Report!";
            MessageBox.Show(message, title);
        }
    }


}