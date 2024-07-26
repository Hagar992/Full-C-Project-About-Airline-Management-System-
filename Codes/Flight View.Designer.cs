namespace Project_Airline_Management_System
{
    partial class Flight_View
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_View));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            FDate = new DateTimePicker();
            To = new ComboBox();
            From = new ComboBox();
            FSeals = new TextBox();
            FCode = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            FlightDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.SaddleBrown;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.Location = new Point(12, 163);
            label8.Name = "label8";
            label8.Size = new Size(112, 24);
            label8.TabIndex = 23;
            label8.Text = "Flight Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.SaddleBrown;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.Location = new Point(12, 216);
            label7.Name = "label7";
            label7.Size = new Size(134, 24);
            label7.TabIndex = 22;
            label7.Text = "Num Of Seals";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SaddleBrown;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.Location = new Point(460, 184);
            label6.Name = "label6";
            label6.Size = new Size(35, 24);
            label6.TabIndex = 21;
            label6.Text = "To";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SaddleBrown;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.Location = new Point(460, 110);
            label5.Name = "label5";
            label5.Size = new Size(58, 24);
            label5.TabIndex = 20;
            label5.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.SaddleBrown;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.Location = new Point(12, 110);
            label4.Name = "label4";
            label4.Size = new Size(116, 24);
            label4.TabIndex = 19;
            label4.Text = "Flight Code";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(768, 46);
            panel1.TabIndex = 24;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.SteelBlue;
            button3.Location = new Point(718, 3);
            button3.Name = "button3";
            button3.Size = new Size(43, 40);
            button3.TabIndex = 26;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.SteelBlue;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(205, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 25;
            label1.Text = "Airline Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.SteelBlue;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.Location = new Point(232, 49);
            label2.Name = "label2";
            label2.Size = new Size(286, 30);
            label2.TabIndex = 26;
            label2.Text = "View Scheduled Flights";
            // 
            // FDate
            // 
            FDate.CalendarMonthBackground = SystemColors.GradientInactiveCaption;
            FDate.Location = new Point(167, 164);
            FDate.Name = "FDate";
            FDate.Size = new Size(200, 23);
            FDate.TabIndex = 31;
            // 
            // To
            // 
            To.BackColor = SystemColors.GradientInactiveCaption;
            To.Font = new Font("Microsoft JhengHei", 12F);
            To.ForeColor = Color.Navy;
            To.FormattingEnabled = true;
            To.Items.AddRange(new object[] { " Afghanistan", " Albania", " Algeria", " Andorra", " Angola", " Antigua and Barbuda", " Argentina", " Armenia", " Australia", " Austria", " Azerbaijan", " Bahamas", " Bahrain", " Bangladesh", " Barbados", " Belarus", " Belgium", " Belize", " Benin", " Bhutan", " Bolivia", " Bosnia and Herzegovina", " Botswana", " Brazil", " Brunei", " Bulgaria", " Burkina Faso", " Burundi", " Cabo Verde", " Cambodia", " Cameroon", " Canada", " Central African Republic", " Chad", " Chile", " China", " Colombia", " Comoros", " Eritrea", " Estoni", " Eswatini", " Ethiopia", " Fiji", " Finland", " France", " Guatemala", " Guinea", " Japan", " Jordan", " Kosovo", " Kuwait", " Kyrgyzstan", " Laos", " Latvia", " Mozambique", "Myanmar (Burma)", "Yemen", "Zambia", "Zimbabwe" });
            To.Location = new Point(541, 180);
            To.Name = "To";
            To.Size = new Size(208, 28);
            To.TabIndex = 30;
            // 
            // From
            // 
            From.BackColor = SystemColors.GradientInactiveCaption;
            From.Font = new Font("Microsoft JhengHei", 12F);
            From.ForeColor = Color.Navy;
            From.FormattingEnabled = true;
            From.Items.AddRange(new object[] { " Afghanistan", " Albania", " Algeria", " Andorra", " Angola", " Antigua and Barbuda", " Argentina", " Armenia", " Australia", " Austria", " Azerbaijan", " Bahamas", " Bahrain", " Bangladesh", " Barbados", " Belarus", " Belgium", " Belize", " Benin", " Bhutan", " Bolivia", " Bosnia and Herzegovina", " Botswana", " Brazil", " Brunei", " Bulgaria", " Burkina Faso", " Burundi", " Cabo Verde", " Cambodia", " Cameroon", " Canada", " Central African Republic", " Chad", " Chile", " China", " Colombia", " Comoros", " Eritrea", " Estoni", " Eswatini", " Ethiopia", " Fiji", " Finland", " France", " Guatemala", " Guinea", " Japan", " Jordan", " Kosovo", " Kuwait", " Kyrgyzstan", " Laos", " Latvia", " Mozambique", "Myanmar (Burma)", "Yemen", "Zambia", "Zimbabwe" });
            From.Location = new Point(541, 108);
            From.Name = "From";
            From.Size = new Size(208, 28);
            From.TabIndex = 29;
            // 
            // FSeals
            // 
            FSeals.BackColor = SystemColors.GradientInactiveCaption;
            FSeals.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FSeals.Location = new Point(167, 214);
            FSeals.MaxLength = 10;
            FSeals.Name = "FSeals";
            FSeals.Size = new Size(208, 29);
            FSeals.TabIndex = 28;
            // 
            // FCode
            // 
            FCode.BackColor = SystemColors.GradientInactiveCaption;
            FCode.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FCode.Location = new Point(167, 108);
            FCode.MaxLength = 15;
            FCode.Name = "FCode";
            FCode.Size = new Size(208, 29);
            FCode.TabIndex = 27;
            // 
            // button1
            // 
            button1.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.SaddleBrown;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(154, 269);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 32;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SaddleBrown;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(523, 269);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 33;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.SaddleBrown;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(400, 269);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 34;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.SaddleBrown;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(277, 269);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 35;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // FlightDGV
            // 
            FlightDGV.AllowUserToOrderColumns = true;
            FlightDGV.BackgroundColor = SystemColors.GradientInactiveCaption;
            FlightDGV.BorderStyle = BorderStyle.Fixed3D;
            FlightDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            FlightDGV.DefaultCellStyle = dataGridViewCellStyle1;
            FlightDGV.EditMode = DataGridViewEditMode.EditOnKeystroke;
            FlightDGV.Location = new Point(54, 326);
            FlightDGV.Margin = new Padding(2);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Meiryo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 192);
            FlightDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            FlightDGV.Size = new Size(656, 347);
            FlightDGV.TabIndex = 66;
            FlightDGV.CellContentClick += FlightDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(705, 678);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 67;
            pictureBox1.TabStop = false;
            // 
            // Flight_View
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(768, 703);
            Controls.Add(pictureBox1);
            Controls.Add(FlightDGV);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDate);
            Controls.Add(To);
            Controls.Add(From);
            Controls.Add(FSeals);
            Controls.Add(FCode);
            Controls.Add(label2);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Flight_View";
            Text = "Flight_View";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private DateTimePicker FDate;
        private ComboBox To;
        private ComboBox From;
        private TextBox FSeals;
        private TextBox FCode;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private DataGridView FlightDGV;
        private PictureBox pictureBox1;
    }
}