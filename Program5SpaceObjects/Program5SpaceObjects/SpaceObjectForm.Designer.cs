namespace Program5SpaceObjects
{
    partial class SpaceObjectForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpaceObjectForm));
            CreateSOBtn = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            SampleBox = new TextBox();
            label18 = new Label();
            TempBox = new TextBox();
            label13 = new Label();
            InstantObjectBtn = new Button();
            moonBox = new TextBox();
            SpeedBox = new TextBox();
            PLBox = new TextBox();
            HeightBox = new TextBox();
            ArmBox = new TextBox();
            RadBox = new TextBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            NameBox = new TextBox();
            NameLab = new Label();
            ZBox = new TextBox();
            YBox = new TextBox();
            XBox = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            TypeBox = new TextBox();
            TypeBtn = new Button();
            label12 = new Label();
            groupBox2 = new GroupBox();
            SpaceObjectReadout = new Label();
            pictureBox1 = new PictureBox();
            groupBox3 = new GroupBox();
            MoveBtn = new Button();
            groupBox4 = new GroupBox();
            RotateBtn = new Button();
            groupBox5 = new GroupBox();
            ClassificationBtn = new Button();
            groupBox6 = new GroupBox();
            SampleBtn = new Button();
            groupBox7 = new GroupBox();
            NewZBox = new TextBox();
            NewYBox = new TextBox();
            NewXBox = new TextBox();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            label14 = new Label();
            TravelTimeBtn = new Button();
            ObjectActionLabel = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            groupBox7.SuspendLayout();
            SuspendLayout();
            // 
            // CreateSOBtn
            // 
            CreateSOBtn.Location = new Point(22, 29);
            CreateSOBtn.Name = "CreateSOBtn";
            CreateSOBtn.Size = new Size(193, 29);
            CreateSOBtn.TabIndex = 0;
            CreateSOBtn.Text = "Create new Space Object";
            CreateSOBtn.UseVisualStyleBackColor = true;
            CreateSOBtn.Click += CreateSOBtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 34);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "Type";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SampleBox);
            groupBox1.Controls.Add(label18);
            groupBox1.Controls.Add(TempBox);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(InstantObjectBtn);
            groupBox1.Controls.Add(moonBox);
            groupBox1.Controls.Add(SpeedBox);
            groupBox1.Controls.Add(PLBox);
            groupBox1.Controls.Add(HeightBox);
            groupBox1.Controls.Add(ArmBox);
            groupBox1.Controls.Add(RadBox);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(NameBox);
            groupBox1.Controls.Add(NameLab);
            groupBox1.Controls.Add(ZBox);
            groupBox1.Controls.Add(YBox);
            groupBox1.Controls.Add(XBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(TypeBox);
            groupBox1.Controls.Add(TypeBtn);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(531, 286);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "SpaceObject Parameters";
            // 
            // SampleBox
            // 
            SampleBox.Location = new Point(357, 179);
            SampleBox.Name = "SampleBox";
            SampleBox.Size = new Size(64, 27);
            SampleBox.TabIndex = 28;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(283, 182);
            label18.Name = "label18";
            label18.Size = new Size(68, 20);
            label18.TabIndex = 27;
            label18.Text = "Samples:";
            // 
            // TempBox
            // 
            TempBox.Location = new Point(275, 143);
            TempBox.Name = "TempBox";
            TempBox.Size = new Size(64, 27);
            TempBox.TabIndex = 26;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(173, 146);
            label13.Name = "label13";
            label13.Size = new Size(96, 20);
            label13.TabIndex = 25;
            label13.Text = "Temperature:";
            // 
            // InstantObjectBtn
            // 
            InstantObjectBtn.Location = new Point(189, 250);
            InstantObjectBtn.Name = "InstantObjectBtn";
            InstantObjectBtn.Size = new Size(125, 30);
            InstantObjectBtn.TabIndex = 24;
            InstantObjectBtn.Text = "Instantiate";
            InstantObjectBtn.UseVisualStyleBackColor = true;
            InstantObjectBtn.Click += InstantObjectBtn_Click;
            // 
            // moonBox
            // 
            moonBox.Location = new Point(346, 220);
            moonBox.Name = "moonBox";
            moonBox.Size = new Size(64, 27);
            moonBox.TabIndex = 23;
            // 
            // SpeedBox
            // 
            SpeedBox.Location = new Point(217, 217);
            SpeedBox.Name = "SpeedBox";
            SpeedBox.Size = new Size(64, 27);
            SpeedBox.TabIndex = 20;
            // 
            // PLBox
            // 
            PLBox.Location = new Point(86, 217);
            PLBox.Name = "PLBox";
            PLBox.Size = new Size(64, 27);
            PLBox.TabIndex = 22;
            // 
            // HeightBox
            // 
            HeightBox.Location = new Point(205, 179);
            HeightBox.Name = "HeightBox";
            HeightBox.Size = new Size(64, 27);
            HeightBox.TabIndex = 21;
            // 
            // ArmBox
            // 
            ArmBox.Location = new Point(68, 179);
            ArmBox.Name = "ArmBox";
            ArmBox.Size = new Size(64, 27);
            ArmBox.TabIndex = 20;
            // 
            // RadBox
            // 
            RadBox.Location = new Point(78, 143);
            RadBox.Name = "RadBox";
            RadBox.Size = new Size(89, 27);
            RadBox.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(283, 220);
            label11.Name = "label11";
            label11.Size = new Size(57, 20);
            label11.TabIndex = 18;
            label11.Text = "Moons:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(157, 220);
            label10.Name = "label10";
            label10.Size = new Size(54, 20);
            label10.TabIndex = 17;
            label10.Text = "Speed:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(16, 220);
            label9.Name = "label9";
            label9.Size = new Size(64, 20);
            label9.TabIndex = 16;
            label9.Text = "Payload:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(142, 182);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 15;
            label8.Text = "Height:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(16, 182);
            label7.Name = "label7";
            label7.Size = new Size(46, 20);
            label7.TabIndex = 14;
            label7.Text = "Arms:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 146);
            label6.Name = "label6";
            label6.Size = new Size(56, 20);
            label6.TabIndex = 13;
            label6.Text = "Radius:";
            // 
            // NameBox
            // 
            NameBox.Location = new Point(74, 74);
            NameBox.Name = "NameBox";
            NameBox.Size = new Size(150, 27);
            NameBox.TabIndex = 12;
            // 
            // NameLab
            // 
            NameLab.AutoSize = true;
            NameLab.Location = new Point(16, 77);
            NameLab.Name = "NameLab";
            NameLab.Size = new Size(52, 20);
            NameLab.TabIndex = 11;
            NameLab.Text = "Name:";
            // 
            // ZBox
            // 
            ZBox.Location = new Point(281, 107);
            ZBox.Name = "ZBox";
            ZBox.Size = new Size(49, 27);
            ZBox.TabIndex = 10;
            // 
            // YBox
            // 
            YBox.Location = new Point(199, 107);
            YBox.Name = "YBox";
            YBox.Size = new Size(49, 27);
            YBox.TabIndex = 9;
            // 
            // XBox
            // 
            XBox.Location = new Point(118, 107);
            XBox.Name = "XBox";
            XBox.Size = new Size(49, 27);
            XBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(254, 110);
            label5.Name = "label5";
            label5.Size = new Size(21, 20);
            label5.TabIndex = 7;
            label5.Text = "Z:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(173, 110);
            label4.Name = "label4";
            label4.Size = new Size(20, 20);
            label4.TabIndex = 6;
            label4.Text = "Y:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(91, 110);
            label3.Name = "label3";
            label3.Size = new Size(21, 20);
            label3.TabIndex = 5;
            label3.Text = "X:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 110);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 4;
            label2.Text = "Location:";
            // 
            // TypeBox
            // 
            TypeBox.Location = new Point(62, 31);
            TypeBox.Name = "TypeBox";
            TypeBox.Size = new Size(121, 27);
            TypeBox.TabIndex = 3;
            // 
            // TypeBtn
            // 
            TypeBtn.Location = new Point(189, 31);
            TypeBtn.Name = "TypeBtn";
            TypeBtn.Size = new Size(81, 26);
            TypeBtn.TabIndex = 2;
            TypeBtn.Text = "Next";
            TypeBtn.UseVisualStyleBackColor = true;
            TypeBtn.Click += TypeBtn_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(24, 367);
            label12.Name = "label12";
            label12.Size = new Size(361, 120);
            label12.TabIndex = 3;
            label12.Text = resources.GetString("label12.Text");
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(ObjectActionLabel);
            groupBox2.Controls.Add(SpaceObjectReadout);
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Location = new Point(567, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(280, 286);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Space Object";
            // 
            // SpaceObjectReadout
            // 
            SpaceObjectReadout.AutoSize = true;
            SpaceObjectReadout.Location = new Point(31, 38);
            SpaceObjectReadout.Name = "SpaceObjectReadout";
            SpaceObjectReadout.Size = new Size(0, 20);
            SpaceObjectReadout.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(141, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 166);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(MoveBtn);
            groupBox3.Location = new Point(567, 367);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(130, 120);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Move";
            // 
            // MoveBtn
            // 
            MoveBtn.Location = new Point(31, 46);
            MoveBtn.Name = "MoveBtn";
            MoveBtn.Size = new Size(73, 26);
            MoveBtn.TabIndex = 0;
            MoveBtn.Text = "Move";
            MoveBtn.UseVisualStyleBackColor = true;
            MoveBtn.Click += MoveBtn_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(RotateBtn);
            groupBox4.Location = new Point(717, 367);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(130, 120);
            groupBox4.TabIndex = 6;
            groupBox4.TabStop = false;
            groupBox4.Text = "Rotate Planet";
            // 
            // RotateBtn
            // 
            RotateBtn.Location = new Point(31, 46);
            RotateBtn.Name = "RotateBtn";
            RotateBtn.Size = new Size(73, 26);
            RotateBtn.TabIndex = 0;
            RotateBtn.Text = "Rotate";
            RotateBtn.UseVisualStyleBackColor = true;
            RotateBtn.Click += RotateBtn_Click;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(ClassificationBtn);
            groupBox5.Location = new Point(866, 64);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(144, 102);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Find Star Class";
            // 
            // ClassificationBtn
            // 
            ClassificationBtn.Location = new Point(31, 44);
            ClassificationBtn.Name = "ClassificationBtn";
            ClassificationBtn.Size = new Size(73, 26);
            ClassificationBtn.TabIndex = 0;
            ClassificationBtn.Text = "Classify";
            ClassificationBtn.UseVisualStyleBackColor = true;
            ClassificationBtn.Click += ClassificationBtn_Click;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(SampleBtn);
            groupBox6.Location = new Point(866, 174);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(144, 102);
            groupBox6.TabIndex = 8;
            groupBox6.TabStop = false;
            groupBox6.Text = "Take Sample";
            // 
            // SampleBtn
            // 
            SampleBtn.Location = new Point(31, 46);
            SampleBtn.Name = "SampleBtn";
            SampleBtn.Size = new Size(73, 26);
            SampleBtn.TabIndex = 0;
            SampleBtn.Text = "Sample";
            SampleBtn.UseVisualStyleBackColor = true;
            SampleBtn.Click += SampleBtn_Click;
            // 
            // groupBox7
            // 
            groupBox7.Controls.Add(NewZBox);
            groupBox7.Controls.Add(NewYBox);
            groupBox7.Controls.Add(NewXBox);
            groupBox7.Controls.Add(label17);
            groupBox7.Controls.Add(label16);
            groupBox7.Controls.Add(label15);
            groupBox7.Controls.Add(label14);
            groupBox7.Controls.Add(TravelTimeBtn);
            groupBox7.Location = new Point(866, 284);
            groupBox7.Name = "groupBox7";
            groupBox7.Size = new Size(144, 203);
            groupBox7.TabIndex = 9;
            groupBox7.TabStop = false;
            groupBox7.Text = "Find Travel Time";
            // 
            // NewZBox
            // 
            NewZBox.Location = new Point(47, 125);
            NewZBox.Name = "NewZBox";
            NewZBox.Size = new Size(65, 27);
            NewZBox.TabIndex = 7;
            // 
            // NewYBox
            // 
            NewYBox.Location = new Point(47, 93);
            NewYBox.Name = "NewYBox";
            NewYBox.Size = new Size(65, 27);
            NewYBox.TabIndex = 6;
            // 
            // NewXBox
            // 
            NewXBox.Location = new Point(47, 60);
            NewXBox.Name = "NewXBox";
            NewXBox.Size = new Size(65, 27);
            NewXBox.TabIndex = 5;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(20, 130);
            label17.Name = "label17";
            label17.Size = new Size(21, 20);
            label17.TabIndex = 4;
            label17.Text = "Z:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(20, 96);
            label16.Name = "label16";
            label16.Size = new Size(20, 20);
            label16.TabIndex = 3;
            label16.Text = "Y:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(20, 62);
            label15.Name = "label15";
            label15.Size = new Size(21, 20);
            label15.TabIndex = 2;
            label15.Text = "X:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(16, 30);
            label14.Name = "label14";
            label14.Size = new Size(122, 20);
            label14.TabIndex = 1;
            label14.Text = "New Destination:";
            // 
            // TravelTimeBtn
            // 
            TravelTimeBtn.Location = new Point(31, 171);
            TravelTimeBtn.Name = "TravelTimeBtn";
            TravelTimeBtn.Size = new Size(79, 26);
            TravelTimeBtn.TabIndex = 0;
            TravelTimeBtn.Text = "Calculate";
            TravelTimeBtn.UseVisualStyleBackColor = true;
            TravelTimeBtn.Click += TravelTimeBtn_Click;
            // 
            // ObjectActionLabel
            // 
            ObjectActionLabel.AutoSize = true;
            ObjectActionLabel.Location = new Point(20, 230);
            ObjectActionLabel.Name = "ObjectActionLabel";
            ObjectActionLabel.Size = new Size(0, 20);
            ObjectActionLabel.TabIndex = 6;
            // 
            // SpaceObjectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1039, 516);
            Controls.Add(groupBox7);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(label12);
            Controls.Add(groupBox1);
            Controls.Add(CreateSOBtn);
            Name = "SpaceObjectForm";
            Text = "Space Objects";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox7.ResumeLayout(false);
            groupBox7.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CreateSOBtn;
        private Label label1;
        private GroupBox groupBox1;
        private Button TypeBtn;
        private TextBox TypeBox;
        private Label label2;
        private TextBox ZBox;
        private TextBox YBox;
        private TextBox XBox;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private TextBox NameBox;
        private Label NameLab;
        private TextBox moonBox;
        private TextBox SpeedBox;
        private TextBox PLBox;
        private TextBox HeightBox;
        private TextBox ArmBox;
        private TextBox RadBox;
        private Label label11;
        private Label label10;
        private Label label12;
        private Button InstantObjectBtn;
        private Label label13;
        private TextBox TempBox;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label SpaceObjectReadout;
        private GroupBox groupBox3;
        private Button MoveBtn;
        private GroupBox groupBox4;
        private Button RotateBtn;
        private GroupBox groupBox5;
        private Button ClassificationBtn;
        private GroupBox groupBox6;
        private Button SampleBtn;
        private GroupBox groupBox7;
        private Button TravelTimeBtn;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private TextBox NewZBox;
        private TextBox NewYBox;
        private TextBox NewXBox;
        private TextBox SampleBox;
        private Label label18;
        private Label ObjectActionLabel;
    }
}
