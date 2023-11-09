namespace GraphicProgrammingLanguage
{
    partial class Canvas
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
            pictureBox = new PictureBox();
            commandTextBox = new TextBox();
            runButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(457, 7);
            pictureBox.Margin = new Padding(2, 2, 2, 2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(492, 379);
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // commandTextBox
            // 
            commandTextBox.Location = new Point(11, 114);
            commandTextBox.Margin = new Padding(2, 2, 2, 2);
            commandTextBox.Multiline = true;
            commandTextBox.Name = "commandTextBox";
            commandTextBox.Size = new Size(391, 222);
            commandTextBox.TabIndex = 1;
            // 
            // runButton
            // 
            runButton.Location = new Point(11, 351);
            runButton.Margin = new Padding(2, 2, 2, 2);
            runButton.Name = "runButton";
            runButton.Size = new Size(172, 31);
            runButton.TabIndex = 2;
            runButton.Text = "Run";
            runButton.UseVisualStyleBackColor = true;
            runButton.Click += runButton_Click;
            // 
            // Canvas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 393);
            Controls.Add(runButton);
            Controls.Add(commandTextBox);
            Controls.Add(pictureBox);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Canvas";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox;
        private TextBox commandTextBox;
        private Button runButton;
    }
}