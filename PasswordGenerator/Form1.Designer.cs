namespace PasswordGenerator
{
    partial class GeneratorForm
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
            this.lengthField = new System.Windows.Forms.NumericUpDown();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.letterTypeButtonGroup = new System.Windows.Forms.GroupBox();
            this.bothButton = new System.Windows.Forms.RadioButton();
            this.lowerCaseButton = new System.Windows.Forms.RadioButton();
            this.upperCaseButton = new System.Windows.Forms.RadioButton();
            this.contentRadioButtonGroup = new System.Windows.Forms.GroupBox();
            this.specialCharButton = new System.Windows.Forms.RadioButton();
            this.lettersButton = new System.Windows.Forms.RadioButton();
            this.alphanumericButton = new System.Windows.Forms.RadioButton();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.generateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lengthField)).BeginInit();
            this.groupBox.SuspendLayout();
            this.letterTypeButtonGroup.SuspendLayout();
            this.contentRadioButtonGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // lengthField
            // 
            this.lengthField.AccessibleDescription = "Length";
            this.lengthField.AccessibleName = "Length";
            this.lengthField.Location = new System.Drawing.Point(86, 26);
            this.lengthField.Name = "lengthField";
            this.lengthField.Size = new System.Drawing.Size(159, 20);
            this.lengthField.TabIndex = 0;
            // 
            // groupBox
            // 
            this.groupBox.Controls.Add(this.letterTypeButtonGroup);
            this.groupBox.Controls.Add(this.contentRadioButtonGroup);
            this.groupBox.Controls.Add(this.lengthLabel);
            this.groupBox.Controls.Add(this.lengthField);
            this.groupBox.Location = new System.Drawing.Point(9, 9);
            this.groupBox.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox.Name = "groupBox";
            this.groupBox.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox.Size = new System.Drawing.Size(258, 243);
            this.groupBox.TabIndex = 1;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Settings";
            // 
            // letterTypeButtonGroup
            // 
            this.letterTypeButtonGroup.Controls.Add(this.bothButton);
            this.letterTypeButtonGroup.Controls.Add(this.lowerCaseButton);
            this.letterTypeButtonGroup.Controls.Add(this.upperCaseButton);
            this.letterTypeButtonGroup.Location = new System.Drawing.Point(16, 147);
            this.letterTypeButtonGroup.Name = "letterTypeButtonGroup";
            this.letterTypeButtonGroup.Size = new System.Drawing.Size(229, 85);
            this.letterTypeButtonGroup.TabIndex = 3;
            this.letterTypeButtonGroup.TabStop = false;
            this.letterTypeButtonGroup.Text = "Letter type";
            // 
            // bothButton
            // 
            this.bothButton.AutoSize = true;
            this.bothButton.Location = new System.Drawing.Point(6, 65);
            this.bothButton.Name = "bothButton";
            this.bothButton.Size = new System.Drawing.Size(131, 17);
            this.bothButton.TabIndex = 4;
            this.bothButton.TabStop = true;
            this.bothButton.Text = "Lower and upper case";
            this.bothButton.UseVisualStyleBackColor = true;
            // 
            // lowerCaseButton
            // 
            this.lowerCaseButton.AutoSize = true;
            this.lowerCaseButton.Location = new System.Drawing.Point(6, 19);
            this.lowerCaseButton.Name = "lowerCaseButton";
            this.lowerCaseButton.Size = new System.Drawing.Size(80, 17);
            this.lowerCaseButton.TabIndex = 2;
            this.lowerCaseButton.TabStop = true;
            this.lowerCaseButton.Text = "Lower case";
            this.lowerCaseButton.UseVisualStyleBackColor = true;
            // 
            // upperCaseButton
            // 
            this.upperCaseButton.AutoSize = true;
            this.upperCaseButton.Location = new System.Drawing.Point(6, 42);
            this.upperCaseButton.Name = "upperCaseButton";
            this.upperCaseButton.Size = new System.Drawing.Size(80, 17);
            this.upperCaseButton.TabIndex = 3;
            this.upperCaseButton.TabStop = true;
            this.upperCaseButton.Text = "Upper case";
            this.upperCaseButton.UseVisualStyleBackColor = true;
            // 
            // contentRadioButtonGroup
            // 
            this.contentRadioButtonGroup.Controls.Add(this.specialCharButton);
            this.contentRadioButtonGroup.Controls.Add(this.lettersButton);
            this.contentRadioButtonGroup.Controls.Add(this.alphanumericButton);
            this.contentRadioButtonGroup.Location = new System.Drawing.Point(16, 56);
            this.contentRadioButtonGroup.Name = "contentRadioButtonGroup";
            this.contentRadioButtonGroup.Size = new System.Drawing.Size(229, 85);
            this.contentRadioButtonGroup.TabIndex = 2;
            this.contentRadioButtonGroup.TabStop = false;
            this.contentRadioButtonGroup.Text = "Password contains";
            // 
            // specialCharButton
            // 
            this.specialCharButton.AutoSize = true;
            this.specialCharButton.Location = new System.Drawing.Point(6, 65);
            this.specialCharButton.Name = "specialCharButton";
            this.specialCharButton.Size = new System.Drawing.Size(213, 17);
            this.specialCharButton.TabIndex = 4;
            this.specialCharButton.TabStop = true;
            this.specialCharButton.Text = "Letters, numbers and special characters";
            this.specialCharButton.UseVisualStyleBackColor = true;
            // 
            // lettersButton
            // 
            this.lettersButton.AutoSize = true;
            this.lettersButton.Location = new System.Drawing.Point(6, 19);
            this.lettersButton.Name = "lettersButton";
            this.lettersButton.Size = new System.Drawing.Size(79, 17);
            this.lettersButton.TabIndex = 2;
            this.lettersButton.TabStop = true;
            this.lettersButton.Text = "Letters only";
            this.lettersButton.UseVisualStyleBackColor = true;
            // 
            // alphanumericButton
            // 
            this.alphanumericButton.AutoSize = true;
            this.alphanumericButton.Location = new System.Drawing.Point(6, 42);
            this.alphanumericButton.Name = "alphanumericButton";
            this.alphanumericButton.Size = new System.Drawing.Size(121, 17);
            this.alphanumericButton.TabIndex = 3;
            this.alphanumericButton.TabStop = true;
            this.alphanumericButton.Text = "Letters and numbers";
            this.alphanumericButton.UseVisualStyleBackColor = true;
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(19, 28);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(40, 13);
            this.lengthLabel.TabIndex = 1;
            this.lengthLabel.Text = "Length";
            // 
            // generateButton
            // 
            this.generateButton.Location = new System.Drawing.Point(79, 265);
            this.generateButton.Name = "generateButton";
            this.generateButton.Size = new System.Drawing.Size(114, 23);
            this.generateButton.TabIndex = 2;
            this.generateButton.Text = "Generate";
            this.generateButton.UseVisualStyleBackColor = true;
            this.generateButton.Click += new System.EventHandler(this.generateButton_Click);
            // 
            // GeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 300);
            this.Controls.Add(this.generateButton);
            this.Controls.Add(this.groupBox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GeneratorForm";
            this.ShowIcon = false;
            this.Text = "Password generator";
            ((System.ComponentModel.ISupportInitialize)(this.lengthField)).EndInit();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.letterTypeButtonGroup.ResumeLayout(false);
            this.letterTypeButtonGroup.PerformLayout();
            this.contentRadioButtonGroup.ResumeLayout(false);
            this.contentRadioButtonGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown lengthField;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.GroupBox contentRadioButtonGroup;
        private System.Windows.Forms.RadioButton specialCharButton;
        private System.Windows.Forms.RadioButton lettersButton;
        private System.Windows.Forms.RadioButton alphanumericButton;
        private System.Windows.Forms.GroupBox letterTypeButtonGroup;
        private System.Windows.Forms.RadioButton bothButton;
        private System.Windows.Forms.RadioButton lowerCaseButton;
        private System.Windows.Forms.RadioButton upperCaseButton;
        private System.Windows.Forms.Button generateButton;
    }
}

