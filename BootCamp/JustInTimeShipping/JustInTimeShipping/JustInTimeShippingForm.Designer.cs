﻿namespace JustInTimeShipping
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
            this.grDimension = new System.Windows.Forms.GroupBox();
            this.numWidth = new System.Windows.Forms.NumericUpDown();
            this.numHeight = new System.Windows.Forms.NumericUpDown();
            this.numDepth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grAddress = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtSender = new System.Windows.Forms.TextBox();
            this.txtReceipient = new System.Windows.Forms.TextBox();
            this.txtSenderStreet = new System.Windows.Forms.TextBox();
            this.txtReceipientStreet = new System.Windows.Forms.TextBox();
            this.txtSenderCity = new System.Windows.Forms.ComboBox();
            this.txtReceipientCity = new System.Windows.Forms.ComboBox();
            this.txtSenderStates = new System.Windows.Forms.ComboBox();
            this.txtReceipientStates = new System.Windows.Forms.ComboBox();
            this.txtSenderPostal = new System.Windows.Forms.TextBox();
            this.txtReceipientPostal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDeliveryType = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnProcess = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.grDimension.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).BeginInit();
            this.grAddress.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.cbDeliveryType.SuspendLayout();
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
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.grDimension);
            this.groupBox1.Controls.Add(this.cbPackageType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(708, 135);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Package Information";
            // 
            // grDimension
            // 
            this.grDimension.Controls.Add(this.label3);
            this.grDimension.Controls.Add(this.label2);
            this.grDimension.Controls.Add(this.label1);
            this.grDimension.Controls.Add(this.numDepth);
            this.grDimension.Controls.Add(this.numHeight);
            this.grDimension.Controls.Add(this.numWidth);
            this.grDimension.Location = new System.Drawing.Point(178, 30);
            this.grDimension.Name = "grDimension";
            this.grDimension.Size = new System.Drawing.Size(403, 89);
            this.grDimension.TabIndex = 1;
            this.grDimension.TabStop = false;
            this.grDimension.Text = "Dimension";
            // 
            // numWidth
            // 
            this.numWidth.Location = new System.Drawing.Point(67, 54);
            this.numWidth.Name = "numWidth";
            this.numWidth.Size = new System.Drawing.Size(60, 20);
            this.numWidth.TabIndex = 0;
            // 
            // numHeight
            // 
            this.numHeight.Location = new System.Drawing.Point(162, 54);
            this.numHeight.Name = "numHeight";
            this.numHeight.Size = new System.Drawing.Size(60, 20);
            this.numHeight.TabIndex = 1;
            // 
            // numDepth
            // 
            this.numDepth.Location = new System.Drawing.Point(250, 54);
            this.numDepth.Name = "numDepth";
            this.numDepth.Size = new System.Drawing.Size(60, 20);
            this.numDepth.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(176, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Depth";
            // 
            // grAddress
            // 
            this.grAddress.Controls.Add(this.groupBox3);
            this.grAddress.Controls.Add(this.groupBox2);
            this.grAddress.Location = new System.Drawing.Point(12, 166);
            this.grAddress.Name = "grAddress";
            this.grAddress.Size = new System.Drawing.Size(708, 252);
            this.grAddress.TabIndex = 2;
            this.grAddress.TabStop = false;
            this.grAddress.Text = "Addresses";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtSenderPostal);
            this.groupBox2.Controls.Add(this.txtSenderStates);
            this.groupBox2.Controls.Add(this.txtSenderCity);
            this.groupBox2.Controls.Add(this.txtSenderStreet);
            this.groupBox2.Controls.Add(this.txtSender);
            this.groupBox2.Location = new System.Drawing.Point(7, 41);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(360, 195);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sender";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.txtReceipientPostal);
            this.groupBox3.Controls.Add(this.txtReceipientStates);
            this.groupBox3.Controls.Add(this.txtReceipientCity);
            this.groupBox3.Controls.Add(this.txtReceipientStreet);
            this.groupBox3.Controls.Add(this.txtReceipient);
            this.groupBox3.Location = new System.Drawing.Point(373, 42);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(360, 194);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Receipient";
            // 
            // txtSender
            // 
            this.txtSender.Location = new System.Drawing.Point(28, 40);
            this.txtSender.Name = "txtSender";
            this.txtSender.Size = new System.Drawing.Size(100, 20);
            this.txtSender.TabIndex = 0;
            // 
            // txtReceipient
            // 
            this.txtReceipient.Location = new System.Drawing.Point(24, 40);
            this.txtReceipient.Name = "txtReceipient";
            this.txtReceipient.Size = new System.Drawing.Size(100, 20);
            this.txtReceipient.TabIndex = 1;
            // 
            // txtSenderStreet
            // 
            this.txtSenderStreet.Location = new System.Drawing.Point(28, 84);
            this.txtSenderStreet.Name = "txtSenderStreet";
            this.txtSenderStreet.Size = new System.Drawing.Size(326, 20);
            this.txtSenderStreet.TabIndex = 1;
            // 
            // txtReceipientStreet
            // 
            this.txtReceipientStreet.Location = new System.Drawing.Point(24, 83);
            this.txtReceipientStreet.Name = "txtReceipientStreet";
            this.txtReceipientStreet.Size = new System.Drawing.Size(326, 20);
            this.txtReceipientStreet.TabIndex = 2;
            // 
            // txtSenderCity
            // 
            this.txtSenderCity.FormattingEnabled = true;
            this.txtSenderCity.Location = new System.Drawing.Point(28, 130);
            this.txtSenderCity.Name = "txtSenderCity";
            this.txtSenderCity.Size = new System.Drawing.Size(100, 21);
            this.txtSenderCity.TabIndex = 2;
            this.txtSenderCity.SelectedIndexChanged += new System.EventHandler(this.txtSenderCity_SelectedIndexChanged);
            // 
            // txtReceipientCity
            // 
            this.txtReceipientCity.FormattingEnabled = true;
            this.txtReceipientCity.Location = new System.Drawing.Point(27, 130);
            this.txtReceipientCity.Name = "txtReceipientCity";
            this.txtReceipientCity.Size = new System.Drawing.Size(100, 21);
            this.txtReceipientCity.TabIndex = 3;
            // 
            // txtSenderStates
            // 
            this.txtSenderStates.FormattingEnabled = true;
            this.txtSenderStates.Location = new System.Drawing.Point(134, 130);
            this.txtSenderStates.Name = "txtSenderStates";
            this.txtSenderStates.Size = new System.Drawing.Size(100, 21);
            this.txtSenderStates.TabIndex = 3;
            this.txtSenderStates.SelectedIndexChanged += new System.EventHandler(this.txtSenderStates_SelectedIndexChanged);
            // 
            // txtReceipientStates
            // 
            this.txtReceipientStates.FormattingEnabled = true;
            this.txtReceipientStates.Location = new System.Drawing.Point(133, 129);
            this.txtReceipientStates.Name = "txtReceipientStates";
            this.txtReceipientStates.Size = new System.Drawing.Size(100, 21);
            this.txtReceipientStates.TabIndex = 4;
            // 
            // txtSenderPostal
            // 
            this.txtSenderPostal.Location = new System.Drawing.Point(241, 131);
            this.txtSenderPostal.Name = "txtSenderPostal";
            this.txtSenderPostal.Size = new System.Drawing.Size(100, 20);
            this.txtSenderPostal.TabIndex = 4;
            this.txtSenderPostal.TextChanged += new System.EventHandler(this.txtSenderPostal_TextChanged);
            // 
            // txtReceipientPostal
            // 
            this.txtReceipientPostal.Location = new System.Drawing.Point(239, 129);
            this.txtReceipientPostal.Name = "txtReceipientPostal";
            this.txtReceipientPostal.Size = new System.Drawing.Size(100, 20);
            this.txtReceipientPostal.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "City";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(131, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "State";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Postal";
            this.label8.Click += new System.EventHandler(this.label8_Click);
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(130, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "State";
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
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Package Type";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // cbDeliveryType
            // 
            this.cbDeliveryType.Controls.Add(this.comboBox1);
            this.cbDeliveryType.Location = new System.Drawing.Point(12, 435);
            this.cbDeliveryType.Name = "cbDeliveryType";
            this.cbDeliveryType.Size = new System.Drawing.Size(712, 73);
            this.cbDeliveryType.TabIndex = 3;
            this.cbDeliveryType.TabStop = false;
            this.cbDeliveryType.Text = "Delivery Type";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(7, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(352, 538);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(75, 23);
            this.btnProcess.TabIndex = 4;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = true;
            // 
            // JustInTimeShippingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 594);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.cbDeliveryType);
            this.Controls.Add(this.grAddress);
            this.Controls.Add(this.groupBox1);
            this.Name = "JustInTimeShippingForm";
            this.Text = "Just In Time Shipping";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grDimension.ResumeLayout(false);
            this.grDimension.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDepth)).EndInit();
            this.grAddress.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.cbDeliveryType.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox txtReceipientStates;
        private System.Windows.Forms.ComboBox txtReceipientCity;
        private System.Windows.Forms.TextBox txtReceipientStreet;
        private System.Windows.Forms.TextBox txtReceipient;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSenderPostal;
        private System.Windows.Forms.ComboBox txtSenderStates;
        private System.Windows.Forms.ComboBox txtSenderCity;
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
        private System.Windows.Forms.GroupBox cbDeliveryType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnProcess;
    }
}

