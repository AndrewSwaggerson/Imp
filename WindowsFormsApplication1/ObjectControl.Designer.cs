namespace WindowsFormsApplication1
{
    partial class ObjectControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.radioButtonCapacitor = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonResistor = new System.Windows.Forms.RadioButton();
            this.radioButtonInductor = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxValue.Location = new System.Drawing.Point(92, 33);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(165, 20);
            this.textBoxValue.TabIndex = 53;
            // 
            // radioButtonCapacitor
            // 
            this.radioButtonCapacitor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonCapacitor.AutoSize = true;
            this.radioButtonCapacitor.Location = new System.Drawing.Point(263, 52);
            this.radioButtonCapacitor.Name = "radioButtonCapacitor";
            this.radioButtonCapacitor.Size = new System.Drawing.Size(70, 17);
            this.radioButtonCapacitor.TabIndex = 51;
            this.radioButtonCapacitor.TabStop = true;
            this.radioButtonCapacitor.Text = "Capacitor";
            this.radioButtonCapacitor.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 47;
            this.label1.Text = "Value";
            // 
            // radioButtonResistor
            // 
            this.radioButtonResistor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonResistor.AutoSize = true;
            this.radioButtonResistor.Location = new System.Drawing.Point(263, 77);
            this.radioButtonResistor.Name = "radioButtonResistor";
            this.radioButtonResistor.Size = new System.Drawing.Size(63, 17);
            this.radioButtonResistor.TabIndex = 49;
            this.radioButtonResistor.TabStop = true;
            this.radioButtonResistor.Text = "Resistor";
            this.radioButtonResistor.UseVisualStyleBackColor = true;
            // 
            // radioButtonInductor
            // 
            this.radioButtonInductor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.radioButtonInductor.AutoSize = true;
            this.radioButtonInductor.Location = new System.Drawing.Point(263, 29);
            this.radioButtonInductor.Name = "radioButtonInductor";
            this.radioButtonInductor.Size = new System.Drawing.Size(64, 17);
            this.radioButtonInductor.TabIndex = 50;
            this.radioButtonInductor.TabStop = true;
            this.radioButtonInductor.Text = "Inductor";
            this.radioButtonInductor.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxName.Location = new System.Drawing.Point(92, 71);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(165, 20);
            this.textBoxName.TabIndex = 52;
            // 
            // ObjectControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxValue);
            this.Controls.Add(this.radioButtonCapacitor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButtonResistor);
            this.Controls.Add(this.radioButtonInductor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxName);
            this.Name = "ObjectControl";
            this.Size = new System.Drawing.Size(375, 126);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.RadioButton radioButtonCapacitor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonResistor;
        private System.Windows.Forms.RadioButton radioButtonInductor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxName;
    }
}
