namespace FieldEvaluationOffset
{
    partial class MainForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbMinusZ = new System.Windows.Forms.RadioButton();
            this.rbPlusZ = new System.Windows.Forms.RadioButton();
            this.rbPlusMinusZ = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtShiftZ = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbMinusY = new System.Windows.Forms.RadioButton();
            this.rbPlusY = new System.Windows.Forms.RadioButton();
            this.rbPlusMinusY = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShiftY = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbMinusX = new System.Windows.Forms.RadioButton();
            this.rbPlusX = new System.Windows.Forms.RadioButton();
            this.rbPlusMinusX = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtShiftX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbFieldID = new System.Windows.Forms.ComboBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.pbDoseCalculations = new System.Windows.Forms.ProgressBar();
            this.btnCSItemplate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ClockFinish = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRensa = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbListOfOffsets = new System.Windows.Forms.ListBox();
            this.btnAddField = new System.Windows.Forms.Button();
            this.RensaInput = new System.Windows.Forms.Button();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.cbFieldID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 328);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fält";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbMinusZ);
            this.groupBox6.Controls.Add(this.rbPlusZ);
            this.groupBox6.Controls.Add(this.rbPlusMinusZ);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.txtShiftZ);
            this.groupBox6.Location = new System.Drawing.Point(6, 241);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(156, 76);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            // 
            // rbMinusZ
            // 
            this.rbMinusZ.AutoSize = true;
            this.rbMinusZ.Location = new System.Drawing.Point(110, 48);
            this.rbMinusZ.Name = "rbMinusZ";
            this.rbMinusZ.Size = new System.Drawing.Size(28, 17);
            this.rbMinusZ.TabIndex = 5;
            this.rbMinusZ.TabStop = true;
            this.rbMinusZ.Text = "-";
            this.rbMinusZ.UseVisualStyleBackColor = true;
            // 
            // rbPlusZ
            // 
            this.rbPlusZ.AutoSize = true;
            this.rbPlusZ.Location = new System.Drawing.Point(55, 48);
            this.rbPlusZ.Name = "rbPlusZ";
            this.rbPlusZ.Size = new System.Drawing.Size(31, 17);
            this.rbPlusZ.TabIndex = 4;
            this.rbPlusZ.TabStop = true;
            this.rbPlusZ.Text = "+";
            this.rbPlusZ.UseVisualStyleBackColor = true;
            // 
            // rbPlusMinusZ
            // 
            this.rbPlusMinusZ.AutoSize = true;
            this.rbPlusMinusZ.Location = new System.Drawing.Point(6, 48);
            this.rbPlusMinusZ.Name = "rbPlusMinusZ";
            this.rbPlusMinusZ.Size = new System.Drawing.Size(31, 17);
            this.rbPlusMinusZ.TabIndex = 3;
            this.rbPlusMinusZ.TabStop = true;
            this.rbPlusMinusZ.Text = "±";
            this.rbPlusMinusZ.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Z förflyttningar (mm)";
            // 
            // txtShiftZ
            // 
            this.txtShiftZ.Location = new System.Drawing.Point(124, 19);
            this.txtShiftZ.Name = "txtShiftZ";
            this.txtShiftZ.Size = new System.Drawing.Size(26, 20);
            this.txtShiftZ.TabIndex = 2;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbMinusY);
            this.groupBox4.Controls.Add(this.rbPlusY);
            this.groupBox4.Controls.Add(this.rbPlusMinusY);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.txtShiftY);
            this.groupBox4.Location = new System.Drawing.Point(6, 159);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(156, 76);
            this.groupBox4.TabIndex = 17;
            this.groupBox4.TabStop = false;
            // 
            // rbMinusY
            // 
            this.rbMinusY.AutoSize = true;
            this.rbMinusY.Location = new System.Drawing.Point(110, 48);
            this.rbMinusY.Name = "rbMinusY";
            this.rbMinusY.Size = new System.Drawing.Size(28, 17);
            this.rbMinusY.TabIndex = 5;
            this.rbMinusY.TabStop = true;
            this.rbMinusY.Text = "-";
            this.rbMinusY.UseVisualStyleBackColor = true;
            // 
            // rbPlusY
            // 
            this.rbPlusY.AutoSize = true;
            this.rbPlusY.Location = new System.Drawing.Point(55, 48);
            this.rbPlusY.Name = "rbPlusY";
            this.rbPlusY.Size = new System.Drawing.Size(31, 17);
            this.rbPlusY.TabIndex = 4;
            this.rbPlusY.TabStop = true;
            this.rbPlusY.Text = "+";
            this.rbPlusY.UseVisualStyleBackColor = true;
            // 
            // rbPlusMinusY
            // 
            this.rbPlusMinusY.AutoSize = true;
            this.rbPlusMinusY.Location = new System.Drawing.Point(6, 48);
            this.rbPlusMinusY.Name = "rbPlusMinusY";
            this.rbPlusMinusY.Size = new System.Drawing.Size(31, 17);
            this.rbPlusMinusY.TabIndex = 3;
            this.rbPlusMinusY.TabStop = true;
            this.rbPlusMinusY.Text = "±";
            this.rbPlusMinusY.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y förflyttningar (mm)";
            // 
            // txtShiftY
            // 
            this.txtShiftY.Location = new System.Drawing.Point(124, 19);
            this.txtShiftY.Name = "txtShiftY";
            this.txtShiftY.Size = new System.Drawing.Size(26, 20);
            this.txtShiftY.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbMinusX);
            this.groupBox3.Controls.Add(this.rbPlusX);
            this.groupBox3.Controls.Add(this.rbPlusMinusX);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.txtShiftX);
            this.groupBox3.Location = new System.Drawing.Point(6, 77);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(156, 76);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // rbMinusX
            // 
            this.rbMinusX.AutoSize = true;
            this.rbMinusX.Location = new System.Drawing.Point(110, 48);
            this.rbMinusX.Name = "rbMinusX";
            this.rbMinusX.Size = new System.Drawing.Size(28, 17);
            this.rbMinusX.TabIndex = 5;
            this.rbMinusX.TabStop = true;
            this.rbMinusX.Text = "-";
            this.rbMinusX.UseVisualStyleBackColor = true;
            // 
            // rbPlusX
            // 
            this.rbPlusX.AutoSize = true;
            this.rbPlusX.Location = new System.Drawing.Point(55, 48);
            this.rbPlusX.Name = "rbPlusX";
            this.rbPlusX.Size = new System.Drawing.Size(31, 17);
            this.rbPlusX.TabIndex = 4;
            this.rbPlusX.TabStop = true;
            this.rbPlusX.Text = "+";
            this.rbPlusX.UseVisualStyleBackColor = true;
            // 
            // rbPlusMinusX
            // 
            this.rbPlusMinusX.AutoSize = true;
            this.rbPlusMinusX.Location = new System.Drawing.Point(6, 48);
            this.rbPlusMinusX.Name = "rbPlusMinusX";
            this.rbPlusMinusX.Size = new System.Drawing.Size(31, 17);
            this.rbPlusMinusX.TabIndex = 3;
            this.rbPlusMinusX.TabStop = true;
            this.rbPlusMinusX.Text = "±";
            this.rbPlusMinusX.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "X förflyttningar (mm)";
            // 
            // txtShiftX
            // 
            this.txtShiftX.Location = new System.Drawing.Point(124, 19);
            this.txtShiftX.Name = "txtShiftX";
            this.txtShiftX.Size = new System.Drawing.Size(26, 20);
            this.txtShiftX.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Fält ID";
            // 
            // cbFieldID
            // 
            this.cbFieldID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFieldID.FormattingEnabled = true;
            this.cbFieldID.Location = new System.Drawing.Point(6, 50);
            this.cbFieldID.Name = "cbFieldID";
            this.cbFieldID.Size = new System.Drawing.Size(121, 21);
            this.cbFieldID.TabIndex = 0;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(220, 269);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 60);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Skapa och Räkna";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // pbDoseCalculations
            // 
            this.pbDoseCalculations.Location = new System.Drawing.Point(220, 382);
            this.pbDoseCalculations.Name = "pbDoseCalculations";
            this.pbDoseCalculations.Size = new System.Drawing.Size(370, 60);
            this.pbDoseCalculations.TabIndex = 13;
            // 
            // btnCSItemplate
            // 
            this.btnCSItemplate.Location = new System.Drawing.Point(7, 19);
            this.btnCSItemplate.Name = "btnCSItemplate";
            this.btnCSItemplate.Size = new System.Drawing.Size(140, 23);
            this.btnCSItemplate.TabIndex = 15;
            this.btnCSItemplate.Text = "CSI-förflyttningar";
            this.btnCSItemplate.UseVisualStyleBackColor = true;
            this.btnCSItemplate.Click += new System.EventHandler(this.btnCSItemplate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(221, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Färdig kl:";
            // 
            // ClockFinish
            // 
            this.ClockFinish.AutoSize = true;
            this.ClockFinish.Location = new System.Drawing.Point(272, 355);
            this.ClockFinish.Name = "ClockFinish";
            this.ClockFinish.Size = new System.Drawing.Size(34, 13);
            this.ClockFinish.TabIndex = 17;
            this.ClockFinish.Text = "00:00";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnCSItemplate);
            this.groupBox5.Location = new System.Drawing.Point(439, 260);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(165, 58);
            this.groupBox5.TabIndex = 18;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Mallar";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnRensa);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lbListOfOffsets);
            this.groupBox2.Location = new System.Drawing.Point(220, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 243);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lista över fält";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(129, 13);
            this.label14.TabIndex = 32;
            this.label14.Text = "Fältspecifika Förflyttningar";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(240, 15);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Offset från ISO";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(302, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "z (mm)";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(259, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "y (mm)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(216, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "x (mm)";
            // 
            // btnRensa
            // 
            this.btnRensa.Location = new System.Drawing.Point(262, 212);
            this.btnRensa.Name = "btnRensa";
            this.btnRensa.Size = new System.Drawing.Size(75, 23);
            this.btnRensa.TabIndex = 27;
            this.btnRensa.Text = "Rensa";
            this.btnRensa.UseVisualStyleBackColor = true;
            this.btnRensa.Click += new System.EventHandler(this.btnRensa_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(55, 211);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 26;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(156, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "z (mm)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(113, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "y (mm)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "x (mm)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Fält ID";
            // 
            // lbListOfOffsets
            // 
            this.lbListOfOffsets.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbListOfOffsets.FormattingEnabled = true;
            this.lbListOfOffsets.ItemHeight = 14;
            this.lbListOfOffsets.Location = new System.Drawing.Point(7, 47);
            this.lbListOfOffsets.Name = "lbListOfOffsets";
            this.lbListOfOffsets.Size = new System.Drawing.Size(371, 158);
            this.lbListOfOffsets.TabIndex = 0;
            // 
            // btnAddField
            // 
            this.btnAddField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddField.Location = new System.Drawing.Point(18, 382);
            this.btnAddField.Name = "btnAddField";
            this.btnAddField.Size = new System.Drawing.Size(105, 36);
            this.btnAddField.TabIndex = 20;
            this.btnAddField.Text = "lägg till Fält";
            this.btnAddField.UseVisualStyleBackColor = true;
            this.btnAddField.Click += new System.EventHandler(this.btnAddField_Click);
            // 
            // RensaInput
            // 
            this.RensaInput.Location = new System.Drawing.Point(18, 346);
            this.RensaInput.Name = "RensaInput";
            this.RensaInput.Size = new System.Drawing.Size(75, 23);
            this.RensaInput.TabIndex = 21;
            this.RensaInput.Text = "Rensa";
            this.RensaInput.UseVisualStyleBackColor = true;
            this.RensaInput.Click += new System.EventHandler(this.RensaInput_Click);
            // 
            // lblProgress
            // 
            this.lblProgress.Location = new System.Drawing.Point(490, 355);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(100, 19);
            this.lblProgress.TabIndex = 22;
            this.lblProgress.Text = "Progress";
            this.lblProgress.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 471);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.RensaInput);
            this.Controls.Add(this.btnAddField);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.ClockFinish);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pbDoseCalculations);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Fältspecifika förflyttningar (v 1.7 av Erik & Christina)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtShiftX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFieldID;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ProgressBar pbDoseCalculations;
        private System.Windows.Forms.Button btnCSItemplate;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label ClockFinish;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lbListOfOffsets;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.RadioButton rbMinusZ;
        private System.Windows.Forms.RadioButton rbPlusZ;
        private System.Windows.Forms.RadioButton rbPlusMinusZ;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtShiftZ;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbMinusY;
        private System.Windows.Forms.RadioButton rbPlusY;
        private System.Windows.Forms.RadioButton rbPlusMinusY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShiftY;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbMinusX;
        private System.Windows.Forms.RadioButton rbPlusX;
        private System.Windows.Forms.RadioButton rbPlusMinusX;
        private System.Windows.Forms.Button btnAddField;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRensa;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RensaInput;
        private System.Windows.Forms.Label lblProgress;
    }
}

