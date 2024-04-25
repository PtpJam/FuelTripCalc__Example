namespace WinFormsApp1
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            label1 = new Label();
            distanceUpDown = new NumericUpDown();
            avarageUpDown = new NumericUpDown();
            label2 = new Label();
            fuelCostUpDown = new NumericUpDown();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            resultLabel = new Label();
            pictureBox4 = new PictureBox();
            label4 = new Label();
            markTextBox = new TextBox();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            carMarkTextBox = new TextBox();
            modelTextBox = new TextBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            pictureBox7 = new PictureBox();
            label7 = new Label();
            engineUpDown = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)distanceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avarageUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fuelCostUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)engineUpDown).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 7);
            label1.Name = "label1";
            label1.Size = new Size(52, 15);
            label1.TabIndex = 0;
            label1.Text = "Distance";
            // 
            // distanceUpDown
            // 
            distanceUpDown.Location = new Point(58, 25);
            distanceUpDown.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            distanceUpDown.Name = "distanceUpDown";
            distanceUpDown.Size = new Size(75, 23);
            distanceUpDown.TabIndex = 1;
            // 
            // avarageUpDown
            // 
            avarageUpDown.Location = new Point(202, 25);
            avarageUpDown.Name = "avarageUpDown";
            avarageUpDown.Size = new Size(75, 23);
            avarageUpDown.TabIndex = 3;
            avarageUpDown.ValueChanged += numericUpDown2_ValueChanged;
            avarageUpDown.MouseClick += avarageUpDown_MouseClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(202, 7);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Avarage";
            label2.Click += label2_Click;
            // 
            // fuelCostUpDown
            // 
            fuelCostUpDown.Location = new Point(360, 22);
            fuelCostUpDown.Name = "fuelCostUpDown";
            fuelCostUpDown.Size = new Size(59, 23);
            fuelCostUpDown.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(302, 4);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Fuel Cost ";
            // 
            // button1
            // 
            button1.Location = new Point(12, 167);
            button1.Name = "button1";
            button1.Size = new Size(75, 83);
            button1.TabIndex = 6;
            button1.Text = "Get Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(12, 121);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 41);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox2.Location = new Point(144, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 41);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(302, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 41);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(184, 179);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(36, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "result";
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox4.Location = new Point(0, 74);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(52, 41);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 74);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 12;
            label4.Text = "carMark";
            // 
            // markTextBox
            // 
            markTextBox.Location = new Point(58, 92);
            markTextBox.Name = "markTextBox";
            markTextBox.Size = new Size(75, 23);
            markTextBox.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 74);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 12;
            label5.Text = "carMark";
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImage = (Image)resources.GetObject("pictureBox5.BackgroundImage");
            pictureBox5.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox5.Location = new Point(0, 74);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(52, 41);
            pictureBox5.TabIndex = 14;
            pictureBox5.TabStop = false;
            // 
            // carMarkTextBox
            // 
            carMarkTextBox.Location = new Point(58, 92);
            carMarkTextBox.Name = "carMarkTextBox";
            carMarkTextBox.Size = new Size(75, 23);
            carMarkTextBox.TabIndex = 15;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(202, 92);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(75, 23);
            modelTextBox.TabIndex = 18;
            // 
            // pictureBox6
            // 
            pictureBox6.BackgroundImage = (Image)resources.GetObject("pictureBox6.BackgroundImage");
            pictureBox6.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox6.Location = new Point(144, 74);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(52, 41);
            pictureBox6.TabIndex = 17;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(202, 74);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 16;
            label6.Text = "carModel";
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = (Image)resources.GetObject("pictureBox7.BackgroundImage");
            pictureBox7.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox7.Location = new Point(302, 74);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(52, 41);
            pictureBox7.TabIndex = 20;
            pictureBox7.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 74);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 19;
            label7.Text = "carEngine";
            // 
            // engineUpDown
            // 
            engineUpDown.Location = new Point(360, 93);
            engineUpDown.Name = "engineUpDown";
            engineUpDown.Size = new Size(59, 23);
            engineUpDown.TabIndex = 21;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 262);
            Controls.Add(engineUpDown);
            Controls.Add(pictureBox7);
            Controls.Add(label7);
            Controls.Add(modelTextBox);
            Controls.Add(pictureBox6);
            Controls.Add(label6);
            Controls.Add(carMarkTextBox);
            Controls.Add(pictureBox5);
            Controls.Add(markTextBox);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label4);
            Controls.Add(resultLabel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(fuelCostUpDown);
            Controls.Add(label3);
            Controls.Add(avarageUpDown);
            Controls.Add(label2);
            Controls.Add(distanceUpDown);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Trip Calc ";
            ((System.ComponentModel.ISupportInitialize)distanceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)avarageUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fuelCostUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)engineUpDown).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private NumericUpDown distanceUpDown;
        private NumericUpDown avarageUpDown;
        private Label label2;
        private NumericUpDown fuelCostUpDown;
        private Label label3;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label resultLabel;
        private PictureBox pictureBox4;
        private Label label4;
        private TextBox markTextBox;
        private Label label5;
        private PictureBox pictureBox5;
        private TextBox carMarkTextBox;
        private TextBox modelTextBox;
        private PictureBox pictureBox6;
        private Label label6;
        private PictureBox pictureBox7;
        private Label label7;
        private NumericUpDown engineUpDown;
    }
}