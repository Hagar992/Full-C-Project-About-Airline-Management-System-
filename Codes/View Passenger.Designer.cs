namespace Project_Airline_Management_System
{
    partial class View_Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Passenger));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label2 = new Label();
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            passPort = new TextBox();
            passAd = new TextBox();
            passPhone = new TextBox();
            passName = new TextBox();
            passGend = new ComboBox();
            passNat = new ComboBox();
            passId = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            PassDGV = new DataGridView();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PassDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Navy;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(246, 49);
            label2.Name = "label2";
            label2.Size = new Size(206, 30);
            label2.TabIndex = 30;
            label2.Text = "View Passengers";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(746, 46);
            panel1.TabIndex = 29;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.MediumBlue;
            button3.Location = new Point(700, 3);
            button3.Name = "button3";
            button3.Size = new Size(43, 40);
            button3.TabIndex = 27;
            button3.Text = "X";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.GradientInactiveCaption;
            label1.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = Color.MidnightBlue;
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(176, 8);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 26;
            label1.Text = "Airline Management System";
            // 
            // passPort
            // 
            passPort.BackColor = SystemColors.GradientInactiveCaption;
            passPort.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPort.Location = new Point(562, 242);
            passPort.MaxLength = 15;
            passPort.Name = "passPort";
            passPort.Size = new Size(175, 29);
            passPort.TabIndex = 60;
            // 
            // passAd
            // 
            passAd.BackColor = SystemColors.GradientInactiveCaption;
            passAd.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passAd.Location = new Point(562, 188);
            passAd.MaxLength = 15;
            passAd.Name = "passAd";
            passAd.Size = new Size(175, 29);
            passAd.TabIndex = 59;
            // 
            // passPhone
            // 
            passPhone.BackColor = SystemColors.GradientInactiveCaption;
            passPhone.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPhone.Location = new Point(176, 188);
            passPhone.MaxLength = 15;
            passPhone.Name = "passPhone";
            passPhone.Size = new Size(170, 29);
            passPhone.TabIndex = 58;
            // 
            // passName
            // 
            passName.BackColor = SystemColors.GradientInactiveCaption;
            passName.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passName.Location = new Point(562, 134);
            passName.MaxLength = 15;
            passName.Name = "passName";
            passName.Size = new Size(175, 29);
            passName.TabIndex = 57;
            // 
            // passGend
            // 
            passGend.BackColor = SystemColors.GradientInactiveCaption;
            passGend.Font = new Font("Microsoft JhengHei", 12F);
            passGend.FormattingEnabled = true;
            passGend.Items.AddRange(new object[] { "Male", "Female" });
            passGend.Location = new Point(176, 296);
            passGend.Name = "passGend";
            passGend.Size = new Size(170, 28);
            passGend.TabIndex = 56;
            // 
            // passNat
            // 
            passNat.BackColor = SystemColors.GradientInactiveCaption;
            passNat.Font = new Font("Microsoft JhengHei", 12F);
            passNat.FormattingEnabled = true;
            passNat.Items.AddRange(new object[] { "Afghan", "", "Albanian", "", "Algerian", "", "American", "", "Andorran", "", "Angolan", "", "Antiguan", "", "Argentine", "", "Armenian", "", "Australian", "", "Austrian", "", "Azerbaijani", "", "Bahamian", "", "Bahraini", "", "Bangladeshi", "", "Barbadian", "", "Belarusian", "", "Belgian", "", "Belizean", "", "Beninese", "", "Bhutanese", "", "Bolivian", "", "Bosnian", "", "Botswanan", "", "Brazilian", "", "British", "", "Bruneian", "", "Bulgarian", "", "Burkinabe", "", "Burmese", "", "Burundian", "", "Cabo Verdean", "", "Cambodian", "", "Cameroonian", "", "Canadian", "", "Central African", "", "Chadian", "", "Chilean", "", "Chinese", "", "Colombian", "", "Comoran", "", "Congolese (Congo)", "", "Congolese (DRC)", "", "Costa Rican", "", "Croatian", "", "Cuban", "", "Cypriot", "", "Czech", "", "Danish", "", "Djiboutian", "", "Dominican (Dominican Republic)", "", "Dominican (Dominica)", "", "Dutch", "EastTimorese", "", "Ecuadorian", "", "Egyptian", "", "Emirati", "", "Equatorial Guinean", "", "Eritrean", "", "Estonian", "", "Eswatini (Swazi)", "", "Ethiopian", "", "Fijian", "", "Filipino", "", "Finnish", "", "French", "", "Gabonese", "", "Gambian", "", "Georgian", "", "German", "", "Ghanaian", "", "Greek", "", "Grenadian", "", "Guatemalan", "", "Guinean", "", "Guinea-Bissauan", "", "Guyanese", "", "Haitian", "", "Honduran", "", "Hungarian", "", "Icelander", "", "Indian", "", "Indonesian", "", "Iranian", "", "Iraqi", "", "Irish", "", "Israe", "li", "Italian", "", "Ivorian", "", "Jamaican", "", "Japanese", "", "Jordanian", "", "Kazakh", "", "Kenyan", "", "Kiribati", "", "Korean (North)", "", "Korean (South)", "", "Kuwaiti", "", "Kyrgyz", "", "Lao", "Latvian", "", "Lebanese", "", "Liberian", "", "Libyan", "", "Liechtenstein", "", "Lithuanian", "", "Luxembourger", "", "Malagasy", "", "Malawian", "", "Malaysian", "", "Maldivian", "", "", "Namibian", "", "Nauruan", "", "Nepalese", "", "NewZealander", "", "Nicaraguan", "", "Nigerien", "", "Nigerian", "", "Norwegian", "Omani", "", "Pakistani", "", "Palauan", "", "Palestinian", "", "Panamanian", "", "Papua New Guinean", "", "Paraguayan", "", "Yemeni", "", "Zambian", "", "Zimbabwean" });
            passNat.Location = new Point(176, 242);
            passNat.Name = "passNat";
            passNat.Size = new Size(170, 28);
            passNat.TabIndex = 55;
            // 
            // passId
            // 
            passId.BackColor = SystemColors.GradientInactiveCaption;
            passId.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passId.Location = new Point(176, 134);
            passId.MaxLength = 15;
            passId.Name = "passId";
            passId.Size = new Size(170, 29);
            passId.TabIndex = 54;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F);
            label9.ForeColor = Color.Navy;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(17, 136);
            label9.Name = "label9";
            label9.Size = new Size(122, 24);
            label9.TabIndex = 53;
            label9.Text = "Passenger ID";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F);
            label8.ForeColor = Color.Navy;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(375, 244);
            label8.Name = "label8";
            label8.Size = new Size(174, 24);
            label8.TabIndex = 52;
            label8.Text = "Passenger Number";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F);
            label7.ForeColor = Color.Navy;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(375, 190);
            label7.Name = "label7";
            label7.Size = new Size(175, 24);
            label7.TabIndex = 51;
            label7.Text = "Passenger Address";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F);
            label6.ForeColor = Color.Navy;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(384, 136);
            label6.Name = "label6";
            label6.Size = new Size(156, 24);
            label6.TabIndex = 50;
            label6.Text = "Passenger Name";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.ForeColor = Color.Navy;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(31, 244);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 49;
            label5.Text = "Nationality";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.ForeColor = Color.Navy;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(41, 298);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 48;
            label4.Text = "Gender";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.Navy;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(8, 190);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 47;
            label3.Text = "Phone Number";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // button5
            // 
            button5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.SaddleBrown;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.Location = new Point(264, 346);
            button5.Name = "button5";
            button5.Size = new Size(88, 33);
            button5.TabIndex = 64;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.SaddleBrown;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(387, 346);
            button4.Name = "button4";
            button4.Size = new Size(88, 33);
            button4.TabIndex = 63;
            button4.Text = "Reset";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SaddleBrown;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(510, 346);
            button2.Name = "button2";
            button2.Size = new Size(88, 33);
            button2.TabIndex = 62;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.SaddleBrown;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(141, 346);
            button1.Name = "button1";
            button1.Size = new Size(88, 33);
            button1.TabIndex = 61;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // PassDGV
            // 
            PassDGV.AllowUserToOrderColumns = true;
            PassDGV.BackgroundColor = SystemColors.GradientInactiveCaption;
            PassDGV.BorderStyle = BorderStyle.Fixed3D;
            PassDGV.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            PassDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.Padding = new Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            PassDGV.DefaultCellStyle = dataGridViewCellStyle1;
            PassDGV.EditMode = DataGridViewEditMode.EditOnKeystroke;
            PassDGV.Location = new Point(41, 385);
            PassDGV.Margin = new Padding(2);
            PassDGV.Name = "PassDGV";
            PassDGV.RowHeadersWidth = 40;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Meiryo", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(0, 0, 192);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 255, 192);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(0, 0, 192);
            PassDGV.RowsDefaultCellStyle = dataGridViewCellStyle2;
            PassDGV.Size = new Size(644, 344);
            PassDGV.TabIndex = 65;
            PassDGV.CellContentClick += PassDGV_CellContentClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(680, 734);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 66;
            pictureBox1.TabStop = false;
            // 
            // View_Passenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(746, 763);
            Controls.Add(pictureBox1);
            Controls.Add(PassDGV);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(passPort);
            Controls.Add(passAd);
            Controls.Add(passPhone);
            Controls.Add(passName);
            Controls.Add(passGend);
            Controls.Add(passNat);
            Controls.Add(passId);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "View_Passenger";
            Text = "View_Passenger";
            Load += View_Passenger_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PassDGV).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Panel panel1;
        private Button button3;
        private Label label1;
        private TextBox passPort;
        private TextBox passAd;
        private TextBox passPhone;
        private TextBox passName;
        private ComboBox passGend;
        private ComboBox passNat;
        private TextBox passId;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private DataGridView PassDGV;
        private PictureBox pictureBox1;
    }
}