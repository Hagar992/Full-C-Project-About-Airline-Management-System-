namespace Project_Airline_Management_System
{
    partial class flight_table
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(flight_table));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            FCode = new TextBox();
            FSeals = new TextBox();
            From = new ComboBox();
            To = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel1 = new Panel();
            label8 = new Label();
            FDate = new DateTimePicker();
            button4 = new Button();
            button5 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(340, -15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(237, 569);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.Location = new Point(244, -15);
            label2.Name = "label2";
            label2.Size = new Size(100, 569);
            label2.TabIndex = 3;
            label2.Text = ".";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.CornflowerBlue;
            label1.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.Yellow;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(112, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 4;
            label1.Text = "Airline Management System";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = Color.Yellow;
            label3.ImageAlign = ContentAlignment.MiddleLeft;
            label3.Location = new Point(159, 46);
            label3.Name = "label3";
            label3.Size = new Size(246, 30);
            label3.TabIndex = 5;
            label3.Text = "Record New Flights";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.ImageAlign = ContentAlignment.MiddleLeft;
            label4.Location = new Point(1, 142);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 6;
            label4.Text = "Flight Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.ImageAlign = ContentAlignment.MiddleLeft;
            label5.Location = new Point(1, 201);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 7;
            label5.Text = "From";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.White;
            label6.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.ImageAlign = ContentAlignment.MiddleLeft;
            label6.Location = new Point(1, 260);
            label6.Name = "label6";
            label6.Size = new Size(35, 24);
            label6.TabIndex = 8;
            label6.Text = "To";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.White;
            label7.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.ImageAlign = ContentAlignment.MiddleLeft;
            label7.Location = new Point(1, 378);
            label7.Name = "label7";
            label7.Size = new Size(134, 24);
            label7.TabIndex = 9;
            label7.Text = "Num Of Seals";
            // 
            // FCode
            // 
            FCode.BackColor = SystemColors.GradientInactiveCaption;
            FCode.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FCode.Location = new Point(147, 140);
            FCode.Name = "FCode";
            FCode.PlaceholderText = "Enter Flight Code";
            FCode.Size = new Size(208, 29);
            FCode.TabIndex = 10;
            // 
            // FSeals
            // 
            FSeals.BackColor = SystemColors.GradientInactiveCaption;
            FSeals.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FSeals.Location = new Point(147, 376);
            FSeals.Name = "FSeals";
            FSeals.PlaceholderText = "Enter Num Of Seals";
            FSeals.Size = new Size(208, 29);
            FSeals.TabIndex = 11;
            // 
            // From
            // 
            From.BackColor = SystemColors.GradientInactiveCaption;
            From.Font = new Font("Microsoft JhengHei", 12F);
            From.FormattingEnabled = true;
            From.Location = new Point(147, 199);
            From.Name = "From";
            From.Size = new Size(208, 28);
            From.TabIndex = 12;
            From.Text = "Choose The Beginning";
            // 
            // To
            // 
            To.BackColor = SystemColors.GradientInactiveCaption;
            To.Font = new Font("Microsoft JhengHei", 12F);
            To.FormattingEnabled = true;
            To.Location = new Point(147, 258);
            To.Name = "To";
            To.Size = new Size(208, 28);
            To.TabIndex = 13;
            To.Text = "Choose The End";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.GradientInactiveCaption;
            button1.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.SaddleBrown;
            button1.Location = new Point(18, 447);
            button1.Name = "button1";
            button1.Size = new Size(99, 31);
            button1.TabIndex = 14;
            button1.Text = "Record ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.GradientInactiveCaption;
            button2.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SaddleBrown;
            button2.Location = new Point(135, 447);
            button2.Name = "button2";
            button2.Size = new Size(99, 31);
            button2.TabIndex = 15;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.CornflowerBlue;
            button3.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.Yellow;
            button3.Location = new Point(530, 3);
            button3.Name = "button3";
            button3.Size = new Size(43, 40);
            button3.TabIndex = 16;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.CornflowerBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(577, 43);
            panel1.TabIndex = 17;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.White;
            label8.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.ImageAlign = ContentAlignment.MiddleLeft;
            label8.Location = new Point(1, 319);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 18;
            label8.Text = "Flight Date";
            // 
            // FDate
            // 
            FDate.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            FDate.Location = new Point(147, 320);
            FDate.Name = "FDate";
            FDate.Size = new Size(200, 23);
            FDate.TabIndex = 19;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.GradientInactiveCaption;
            button4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.SaddleBrown;
            button4.Location = new Point(252, 447);
            button4.Name = "button4";
            button4.Size = new Size(133, 31);
            button4.TabIndex = 20;
            button4.Text = "View Flight";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.GradientInactiveCaption;
            button5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.SaddleBrown;
            button5.Location = new Point(403, 447);
            button5.Name = "button5";
            button5.Size = new Size(99, 31);
            button5.TabIndex = 21;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(510, 474);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 22;
            pictureBox2.TabStop = false;
            // 
            // flight_table
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(577, 501);
            Controls.Add(pictureBox2);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(FDate);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(To);
            Controls.Add(From);
            Controls.Add(FSeals);
            Controls.Add(FCode);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "flight_table";
            Text = "flight_table";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox FCode;
        private TextBox FSeals;
        private ComboBox From;
        private ComboBox To;
        private Button button1;
        private Button button2;
        private Button button3;
        private Panel panel1;
        private Label label8;
        private DateTimePicker FDate;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox2;
    }
}