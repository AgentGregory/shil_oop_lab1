namespace shil_oop_lab1
{
    partial class Form1
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
            formsPlot1 = new ScottPlot.WinForms.FormsPlot();
            buttonGenerate = new Button();
            buttonSort = new Button();
            comboBoxAlgorithm = new ComboBox();
            checkBox = new CheckBox();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(14, 16);
            formsPlot1.Margin = new Padding(3, 4, 3, 4);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(887, 424);
            formsPlot1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(63, 448);
            buttonGenerate.Margin = new Padding(3, 4, 3, 4);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(86, 31);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(155, 448);
            buttonSort.Margin = new Padding(3, 4, 3, 4);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(86, 31);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.FormattingEnabled = true;
            comboBoxAlgorithm.Location = new Point(248, 449);
            comboBoxAlgorithm.Margin = new Padding(3, 4, 3, 4);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new Size(138, 28);
            comboBoxAlgorithm.Sorted = true;
            comboBoxAlgorithm.TabIndex = 3;
            // 
            // checkBox
            // 
            checkBox.AutoSize = true;
            checkBox.Location = new Point(413, 452);
            checkBox.Name = "checkBox";
            checkBox.Size = new Size(90, 24);
            checkBox.TabIndex = 5;
            checkBox.Text = "direction";
            checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(checkBox);
            Controls.Add(comboBoxAlgorithm);
            Controls.Add(buttonSort);
            Controls.Add(buttonGenerate);
            Controls.Add(formsPlot1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ScottPlot.WinForms.FormsPlot formsPlot1;
        private Button buttonGenerate;
        private Button buttonSort;
        private ComboBox comboBoxAlgorithm;
        private CheckBox checkBox;
    }
}
