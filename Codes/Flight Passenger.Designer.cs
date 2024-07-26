namespace Project_Airline_Management_System
{
    partial class Flight_Passenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Flight_Passenger));
            panel1 = new Panel();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            button1 = new Button();
            passId = new TextBox();
            passNat = new ComboBox();
            passGend = new ComboBox();
            passName = new TextBox();
            passPhone = new TextBox();
            passAd = new TextBox();
            passPort = new TextBox();
            button2 = new Button();
            button4 = new Button();
            button5 = new Button();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.GradientInactiveCaption;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(866, 46);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.GradientInactiveCaption;
            button3.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            button3.ForeColor = Color.MediumBlue;
            button3.Location = new Point(820, 3);
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
            label1.Location = new Point(239, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 30);
            label1.TabIndex = 26;
            label1.Text = "Airline Management System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Garamond", 20.25F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = Color.Navy;
            label2.Image = (Image)resources.GetObject("label2.Image");
            label2.ImageAlign = ContentAlignment.TopLeft;
            label2.Location = new Point(294, 49);
            label2.Name = "label2";
            label2.Size = new Size(231, 30);
            label2.TabIndex = 27;
            label2.Text = "Record Passengers";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.GradientInactiveCaption;
            label3.Font = new Font("Microsoft Sans Serif", 14.25F);
            label3.ForeColor = Color.Navy;
            label3.Image = (Image)resources.GetObject("label3.Image");
            label3.ImageAlign = ContentAlignment.TopLeft;
            label3.Location = new Point(3, 207);
            label3.Name = "label3";
            label3.Size = new Size(140, 24);
            label3.TabIndex = 28;
            label3.Text = "Phone Number";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.GradientInactiveCaption;
            label4.Font = new Font("Microsoft Sans Serif", 14.25F);
            label4.ForeColor = Color.Navy;
            label4.Image = (Image)resources.GetObject("label4.Image");
            label4.ImageAlign = ContentAlignment.TopLeft;
            label4.Location = new Point(36, 325);
            label4.Name = "label4";
            label4.Size = new Size(74, 24);
            label4.TabIndex = 29;
            label4.Text = "Gender";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.GradientInactiveCaption;
            label5.Font = new Font("Microsoft Sans Serif", 14.25F);
            label5.ForeColor = Color.Navy;
            label5.Image = (Image)resources.GetObject("label5.Image");
            label5.ImageAlign = ContentAlignment.TopLeft;
            label5.Location = new Point(26, 266);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 30;
            label5.Text = "Nationality";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = SystemColors.GradientInactiveCaption;
            label6.Font = new Font("Microsoft Sans Serif", 14.25F);
            label6.ForeColor = Color.Navy;
            label6.Image = (Image)resources.GetObject("label6.Image");
            label6.ImageAlign = ContentAlignment.TopLeft;
            label6.Location = new Point(436, 149);
            label6.Name = "label6";
            label6.Size = new Size(156, 24);
            label6.TabIndex = 31;
            label6.Text = "Passenger Name";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = SystemColors.GradientInactiveCaption;
            label7.Font = new Font("Microsoft Sans Serif", 14.25F);
            label7.ForeColor = Color.Navy;
            label7.Image = (Image)resources.GetObject("label7.Image");
            label7.ImageAlign = ContentAlignment.TopLeft;
            label7.Location = new Point(427, 209);
            label7.Name = "label7";
            label7.Size = new Size(175, 24);
            label7.TabIndex = 32;
            label7.Text = "Passenger Address";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = SystemColors.GradientInactiveCaption;
            label8.Font = new Font("Microsoft Sans Serif", 14.25F);
            label8.ForeColor = Color.Navy;
            label8.Image = (Image)resources.GetObject("label8.Image");
            label8.ImageAlign = ContentAlignment.TopLeft;
            label8.Location = new Point(427, 269);
            label8.Name = "label8";
            label8.Size = new Size(174, 24);
            label8.TabIndex = 33;
            label8.Text = "Passenger Number";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = SystemColors.GradientInactiveCaption;
            label9.Font = new Font("Microsoft Sans Serif", 14.25F);
            label9.ForeColor = Color.Navy;
            label9.Image = (Image)resources.GetObject("label9.Image");
            label9.ImageAlign = ContentAlignment.TopLeft;
            label9.Location = new Point(12, 148);
            label9.Name = "label9";
            label9.Size = new Size(122, 24);
            label9.TabIndex = 34;
            label9.Text = "Passenger ID";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = Color.SaddleBrown;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleRight;
            button1.Location = new Point(229, 384);
            button1.Name = "button1";
            button1.Size = new Size(125, 33);
            button1.TabIndex = 35;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // passId
            // 
            passId.BackColor = SystemColors.GradientInactiveCaption;
            passId.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passId.Location = new Point(171, 146);
            passId.MaxLength = 15;
            passId.Name = "passId";
            passId.PlaceholderText = "Enter ID";
            passId.Size = new Size(216, 29);
            passId.TabIndex = 40;
            // 
            // passNat
            // 
            passNat.BackColor = SystemColors.GradientInactiveCaption;
            passNat.Font = new Font("Microsoft JhengHei", 12F);
            passNat.FormattingEnabled = true;
            passNat.Items.AddRange(new object[] { "Afghan", "", "Albanian", "", "Algerian", "", "American", "", "Andorran", "", "Angolan", "", "Antiguan", "", "Argentine", "", "Armenian", "", "Australian", "", "Austrian", "", "Azerbaijani", "", "Bahamian", "", "Bahraini", "", "Bangladeshi", "", "Barbadian", "", "Belarusian", "", "Belgian", "", "Belizean", "", "Beninese", "", "Bhutanese", "", "Bolivian", "", "Bosnian", "", "Botswanan", "", "Brazilian", "", "British", "", "Bruneian", "", "Bulgarian", "", "Burkinabe", "", "Burmese", "", "Burundian", "", "Cabo Verdean", "", "Cambodian", "", "Cameroonian", "", "Canadian", "", "Central African", "", "Chadian", "", "Chilean", "", "Chinese", "", "Colombian", "", "Comoran", "", "Congolese (Congo)", "", "Congolese (DRC)", "", "Costa Rican", "", "Croatian", "", "Cuban", "", "Cypriot", "", "Czech", "", "Danish", "", "Djiboutian", "", "Dominican (Dominican Republic)", "", "Dominican (Dominica)", "", "Dutch", "EastTimorese", "", "Ecuadorian", "", "Egyptian", "", "Emirati", "", "Equatorial Guinean", "", "Eritrean", "", "Estonian", "", "Eswatini (Swazi)", "", "Ethiopian", "", "Fijian", "", "Filipino", "", "Finnish", "", "French", "", "Gabonese", "", "Gambian", "", "Georgian", "", "German", "", "Ghanaian", "", "Greek", "", "Grenadian", "", "Guatemalan", "", "Guinean", "", "Guinea-Bissauan", "", "Guyanese", "", "Haitian", "", "Honduran", "", "Hungarian", "", "Icelander", "", "Indian", "", "Indonesian", "", "Iranian", "", "Iraqi", "", "Irish", "", "Israe", "li", "Italian", "", "Ivorian", "", "Jamaican", "", "Japanese", "", "Jordanian", "", "Kazakh", "", "Kenyan", "", "Kiribati", "", "Korean (North)", "", "Korean (South)", "", "Kuwaiti", "", "Kyrgyz", "", "Lao", "Latvian", "", "Lebanese", "", "Liberian", "", "Libyan", "", "Liechtenstein", "", "Lithuanian", "", "Luxembourger", "", "Malagasy", "", "Malawian", "", "Malaysian", "", "Maldivian", "", "", "Namibian", "", "Nauruan", "", "Nepalese", "", "NewZealander", "", "Nicaraguan", "", "Nigerien", "", "Nigerian", "", "Norwegian", "Omani", "", "Pakistani", "", "Palauan", "", "Palestinian", "", "Panamanian", "", "Papua New Guinean", "", "Paraguayan", "", "Yemeni", "", "Zambian", "", "Zimbabwean" });
            passNat.Location = new Point(171, 266);
            passNat.Name = "passNat";
            passNat.Size = new Size(216, 28);
            passNat.TabIndex = 41;
            passNat.Text = "Choose Your Nationality";
            // 
            // passGend
            // 
            passGend.BackColor = SystemColors.GradientInactiveCaption;
            passGend.Font = new Font("Microsoft JhengHei", 12F);
            passGend.FormattingEnabled = true;
            passGend.Items.AddRange(new object[] { "Male", "Female" });
            passGend.Location = new Point(171, 325);
            passGend.Name = "passGend";
            passGend.Size = new Size(216, 28);
            passGend.TabIndex = 42;
            passGend.Text = "Choose Gender";
            // 
            // passName
            // 
            passName.BackColor = SystemColors.GradientInactiveCaption;
            passName.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passName.Location = new Point(614, 147);
            passName.MaxLength = 15;
            passName.Name = "passName";
            passName.PlaceholderText = "Enter Name";
            passName.Size = new Size(210, 29);
            passName.TabIndex = 43;
            // 
            // passPhone
            // 
            passPhone.BackColor = SystemColors.GradientInactiveCaption;
            passPhone.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPhone.Location = new Point(171, 206);
            passPhone.MaxLength = 15;
            passPhone.Name = "passPhone";
            passPhone.PlaceholderText = "Enter Phone Number";
            passPhone.Size = new Size(216, 29);
            passPhone.TabIndex = 44;
            // 
            // passAd
            // 
            passAd.BackColor = SystemColors.GradientInactiveCaption;
            passAd.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passAd.Location = new Point(614, 207);
            passAd.MaxLength = 15;
            passAd.Name = "passAd";
            passAd.PlaceholderText = "Enter Address";
            passAd.Size = new Size(210, 29);
            passAd.TabIndex = 45;
            // 
            // passPort
            // 
            passPort.BackColor = SystemColors.GradientInactiveCaption;
            passPort.Font = new Font("Microsoft JhengHei", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            passPort.Location = new Point(614, 267);
            passPort.MaxLength = 15;
            passPort.Name = "passPort";
            passPort.PlaceholderText = "Enter Passenger Num";
            passPort.Size = new Size(210, 29);
            passPort.TabIndex = 46;
            // 
            // button2
            // 
            button2.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button2.ForeColor = Color.SaddleBrown;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.ImageAlign = ContentAlignment.MiddleRight;
            button2.Location = new Point(369, 384);
            button2.Name = "button2";
            button2.Size = new Size(125, 33);
            button2.TabIndex = 47;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button4
            // 
            button4.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button4.ForeColor = Color.SaddleBrown;
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.TopRight;
            button4.Location = new Point(509, 384);
            button4.Name = "button4";
            button4.Size = new Size(174, 33);
            button4.TabIndex = 48;
            button4.Text = "View Passenger";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Font = new Font("Garamond", 15.75F, FontStyle.Bold | FontStyle.Italic);
            button5.ForeColor = Color.SaddleBrown;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleRight;
            button5.Location = new Point(698, 384);
            button5.Name = "button5";
            button5.Size = new Size(125, 33);
            button5.TabIndex = 49;
            button5.Text = "Back";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(803, 423);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(63, 25);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 50;
            pictureBox1.TabStop = false;
            // 
            // Flight_Passenger
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(866, 446);
            Controls.Add(pictureBox1);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button2);
            Controls.Add(passPort);
            Controls.Add(passAd);
            Controls.Add(passPhone);
            Controls.Add(passName);
            Controls.Add(passGend);
            Controls.Add(passNat);
            Controls.Add(passId);
            Controls.Add(button1);
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
            Name = "Flight_Passenger";
            Text = "Flight_Passenger";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button button3;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button button1;
        private TextBox passId;
        private ComboBox passNat;
        private ComboBox passGend;
        private TextBox passName;
        private TextBox passPhone;
        private TextBox passAd;
        private TextBox passPort;
        private Button button2;
        private Button button4;
        private Button button5;
        private PictureBox pictureBox1;
    }
}