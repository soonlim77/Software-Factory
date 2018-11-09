﻿namespace JustInTimeShippingForm
{
    partial class JustInTimeShippingForm
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
            this.cbPackageType = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkInsurance = new System.Windows.Forms.CheckBox();
            this.grWeighScale = new System.Windows.Forms.GroupBox();
            this.btnGetWeigh = new System.Windows.Forms.Button();
            this.txtWeigh = new System.Windows.Forms.TextBox();
            this.grLetterType = new System.Windows.Forms.GroupBox();
            this.cbLetterType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.grDimension = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.grAddress = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtReceipientCity = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReceipientPostal = new System.Windows.Forms.TextBox();
            this.cbReceipientStates = new System.Windows.Forms.ComboBox();
            this.txtReceipientStreet = new System.Windows.Forms.TextBox();
            this.txtReceipient = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSenderCity = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSenderPostal = new System.Windows.Forms.TextBox();
            this.cbSenderStates = new System.Windows.Forms.ComboBox();
            this.txtSenderStreet = new System.Windows.Forms.TextBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.gbLetterType = new System.Windows.Forms.GroupBox();
            this.cbDeliveryType = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grWeighScale.SuspendLayout();
            this.grLetterType.SuspendLayout();
            this.grDimension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            this.grAddress.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbLetterType.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPackageType
            // 
            this.cbPackageType.FormattingEnabled = true;
            this.cbPackageType.Items.AddRange(new object[] {
            "Box",
            "Letter"});
            this.cbPackageType.Location = new System.Drawing.Point(23, 57);
            this.cbPackageType.Name = "cbPackageType";
            this.cbPackageType.Size = new System.Drawing.Size(121, 21);
            this.cbPackageType.TabIndex = 0;
            this.cbPackageType.Text = "Letter";
            this.cbPackageType.SelectedIndexChanged += new System.EventHandler(this.cbPackageType_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkInsurance);
            this.groupBox1.Controls.Add(this.grWeighScale);
            this.groupBox1.Controls.Add(this.grLetterType);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.grDimension);
            this.groupBox1.Controls.Add(this.cbPackageType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(741, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // chkInsurance
            // 
            this.chkInsurance.AutoSize = true;
            this.chkInsurance.Location = new System.Drawing.Point(23, 90);
            this.chkInsurance.Name = "chkInsurance";
            this.chkInsurance.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkInsurance.Size = new System.Drawing.Size(98, 30);
            this.chkInsurance.TabIndex = 8;
            this.chkInsurance.Text = "I wan to insure \r\nmy package";
            this.chkInsurance.UseVisualStyleBackColor = true;
            // 
            // grWeighScale
            // 
            this.grWeighScale.Controls.Add(this.btnGetWeigh);
            this.grWeighScale.Controls.Add(this.txtWeigh);
            this.grWeighScale.Location = new System.Drawing.Point(628, 35);
            this.grWeighScale.Name = "grWeighScale";
            this.grWeighScale.Size = new System.Drawing.Size(107, 84);
            this.grWeighScale.TabIndex = 7;
            this.grWeighScale.TabStop = false;
            this.grWeighScale.Text = "Weigh";
            // 
            // btnGetWeigh
            // 
            this.btnGetWeigh.Location = new System.Drawing.Point(19, 55);
            this.btnGetWeigh.Name = "btnGetWeigh";
            this.btnGetWeigh.Size = new System.Drawing.Size(71, 23);
            this.btnGetWeigh.TabIndex = 1;
            this.btnGetWeigh.Text = "Get Weight";
            this.btnGetWeigh.UseVisualStyleBackColor = true;
            this.btnGetWeigh.Click += new System.EventHandler(this.btnGetWeigh_Click);
            // 
            // txtWeigh
            // 
            this.txtWeigh.Location = new System.Drawing.Point(19, 30);
            this.txtWeigh.Name = "txtWeigh";
            this.txtWeigh.Size = new System.Drawing.Size(71, 20);
            this.txtWeigh.TabIndex = 0;
            // 
            // grLetterType
            // 
            this.grLetterType.Controls.Add(this.cbLetterType);
            this.grLetterType.Location = new System.Drawing.Point(453, 35);
            this.grLetterType.Name = "grLetterType";
            this.grLetterType.Size = new System.Drawing.Size(165, 84);
            this.grLetterType.TabIndex = 6;
            this.grLetterType.TabStop = false;
            this.grLetterType.Text = "Letter Type";
            this.grLetterType.Visible = false;
            // 
            // cbLetterType
            // 
            this.cbLetterType.AutoCompleteCustomSource.AddRange(new string[] {
            "Plain",
            "Weather-proof",
            "Fire-proof"});
            this.cbLetterType.FormattingEnabled = true;
            this.cbLetterType.Items.AddRange(new object[] {
            "Plain",
            "Weather_Proof",
            "Fire_Proof"});
            this.cbLetterType.Location = new System.Drawing.Point(20, 30);
            this.cbLetterType.Name = "cbLetterType";
            this.cbLetterType.Size = new System.Drawing.Size(127, 21);
            this.cbLetterType.TabIndex = 0;
            this.cbLetterType.Text = "Plain";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Package Type";
            // 
            // grDimension
            // 
            this.grDimension.Controls.Add(this.label3);
            this.grDimension.Controls.Add(this.label2);
            this.grDimension.Controls.Add(this.label1);
            this.grDimension.Controls.Add(this.numDepth);
            this.grDimension.Controls.Add(this.numHeight);
            this.grDimension.Controls.Add(this.numWidth);
            this.grDimension.Location = new System.Drawing.Point(168, 30);
            this.grDimension.Name = "grDimension";
            this.grDimension.Size = new System.Drawing.Size(279, 89);
            this.grDimension.TabIndex = 1;
            this.grDimension.TabStop = false;
            this.grDimension.Text = "Dimension";
            this.grDimension.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(201, 45);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(60, 20);
            this.numDepth.TabIndex = 2;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(113, 45);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(60, 20);
            this.numHeight.TabIndex = 1;
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(18, 45);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(60, 20);
            this.numWidth.TabIndex = 0;
            // 
            // grAddress
            // 
            this.grAddress.Controls.Add(this.groupBox3);
            this.grAddress.Controls.Add(this.groupBox2);
            this.grAddress.Location = new System.Drawing.Point(12, 166);
            this.grAddress.Name = "grAddress";
            this.grAddress.Size = new System.Drawing.Size(741, 252);
            this.grAddress.TabIndex = 2;
            this.grAddress.TabStop = false;
            this.grAddress.Text = "Addresses";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtReceipientCity);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtReceipientPostal);
            this.groupBox3.Controls.Add(this.cbReceipientStates);
            this.groupBox3.Controls.Add(this.txtReceipientStreet);
            this.groupBox3.Controls.Add(this.txtReceipient);
            this.groupBox3.Location = new System.Drawing.Point(373, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destination";
            // 
            // txtReceipientCity
            // 
            this.txtReceipientCity.Location = new System.Drawing.Point(24, 129);
            this.txtReceipientCity.Name = "txtReceipientCity";
            this.txtReceipientCity.Size = new System.Drawing.Size(100, 20);
            this.txtReceipientCity.TabIndex = 10;
            this.txtReceipientCity.Text = "PJ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(24, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "City";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(236, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Postal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // txtReceipientPostal
            // 
            this.txtReceipientPostal.Location = new System.Drawing.Point(239, 129);
            this.txtReceipientPostal.Name = "txtReceipientPostal";
            this.txtReceipientPostal.Size = new System.Drawing.Size(100, 20);
            this.txtReceipientPostal.TabIndex = 5;
            this.txtReceipientPostal.Text = "54321";
            // 
            // cbReceipientStates
            // 
            this.cbReceipientStates.FormattingEnabled = true;
            this.cbReceipientStates.Items.AddRange(new object[] {
            "Johor",
            "Selangor",
            "Pahang"});
            this.cbReceipientStates.Location = new System.Drawing.Point(133, 129);
            this.cbReceipientStates.Name = "cbReceipientStates";
            this.cbReceipientStates.Size = new System.Drawing.Size(100, 21);
            this.cbReceipientStates.TabIndex = 4;
            this.cbReceipientStates.Text = "Johor";
            // 
            // txtReceipientStreet
            // 
            this.txtReceipientStreet.Location = new System.Drawing.Point(24, 83);
            this.txtReceipientStreet.Name = "txtReceipientStreet";
            this.txtReceipientStreet.Size = new System.Drawing.Size(326, 20);
            this.txtReceipientStreet.TabIndex = 2;
            this.txtReceipientStreet.Text = "2323 Sad Street";
            // 
            // txtReceipient
            // 
            this.txtReceipient.Location = new System.Drawing.Point(24, 40);
            this.txtReceipient.Name = "txtReceipient";
            this.txtReceipient.Size = new System.Drawing.Size(100, 20);
            this.txtReceipient.TabIndex = 1;
            this.txtReceipient.Text = "Jane Doe";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSenderCity);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSenderPostal);
            this.groupBox2.Controls.Add(this.cbSenderStates);
            this.groupBox2.Controls.Add(this.txtSenderStreet);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Location = new System.Drawing.Point(7, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 195);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Origin";
            // 
            // txtSenderCity
            // 
            this.txtSenderCity.Location = new System.Drawing.Point(28, 131);
            this.txtSenderCity.Name = "txtSenderCity";
            this.txtSenderCity.Size = new System.Drawing.Size(100, 20);
            this.txtSenderCity.TabIndex = 9;
            this.txtSenderCity.Text = "KL";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Postal";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "State";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // txtSenderPostal
            // 
            this.txtSenderPostal.Location = new System.Drawing.Point(241, 131);
            this.txtSenderPostal.Name = "txtSenderPostal";
            this.txtSenderPostal.Size = new System.Drawing.Size(100, 20);
            this.txtSenderPostal.TabIndex = 4;
            this.txtSenderPostal.Text = "12345";
            // 
            // cbSenderStates
            // 
            this.cbSenderStates.FormattingEnabled = true;
            this.cbSenderStates.Items.AddRange(new object[] {
            "Selangor",
            "Johor",
            "Melaka"});
            this.cbSenderStates.Location = new System.Drawing.Point(134, 130);
            this.cbSenderStates.Name = "cbSenderStates";
            this.cbSenderStates.Size = new System.Drawing.Size(100, 21);
            this.cbSenderStates.TabIndex = 3;
            this.cbSenderStates.Text = "Johor";
            // 
            // txtSenderStreet
            // 
            this.txtSenderStreet.Location = new System.Drawing.Point(28, 84);
            this.txtSenderStreet.Name = "txtSenderStreet";
            this.txtSenderStreet.Size = new System.Drawing.Size(326, 20);
            this.txtSenderStreet.TabIndex = 1;
            this.txtSenderStreet.Text = "123 Happy Street";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(28, 40);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 20);
            this.txtSender.TabIndex = 0;
            this.txtSender.Text = "John Doe";
            // 
            // gbLetterType
            // 
            this.gbLetterType.Controls.Add(this.cbDeliveryType);
            this.gbLetterType.Location = new System.Drawing.Point(12, 435);
            this.gbLetterType.Name = "gbLetterType";
            this.gbLetterType.Size = new System.Drawing.Size(741, 73);
            this.gbLetterType.TabIndex = 3;
            this.gbLetterType.TabStop = false;
            this.gbLetterType.Text = "Delivery Type";
            // 
            // cbDeliveryType
            // 
            this.cbDeliveryType.FormattingEnabled = true;
            this.cbDeliveryType.Items.AddRange(new object[] {
            "Air",
            "Ground",
            "Rail"});
            this.cbDeliveryType.Location = new System.Drawing.Point(7, 31);
            this.cbDeliveryType.Name = "cbDeliveryType";
            this.cbDeliveryType.Size = new System.Drawing.Size(121, 21);
            this.cbDeliveryType.TabIndex = 0;
            this.cbDeliveryType.Text = "Ground";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(352, 538);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // JustInTimeShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 594);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.gbLetterType);
            this.Controls.Add(this.grAddress);
            this.Controls.Add(this.groupBox1);
            this.Name = "JustInTimeShippingForm";
            this.Text = "Just In Time Shipping";
            this.Load += new System.EventHandler(this.JustInTimeShippingForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grWeighScale.ResumeLayout(false);
            this.grWeighScale.PerformLayout();
            this.grLetterType.ResumeLayout(false);
            this.grDimension.ResumeLayout(false);
            this.grDimension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            this.grAddress.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbLetterType.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbPackageType;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox grDimension;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numDepth;
        private System.Windows.Forms.NumericUpDown numHeight;
        private System.Windows.Forms.NumericUpDown numWidth;
        private System.Windows.Forms.GroupBox grAddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtReceipientPostal;
        private System.Windows.Forms.ComboBox cbReceipientStates;
        private System.Windows.Forms.TextBox txtReceipientStreet;
        private System.Windows.Forms.TextBox txtReceipient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenderPostal;
        private System.Windows.Forms.ComboBox cbSenderStates;
        private System.Windows.Forms.TextBox txtSenderStreet;
        private System.Windows.Forms.TextBox txtSender;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox gbLetterType;
        private System.Windows.Forms.ComboBox cbDeliveryType;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.TextBox txtSenderCity;
        private System.Windows.Forms.TextBox txtReceipientCity;
        private System.Windows.Forms.GroupBox grLetterType;
        private System.Windows.Forms.ComboBox cbLetterType;
        private System.Windows.Forms.GroupBox grWeighScale;
        private System.Windows.Forms.Button btnGetWeigh;
        private System.Windows.Forms.TextBox txtWeigh;
        private System.Windows.Forms.CheckBox chkInsurance;
    }
}

