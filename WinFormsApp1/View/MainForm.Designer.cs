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
            ((System.ComponentModel.ISupportInitialize)distanceUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)avarageUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fuelCostUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            distanceUpDown.Size = new Size(57, 23);
            distanceUpDown.TabIndex = 1;
            // 
            // avarageUpDown
            // 
            avarageUpDown.Location = new Point(58, 93);
            avarageUpDown.Name = "avarageUpDown";
            avarageUpDown.Size = new Size(59, 23);
            avarageUpDown.TabIndex = 3;
            avarageUpDown.ValueChanged += numericUpDown2_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 75);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 2;
            label2.Text = "Avarage";
            label2.Click += label2_Click;
            // 
            // fuelCostUpDown
            // 
            fuelCostUpDown.Location = new Point(58, 168);
            fuelCostUpDown.Name = "fuelCostUpDown";
            fuelCostUpDown.Size = new Size(59, 23);
            fuelCostUpDown.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 150);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 4;
            label3.Text = "Fuel Cost ";
            // 
            // button1
            // 
            button1.Location = new Point(125, 168);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Get Result";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(125, 142);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "clear";
            button2.UseVisualStyleBackColor = true;
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
            pictureBox2.Location = new Point(0, 75);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(52, 41);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox3.Location = new Point(0, 153);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(52, 41);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Location = new Point(144, 19);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(36, 15);
            resultLabel.TabIndex = 11;
            resultLabel.Text = "result";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(212, 202);
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
            TopMost = true;
            ((System.ComponentModel.ISupportInitialize)distanceUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)avarageUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)fuelCostUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
    }
}