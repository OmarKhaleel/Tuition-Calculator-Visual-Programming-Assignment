namespace TuitionCalculator
{
    partial class Form1
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumber = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.picBoxPSUT = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblYear = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.gBoxCourses = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.gBoxMajor = new System.Windows.Forms.GroupBox();
            this.rBtnCS = new System.Windows.Forms.RadioButton();
            this.rBtnSoftware = new System.Windows.Forms.RadioButton();
            this.rBtnGraphics = new System.Windows.Forms.RadioButton();
            this.rBtnEng2 = new System.Windows.Forms.RadioButton();
            this.gBoxCollege = new System.Windows.Forms.GroupBox();
            this.rBtnEng = new System.Windows.Forms.RadioButton();
            this.rBtnBusiness = new System.Windows.Forms.RadioButton();
            this.rBtnIT = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPSUT)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gBoxCourses.SuspendLayout();
            this.gBoxMajor.SuspendLayout();
            this.gBoxCollege.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(78, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(78, 114);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(65, 20);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "Number";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(166, 61);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(127, 26);
            this.txtName.TabIndex = 2;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(166, 111);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(127, 26);
            this.txtNumber.TabIndex = 3;
            // 
            // picBoxPSUT
            // 
            this.picBoxPSUT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxPSUT.Image = global::TuitionCalculator.Properties.Resources.PSUT;
            this.picBoxPSUT.Location = new System.Drawing.Point(740, 3);
            this.picBoxPSUT.Name = "picBoxPSUT";
            this.picBoxPSUT.Size = new System.Drawing.Size(203, 261);
            this.picBoxPSUT.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxPSUT.TabIndex = 4;
            this.picBoxPSUT.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit.Location = new System.Drawing.Point(0, 749);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(955, 36);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCalculate);
            this.panel1.Controls.Add(this.lblYear);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.gBoxCourses);
            this.panel1.Controls.Add(this.gBoxMajor);
            this.panel1.Controls.Add(this.gBoxCollege);
            this.panel1.Location = new System.Drawing.Point(53, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(681, 392);
            this.panel1.TabIndex = 17;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(223, 320);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 44);
            this.btnCalculate.TabIndex = 22;
            this.btnCalculate.Text = "Calculate Fees";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(219, 30);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(43, 20);
            this.lblYear.TabIndex = 21;
            this.lblYear.Text = "Year";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(303, 28);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 26);
            this.numericUpDown1.TabIndex = 17;
            // 
            // gBoxCourses
            // 
            this.gBoxCourses.Controls.Add(this.checkBox5);
            this.gBoxCourses.Controls.Add(this.checkBox4);
            this.gBoxCourses.Controls.Add(this.checkBox3);
            this.gBoxCourses.Controls.Add(this.checkBox2);
            this.gBoxCourses.Controls.Add(this.checkBox1);
            this.gBoxCourses.Location = new System.Drawing.Point(466, 61);
            this.gBoxCourses.Name = "gBoxCourses";
            this.gBoxCourses.Size = new System.Drawing.Size(195, 230);
            this.gBoxCourses.TabIndex = 20;
            this.gBoxCourses.TabStop = false;
            this.gBoxCourses.Text = "Courses";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(11, 164);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(113, 24);
            this.checkBox5.TabIndex = 4;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(11, 134);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(113, 24);
            this.checkBox4.TabIndex = 3;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(11, 103);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(113, 24);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(11, 73);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(113, 24);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(11, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // gBoxMajor
            // 
            this.gBoxMajor.Controls.Add(this.rBtnCS);
            this.gBoxMajor.Controls.Add(this.rBtnSoftware);
            this.gBoxMajor.Controls.Add(this.rBtnGraphics);
            this.gBoxMajor.Controls.Add(this.rBtnEng2);
            this.gBoxMajor.Location = new System.Drawing.Point(223, 77);
            this.gBoxMajor.Name = "gBoxMajor";
            this.gBoxMajor.Size = new System.Drawing.Size(200, 204);
            this.gBoxMajor.TabIndex = 19;
            this.gBoxMajor.TabStop = false;
            this.gBoxMajor.Text = "Major";
            // 
            // rBtnCS
            // 
            this.rBtnCS.AutoSize = true;
            this.rBtnCS.Location = new System.Drawing.Point(25, 41);
            this.rBtnCS.Name = "rBtnCS";
            this.rBtnCS.Size = new System.Drawing.Size(56, 24);
            this.rBtnCS.TabIndex = 9;
            this.rBtnCS.TabStop = true;
            this.rBtnCS.Text = "CS";
            this.rBtnCS.UseVisualStyleBackColor = true;
            // 
            // rBtnSoftware
            // 
            this.rBtnSoftware.AutoSize = true;
            this.rBtnSoftware.Location = new System.Drawing.Point(25, 87);
            this.rBtnSoftware.Name = "rBtnSoftware";
            this.rBtnSoftware.Size = new System.Drawing.Size(98, 24);
            this.rBtnSoftware.TabIndex = 10;
            this.rBtnSoftware.TabStop = true;
            this.rBtnSoftware.Text = "Software";
            this.rBtnSoftware.UseVisualStyleBackColor = true;
            // 
            // rBtnGraphics
            // 
            this.rBtnGraphics.AutoSize = true;
            this.rBtnGraphics.Location = new System.Drawing.Point(25, 131);
            this.rBtnGraphics.Name = "rBtnGraphics";
            this.rBtnGraphics.Size = new System.Drawing.Size(98, 24);
            this.rBtnGraphics.TabIndex = 11;
            this.rBtnGraphics.TabStop = true;
            this.rBtnGraphics.Text = "Graphics";
            this.rBtnGraphics.UseVisualStyleBackColor = true;
            // 
            // rBtnEng2
            // 
            this.rBtnEng2.AutoSize = true;
            this.rBtnEng2.Location = new System.Drawing.Point(25, 174);
            this.rBtnEng2.Name = "rBtnEng2";
            this.rBtnEng2.Size = new System.Drawing.Size(119, 24);
            this.rBtnEng2.TabIndex = 12;
            this.rBtnEng2.TabStop = true;
            this.rBtnEng2.Text = "Engineering";
            this.rBtnEng2.UseVisualStyleBackColor = true;
            // 
            // gBoxCollege
            // 
            this.gBoxCollege.Controls.Add(this.rBtnEng);
            this.gBoxCollege.Controls.Add(this.rBtnBusiness);
            this.gBoxCollege.Controls.Add(this.rBtnIT);
            this.gBoxCollege.Location = new System.Drawing.Point(20, 77);
            this.gBoxCollege.Name = "gBoxCollege";
            this.gBoxCollege.Size = new System.Drawing.Size(177, 178);
            this.gBoxCollege.TabIndex = 18;
            this.gBoxCollege.TabStop = false;
            this.gBoxCollege.Text = "College";
            // 
            // rBtnEng
            // 
            this.rBtnEng.AutoSize = true;
            this.rBtnEng.Location = new System.Drawing.Point(20, 71);
            this.rBtnEng.Name = "rBtnEng";
            this.rBtnEng.Size = new System.Drawing.Size(119, 24);
            this.rBtnEng.TabIndex = 6;
            this.rBtnEng.TabStop = true;
            this.rBtnEng.Text = "Engineering";
            this.rBtnEng.UseVisualStyleBackColor = true;
            // 
            // rBtnBusiness
            // 
            this.rBtnBusiness.AutoSize = true;
            this.rBtnBusiness.Location = new System.Drawing.Point(20, 118);
            this.rBtnBusiness.Name = "rBtnBusiness";
            this.rBtnBusiness.Size = new System.Drawing.Size(99, 24);
            this.rBtnBusiness.TabIndex = 7;
            this.rBtnBusiness.TabStop = true;
            this.rBtnBusiness.Text = "Business";
            this.rBtnBusiness.UseVisualStyleBackColor = true;
            // 
            // rBtnIT
            // 
            this.rBtnIT.AutoSize = true;
            this.rBtnIT.Location = new System.Drawing.Point(20, 25);
            this.rBtnIT.Name = "rBtnIT";
            this.rBtnIT.Size = new System.Drawing.Size(48, 24);
            this.rBtnIT.TabIndex = 6;
            this.rBtnIT.TabStop = true;
            this.rBtnIT.Text = "IT";
            this.rBtnIT.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(955, 785);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBoxPSUT);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "PSUT Registration System";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxPSUT)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gBoxCourses.ResumeLayout(false);
            this.gBoxCourses.PerformLayout();
            this.gBoxMajor.ResumeLayout(false);
            this.gBoxMajor.PerformLayout();
            this.gBoxCollege.ResumeLayout(false);
            this.gBoxCollege.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.PictureBox picBoxPSUT;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.GroupBox gBoxCourses;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox gBoxMajor;
        private System.Windows.Forms.RadioButton rBtnCS;
        private System.Windows.Forms.RadioButton rBtnSoftware;
        private System.Windows.Forms.RadioButton rBtnGraphics;
        private System.Windows.Forms.RadioButton rBtnEng2;
        private System.Windows.Forms.GroupBox gBoxCollege;
        private System.Windows.Forms.RadioButton rBtnEng;
        private System.Windows.Forms.RadioButton rBtnBusiness;
        private System.Windows.Forms.RadioButton rBtnIT;
    }
}

