namespace WinForms_C__LESSON_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BGCButton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotRichTextBox1.BackColor = colorDialog1.Color;
                BGCOLORlabel2.BackColor = colorDialog1.Color;
            }
        }
        private void BGCOLORlabel2_Click_1(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotRichTextBox1.BackColor = colorDialog1.Color;
                BGCOLORlabel2.BackColor = colorDialog1.Color;
            }
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FCbutton1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotRichTextBox1.ForeColor = colorDialog1.Color;
                FontColorlabel2.BackColor = colorDialog1.Color;
            }
        }

        private void FontColorlabel2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                NotRichTextBox1.ForeColor = colorDialog1.Color;
                FontColorlabel2.BackColor = colorDialog1.Color;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                NotRichTextBox1.Font = fontDialog1.Font;
                NotRichTextBox1.Site = fontDialog1.Site;

                textSizeLabel3.Text = "Text Size: " + fontDialog1.Font.Size.ToString();


                button1.Font = new Font(fontDialog1.Font.Name, 10.2f, fontDialog1.Font.Style);


            }
        }
    }
}