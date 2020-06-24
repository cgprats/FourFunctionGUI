namespace Four_Function_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ValueOneIndicator = new System.Windows.Forms.Label();
            this.ValueTwoIndicator = new System.Windows.Forms.Label();
            this.ValueOneBox = new System.Windows.Forms.TextBox();
            this.ValueTwoBox = new System.Windows.Forms.TextBox();
            this.MultiplicationRadio = new System.Windows.Forms.RadioButton();
            this.OperationLabel = new System.Windows.Forms.Label();
            this.AdditionRadio = new System.Windows.Forms.RadioButton();
            this.SubtractionRadio = new System.Windows.Forms.RadioButton();
            this.DivisionRadio = new System.Windows.Forms.RadioButton();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.CalculatedResultLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ValueOneIndicator
            // 
            this.ValueOneIndicator.AutoSize = true;
            this.ValueOneIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueOneIndicator.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ValueOneIndicator.Location = new System.Drawing.Point(0, 3);
            this.ValueOneIndicator.Name = "ValueOneIndicator";
            this.ValueOneIndicator.Size = new System.Drawing.Size(60, 13);
            this.ValueOneIndicator.TabIndex = 0;
            this.ValueOneIndicator.Text = "Value One:";
            // 
            // ValueTwoIndicator
            // 
            this.ValueTwoIndicator.AutoSize = true;
            this.ValueTwoIndicator.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ValueTwoIndicator.Location = new System.Drawing.Point(-1, 37);
            this.ValueTwoIndicator.Name = "ValueTwoIndicator";
            this.ValueTwoIndicator.Size = new System.Drawing.Size(61, 13);
            this.ValueTwoIndicator.TabIndex = 1;
            this.ValueTwoIndicator.Text = "Value Two:";
            this.ValueTwoIndicator.Click += new System.EventHandler(this.ValueTwoIndicator_Click);
            // 
            // ValueOneBox
            // 
            this.ValueOneBox.Location = new System.Drawing.Point(57, 3);
            this.ValueOneBox.Name = "ValueOneBox";
            this.ValueOneBox.Size = new System.Drawing.Size(100, 20);
            this.ValueOneBox.TabIndex = 2;
            this.ValueOneBox.TextChanged += new System.EventHandler(this.ValueOneBox_TextChanged);
            // 
            // ValueTwoBox
            // 
            this.ValueTwoBox.Location = new System.Drawing.Point(57, 34);
            this.ValueTwoBox.Name = "ValueTwoBox";
            this.ValueTwoBox.Size = new System.Drawing.Size(100, 20);
            this.ValueTwoBox.TabIndex = 3;
            this.ValueTwoBox.TextChanged += new System.EventHandler(this.ValueTwoBox_TextChanged);
            // 
            // MultiplicationRadio
            // 
            this.MultiplicationRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MultiplicationRadio.AutoSize = true;
            this.MultiplicationRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MultiplicationRadio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.MultiplicationRadio.Location = new System.Drawing.Point(197, 65);
            this.MultiplicationRadio.Name = "MultiplicationRadio";
            this.MultiplicationRadio.Size = new System.Drawing.Size(86, 17);
            this.MultiplicationRadio.TabIndex = 4;
            this.MultiplicationRadio.Text = "Multiplication";
            this.MultiplicationRadio.UseVisualStyleBackColor = true;
            this.MultiplicationRadio.CheckedChanged += new System.EventHandler(this.MultiplicationRadio_CheckedChanged);
            // 
            // OperationLabel
            // 
            this.OperationLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.OperationLabel.AutoSize = true;
            this.OperationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OperationLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.OperationLabel.Location = new System.Drawing.Point(194, 3);
            this.OperationLabel.Name = "OperationLabel";
            this.OperationLabel.Size = new System.Drawing.Size(59, 13);
            this.OperationLabel.TabIndex = 5;
            this.OperationLabel.Text = "Operation: ";
            // 
            // AdditionRadio
            // 
            this.AdditionRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AdditionRadio.AutoSize = true;
            this.AdditionRadio.Checked = true;
            this.AdditionRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdditionRadio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.AdditionRadio.Location = new System.Drawing.Point(198, 19);
            this.AdditionRadio.Name = "AdditionRadio";
            this.AdditionRadio.Size = new System.Drawing.Size(63, 17);
            this.AdditionRadio.TabIndex = 6;
            this.AdditionRadio.TabStop = true;
            this.AdditionRadio.Text = "Addition";
            this.AdditionRadio.UseVisualStyleBackColor = true;
            this.AdditionRadio.CheckedChanged += new System.EventHandler(this.AdditionRadio_CheckedChanged);
            // 
            // SubtractionRadio
            // 
            this.SubtractionRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SubtractionRadio.AutoSize = true;
            this.SubtractionRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtractionRadio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.SubtractionRadio.Location = new System.Drawing.Point(197, 42);
            this.SubtractionRadio.Name = "SubtractionRadio";
            this.SubtractionRadio.Size = new System.Drawing.Size(79, 17);
            this.SubtractionRadio.TabIndex = 7;
            this.SubtractionRadio.Text = "Subtraction";
            this.SubtractionRadio.UseVisualStyleBackColor = true;
            this.SubtractionRadio.CheckedChanged += new System.EventHandler(this.SubtractionRadio_CheckedChanged);
            // 
            // DivisionRadio
            // 
            this.DivisionRadio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DivisionRadio.AutoSize = true;
            this.DivisionRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DivisionRadio.ForeColor = System.Drawing.SystemColors.Desktop;
            this.DivisionRadio.Location = new System.Drawing.Point(198, 88);
            this.DivisionRadio.Name = "DivisionRadio";
            this.DivisionRadio.Size = new System.Drawing.Size(62, 17);
            this.DivisionRadio.TabIndex = 8;
            this.DivisionRadio.Text = "Division";
            this.DivisionRadio.UseVisualStyleBackColor = true;
            this.DivisionRadio.CheckedChanged += new System.EventHandler(this.DivisionRadio_CheckedChanged);
            // 
            // CalculateButton
            // 
            this.CalculateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateButton.Location = new System.Drawing.Point(57, 65);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 9;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.SystemColors.Desktop;
            this.ResultLabel.Location = new System.Drawing.Point(54, 90);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(40, 13);
            this.ResultLabel.TabIndex = 10;
            this.ResultLabel.Text = "Result:";
            // 
            // CalculatedResultLabel
            // 
            this.CalculatedResultLabel.AutoSize = true;
            this.CalculatedResultLabel.Location = new System.Drawing.Point(97, 90);
            this.CalculatedResultLabel.Name = "CalculatedResultLabel";
            this.CalculatedResultLabel.Size = new System.Drawing.Size(0, 13);
            this.CalculatedResultLabel.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(281, 126);
            this.Controls.Add(this.CalculatedResultLabel);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.DivisionRadio);
            this.Controls.Add(this.SubtractionRadio);
            this.Controls.Add(this.AdditionRadio);
            this.Controls.Add(this.OperationLabel);
            this.Controls.Add(this.MultiplicationRadio);
            this.Controls.Add(this.ValueTwoBox);
            this.Controls.Add(this.ValueOneBox);
            this.Controls.Add(this.ValueTwoIndicator);
            this.Controls.Add(this.ValueOneIndicator);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ValueOneIndicator;
        private System.Windows.Forms.Label ValueTwoIndicator;
        private System.Windows.Forms.TextBox ValueOneBox;
        private System.Windows.Forms.TextBox ValueTwoBox;
        private System.Windows.Forms.RadioButton MultiplicationRadio;
        private System.Windows.Forms.Label OperationLabel;
        private System.Windows.Forms.RadioButton AdditionRadio;
        private System.Windows.Forms.RadioButton SubtractionRadio;
        private System.Windows.Forms.RadioButton DivisionRadio;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label CalculatedResultLabel;
    }
}

