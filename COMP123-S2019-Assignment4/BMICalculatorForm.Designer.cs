namespace COMP123_S2019_Assignment4
{
    partial class BMICalculatorForm
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
            this.BMICalculateTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.ImperialradioButton = new System.Windows.Forms.RadioButton();
            this.HeightLabel = new System.Windows.Forms.Label();
            this.WeightLabel = new System.Windows.Forms.Label();
            this.CalBMIButton = new System.Windows.Forms.Button();
            this.BMIResulttextBox = new System.Windows.Forms.TextBox();
            this.WeightTextBox = new System.Windows.Forms.TextBox();
            this.HeightTextBox = new System.Windows.Forms.TextBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.BMICalculateTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMICalculateTableLayoutPanel
            // 
            this.BMICalculateTableLayoutPanel.ColumnCount = 4;
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.BMICalculateTableLayoutPanel.Controls.Add(this.MetricRadioButton, 2, 0);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.ImperialradioButton, 0, 0);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.HeightLabel, 0, 1);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.WeightLabel, 0, 2);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.CalBMIButton, 0, 3);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.WeightTextBox, 2, 2);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.HeightTextBox, 2, 1);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.ResetButton, 0, 7);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.BMIProgressBar, 0, 6);
            this.BMICalculateTableLayoutPanel.Controls.Add(this.BMIResulttextBox, 0, 4);
            this.BMICalculateTableLayoutPanel.Location = new System.Drawing.Point(1, 1);
            this.BMICalculateTableLayoutPanel.Name = "BMICalculateTableLayoutPanel";
            this.BMICalculateTableLayoutPanel.RowCount = 8;
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.03509F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.47563F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.BMICalculateTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.BMICalculateTableLayoutPanel.Size = new System.Drawing.Size(300, 432);
            this.BMICalculateTableLayoutPanel.TabIndex = 0;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MetricRadioButton.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.MetricRadioButton, 2);
            this.MetricRadioButton.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.MetricRadioButton.Location = new System.Drawing.Point(153, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(144, 54);
            this.MetricRadioButton.TabIndex = 2;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            this.MetricRadioButton.CheckedChanged += new System.EventHandler(this.MetricRadioButton_CheckedChanged);
            // 
            // ImperialradioButton
            // 
            this.ImperialradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ImperialradioButton.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.ImperialradioButton, 2);
            this.ImperialradioButton.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ImperialradioButton.Location = new System.Drawing.Point(3, 3);
            this.ImperialradioButton.Name = "ImperialradioButton";
            this.ImperialradioButton.Size = new System.Drawing.Size(144, 54);
            this.ImperialradioButton.TabIndex = 1;
            this.ImperialradioButton.TabStop = true;
            this.ImperialradioButton.Text = "Imperial";
            this.ImperialradioButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ImperialradioButton.UseVisualStyleBackColor = true;
            this.ImperialradioButton.CheckedChanged += new System.EventHandler(this.ImperialradioButton_CheckedChanged);
            // 
            // HeightLabel
            // 
            this.HeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightLabel.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.HeightLabel, 2);
            this.HeightLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightLabel.Location = new System.Drawing.Point(3, 60);
            this.HeightLabel.Name = "HeightLabel";
            this.HeightLabel.Size = new System.Drawing.Size(144, 53);
            this.HeightLabel.TabIndex = 3;
            this.HeightLabel.Text = "Height";
            this.HeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WeightLabel
            // 
            this.WeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightLabel.AutoSize = true;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.WeightLabel, 2);
            this.WeightLabel.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightLabel.Location = new System.Drawing.Point(3, 113);
            this.WeightLabel.Name = "WeightLabel";
            this.WeightLabel.Size = new System.Drawing.Size(144, 53);
            this.WeightLabel.TabIndex = 4;
            this.WeightLabel.Text = "Weight";
            this.WeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CalBMIButton
            // 
            this.CalBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.CalBMIButton, 4);
            this.CalBMIButton.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.CalBMIButton.Location = new System.Drawing.Point(3, 169);
            this.CalBMIButton.Name = "CalBMIButton";
            this.CalBMIButton.Size = new System.Drawing.Size(294, 47);
            this.CalBMIButton.TabIndex = 7;
            this.CalBMIButton.Text = " Calculate BMI Button";
            this.CalBMIButton.UseVisualStyleBackColor = true;
            this.CalBMIButton.Click += new System.EventHandler(this.CalBMIButton_Click);
            // 
            // BMIResulttextBox
            // 
            this.BMIResulttextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIResulttextBox.BackColor = System.Drawing.Color.White;
            this.BMIResulttextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.BMIResulttextBox, 4);
            this.BMIResulttextBox.Location = new System.Drawing.Point(3, 222);
            this.BMIResulttextBox.Multiline = true;
            this.BMIResulttextBox.Name = "BMIResulttextBox";
            this.BMICalculateTableLayoutPanel.SetRowSpan(this.BMIResulttextBox, 2);
            this.BMIResulttextBox.Size = new System.Drawing.Size(294, 100);
            this.BMIResulttextBox.TabIndex = 1;
            this.BMIResulttextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BMIResulttextBox.TextChanged += new System.EventHandler(this.BMIResulttextBox_TextChanged);
            // 
            // WeightTextBox
            // 
            this.WeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.WeightTextBox, 2);
            this.WeightTextBox.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WeightTextBox.Location = new System.Drawing.Point(153, 116);
            this.WeightTextBox.Name = "WeightTextBox";
            this.WeightTextBox.Size = new System.Drawing.Size(144, 46);
            this.WeightTextBox.TabIndex = 6;
            this.WeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.WeightTextBox.Enter += new System.EventHandler(this.WeightTextBox_Enter);
            // 
            // HeightTextBox
            // 
            this.HeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.HeightTextBox.BackColor = System.Drawing.Color.White;
            this.HeightTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.HeightTextBox, 2);
            this.HeightTextBox.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.HeightTextBox.Location = new System.Drawing.Point(153, 63);
            this.HeightTextBox.Name = "HeightTextBox";
            this.HeightTextBox.Size = new System.Drawing.Size(144, 46);
            this.HeightTextBox.TabIndex = 5;
            this.HeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HeightTextBox.TextChanged += new System.EventHandler(this.HeightTextBox_TextChanged);
            this.HeightTextBox.Enter += new System.EventHandler(this.HeightTextBox_Enter);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.ResetButton, 4);
            this.ResetButton.Location = new System.Drawing.Point(3, 381);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(294, 48);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BMIProgressBar
            // 
            this.BMIProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMICalculateTableLayoutPanel.SetColumnSpan(this.BMIProgressBar, 4);
            this.BMIProgressBar.ForeColor = System.Drawing.Color.Transparent;
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 328);
            this.BMIProgressBar.Maximum = 30;
            this.BMIProgressBar.Minimum = 10;
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(294, 47);
            this.BMIProgressBar.Step = 2;
            this.BMIProgressBar.TabIndex = 11;
            this.BMIProgressBar.Value = 10;
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 433);
            this.Controls.Add(this.BMICalculateTableLayoutPanel);
            this.Font = new System.Drawing.Font("Gulim", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MinimizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator Form";
            this.Load += new System.EventHandler(this.BMICalculatorForm_Load);
            this.BMICalculateTableLayoutPanel.ResumeLayout(false);
            this.BMICalculateTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel BMICalculateTableLayoutPanel;
        private System.Windows.Forms.RadioButton ImperialradioButton;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.Label HeightLabel;
        private System.Windows.Forms.Label WeightLabel;
        private System.Windows.Forms.TextBox HeightTextBox;
        private System.Windows.Forms.TextBox WeightTextBox;
        private System.Windows.Forms.Button CalBMIButton;
        private System.Windows.Forms.TextBox BMIResulttextBox;
        private System.Windows.Forms.Button ResetButton;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
    }
}

