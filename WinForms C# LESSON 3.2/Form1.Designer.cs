namespace WinForms_C__LESSON_3._2
{
    partial class Form1
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
            NotRichTextBox1 = new RichTextBox();
            label1 = new Label();
            colorDialog1 = new ColorDialog();
            fontDialog1 = new FontDialog();
            BGCButton1 = new Button();
            BGCOLORlabel2 = new Label();
            FontColorlabel2 = new Label();
            FCbutton1 = new Button();
            textSizeLabel3 = new Label();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // NotRichTextBox1
            // 
            NotRichTextBox1.BorderStyle = BorderStyle.None;
            NotRichTextBox1.ForeColor = SystemColors.WindowText;
            NotRichTextBox1.ImeMode = ImeMode.NoControl;
            NotRichTextBox1.Location = new Point(15, 60);
            NotRichTextBox1.Name = "NotRichTextBox1";
            NotRichTextBox1.Size = new Size(650, 400);
            NotRichTextBox1.TabIndex = 0;
            NotRichTextBox1.Text = "";
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaptionText;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(10, 20);
            label1.Name = "label1";
            label1.Size = new Size(660, 445);
            label1.TabIndex = 1;
            // 
            // BGCButton1
            // 
            BGCButton1.FlatStyle = FlatStyle.Popup;
            BGCButton1.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BGCButton1.Location = new Point(15, 26);
            BGCButton1.Name = "BGCButton1";
            BGCButton1.Size = new Size(99, 29);
            BGCButton1.TabIndex = 2;
            BGCButton1.Text = "BG C";
            BGCButton1.TextAlign = ContentAlignment.MiddleLeft;
            BGCButton1.UseVisualStyleBackColor = true;
            BGCButton1.Click += BGCButton1_Click;
            // 
            // BGCOLORlabel2
            // 
            BGCOLORlabel2.BackColor = SystemColors.ButtonHighlight;
            BGCOLORlabel2.Location = new Point(88, 28);
            BGCOLORlabel2.Name = "BGCOLORlabel2";
            BGCOLORlabel2.Size = new Size(23, 23);
            BGCOLORlabel2.TabIndex = 3;
            BGCOLORlabel2.Click += BGCOLORlabel2_Click_1;
            // 
            // FontColorlabel2
            // 
            FontColorlabel2.BackColor = SystemColors.ActiveCaptionText;
            FontColorlabel2.Location = new Point(193, 28);
            FontColorlabel2.Name = "FontColorlabel2";
            FontColorlabel2.Size = new Size(23, 23);
            FontColorlabel2.TabIndex = 5;
            FontColorlabel2.Click += FontColorlabel2_Click;
            // 
            // FCbutton1
            // 
            FCbutton1.FlatStyle = FlatStyle.Popup;
            FCbutton1.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            FCbutton1.Location = new Point(120, 25);
            FCbutton1.Name = "FCbutton1";
            FCbutton1.Size = new Size(99, 29);
            FCbutton1.TabIndex = 4;
            FCbutton1.Text = "FO C";
            FCbutton1.TextAlign = ContentAlignment.MiddleLeft;
            FCbutton1.UseVisualStyleBackColor = true;
            FCbutton1.Click += FCbutton1_Click;
            // 
            // textSizeLabel3
            // 
            textSizeLabel3.BackColor = SystemColors.ButtonFace;
            textSizeLabel3.Font = new Font("Rockwell Extra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            textSizeLabel3.ForeColor = SystemColors.ActiveCaptionText;
            textSizeLabel3.Location = new Point(371, 26);
            textSizeLabel3.Name = "textSizeLabel3";
            textSizeLabel3.Size = new Size(190, 29);
            textSizeLabel3.TabIndex = 7;
            textSizeLabel3.Text = "Text Size: 10,2";
            textSizeLabel3.TextAlign = ContentAlignment.MiddleLeft;
            textSizeLabel3.Click += label3_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("A2 Arial AzCyr", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(566, 26);
            button1.Name = "button1";
            button1.Size = new Size(99, 29);
            button1.TabIndex = 6;
            button1.Text = "TEXT";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 468);
            Controls.Add(textSizeLabel3);
            Controls.Add(button1);
            Controls.Add(FontColorlabel2);
            Controls.Add(FCbutton1);
            Controls.Add(BGCOLORlabel2);
            Controls.Add(BGCButton1);
            Controls.Add(NotRichTextBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox NotRichTextBox1;
        private Label label1;
        private ColorDialog colorDialog1;
        private FontDialog fontDialog1;
        private Button BGCButton1;
        private Label BGCOLORlabel2;
        private Label FontColorlabel2;
        private Button FCbutton1;
        private Label textSizeLabel3;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}