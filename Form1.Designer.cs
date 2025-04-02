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
            labelTime = new Label();
            radioButtonAscending = new RadioButton();
            SuspendLayout();
            // 
            // formsPlot1
            // 
            formsPlot1.DisplayScale = 1F;
            formsPlot1.Location = new Point(12, 12);
            formsPlot1.Name = "formsPlot1";
            formsPlot1.Size = new Size(776, 318);
            formsPlot1.TabIndex = 0;
            // 
            // buttonGenerate
            // 
            buttonGenerate.Location = new Point(55, 336);
            buttonGenerate.Name = "buttonGenerate";
            buttonGenerate.Size = new Size(75, 23);
            buttonGenerate.TabIndex = 1;
            buttonGenerate.Text = "Generate";
            buttonGenerate.UseVisualStyleBackColor = true;
            buttonGenerate.Click += buttonGenerate_Click;
            // 
            // buttonSort
            // 
            buttonSort.Location = new Point(136, 336);
            buttonSort.Name = "buttonSort";
            buttonSort.Size = new Size(75, 23);
            buttonSort.TabIndex = 2;
            buttonSort.Text = "Sort";
            buttonSort.UseVisualStyleBackColor = true;
            buttonSort.Click += buttonSort_Click;
            // 
            // comboBoxAlgorithm
            // 
            comboBoxAlgorithm.FormattingEnabled = true;
            comboBoxAlgorithm.Items.AddRange(new object[] { "Cocktail", "Insertion", "Radix" });
            comboBoxAlgorithm.Location = new Point(217, 337);
            comboBoxAlgorithm.Name = "comboBoxAlgorithm";
            comboBoxAlgorithm.Size = new Size(121, 23);
            comboBoxAlgorithm.Sorted = true;
            comboBoxAlgorithm.TabIndex = 3;
            // 
            // labelTime
            // 
            labelTime.AutoSize = true;
            labelTime.Location = new Point(492, 336);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(33, 15);
            labelTime.TabIndex = 4;
            labelTime.Text = "Time";
            // 
            // radioButtonAscending
            // 
            radioButtonAscending.AutoSize = true;
            radioButtonAscending.Location = new Point(354, 340);
            radioButtonAscending.Name = "radioButtonAscending";
            radioButtonAscending.Size = new Size(81, 19);
            radioButtonAscending.TabIndex = 5;
            radioButtonAscending.TabStop = true;
            radioButtonAscending.Text = "Ascending";
            radioButtonAscending.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(radioButtonAscending);
            Controls.Add(labelTime);
            Controls.Add(comboBoxAlgorithm);
            Controls.Add(buttonSort);
            Controls.Add(buttonGenerate);
            Controls.Add(formsPlot1);
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
        private Label labelTime;
        private RadioButton radioButtonAscending;
    }
}
