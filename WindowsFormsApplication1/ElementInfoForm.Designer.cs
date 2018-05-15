﻿namespace WindowsFormsApplication1
{
    partial class ElementInfoForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonResistor = new System.Windows.Forms.RadioButton();
            this.radioButtonInductor = new System.Windows.Forms.RadioButton();
            this.radioButtonCapacitor = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Value";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // radioButtonResistor
            // 
            this.radioButtonResistor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonResistor.AutoSize = true;
            this.radioButtonResistor.Location = new System.Drawing.Point(260, 51);
            this.radioButtonResistor.Name = "radioButtonResistor";
            this.radioButtonResistor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonResistor.TabIndex = 3;
            this.radioButtonResistor.TabStop = true;
            this.radioButtonResistor.Text = "Resistor";
            this.radioButtonResistor.UseVisualStyleBackColor = true;
            // 
            // radioButtonInductor
            // 
            this.radioButtonInductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonInductor.AutoSize = true;
            this.radioButtonInductor.Location = new System.Drawing.Point(260, 28);
            this.radioButtonInductor.Name = "radioButtonInductor";
            this.radioButtonInductor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonInductor.TabIndex = 4;
            this.radioButtonInductor.TabStop = true;
            this.radioButtonInductor.Text = "Inductor";
            this.radioButtonInductor.UseVisualStyleBackColor = true;
            // 
            // radioButtonCapacitor
            // 
            this.radioButtonCapacitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCapacitor.AutoSize = true;
            this.radioButtonCapacitor.Location = new System.Drawing.Point(260, 76);
            this.radioButtonCapacitor.Name = "radioButtonCapacitor";
            this.radioButtonCapacitor.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCapacitor.TabIndex = 5;
            this.radioButtonCapacitor.TabStop = true;
            this.radioButtonCapacitor.Text = "Capacitor";
            this.radioButtonCapacitor.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.radioButtonCapacitor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioButtonResistor);
            this.groupBox1.Controls.Add(this.textBoxValue);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.radioButtonInductor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 117);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValue.Location = new System.Drawing.Point(75, 73);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxValue.TabIndex = 39;
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(75, 28);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 20);
            this.textBoxName.TabIndex = 37;
            // 
            // buttonOK
            // 
            this.buttonOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOK.Location = new System.Drawing.Point(75, 135);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(117, 23);
            this.buttonOK.TabIndex = 16;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCancel.Location = new System.Drawing.Point(198, 136);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(117, 23);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // ElementInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 171);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Name = "ElementInfoForm";
            this.Text = "NeList";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonResistor;
        private System.Windows.Forms.RadioButton radioButtonInductor;
        private System.Windows.Forms.RadioButton radioButtonCapacitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxName;
    }
}

