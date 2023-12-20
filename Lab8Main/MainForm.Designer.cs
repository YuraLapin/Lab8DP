namespace Lab8Main
{
    partial class MainForm
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
            decodedTextBox = new TextBox();
            encodedTextBox = new TextBox();
            encodeButton = new Button();
            decodeButton = new Button();
            keyTextBox = new TextBox();
            keyLabel = new Label();
            SuspendLayout();
            // 
            // decodedTextBox
            // 
            decodedTextBox.Location = new Point(12, 12);
            decodedTextBox.Multiline = true;
            decodedTextBox.Name = "decodedTextBox";
            decodedTextBox.Size = new Size(347, 140);
            decodedTextBox.TabIndex = 0;
            // 
            // encodedTextBox
            // 
            encodedTextBox.Location = new Point(718, 12);
            encodedTextBox.Multiline = true;
            encodedTextBox.Name = "encodedTextBox";
            encodedTextBox.Size = new Size(347, 140);
            encodedTextBox.TabIndex = 1;
            // 
            // encodeButton
            // 
            encodeButton.Location = new Point(365, 100);
            encodeButton.Name = "encodeButton";
            encodeButton.Size = new Size(347, 23);
            encodeButton.TabIndex = 2;
            encodeButton.Text = "Зашифровать";
            encodeButton.UseVisualStyleBackColor = true;
            encodeButton.Click += encodeButton_Click;
            // 
            // decodeButton
            // 
            decodeButton.Location = new Point(365, 129);
            decodeButton.Name = "decodeButton";
            decodeButton.Size = new Size(347, 23);
            decodeButton.TabIndex = 3;
            decodeButton.Text = "Расшифровать";
            decodeButton.UseVisualStyleBackColor = true;
            decodeButton.Click += decodeButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(365, 36);
            keyTextBox.Multiline = true;
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(347, 58);
            keyTextBox.TabIndex = 4;
            // 
            // keyLabel
            // 
            keyLabel.AutoSize = true;
            keyLabel.Font = new Font("Segoe UI", 12F);
            keyLabel.Location = new Point(511, 12);
            keyLabel.Name = "keyLabel";
            keyLabel.Size = new Size(49, 21);
            keyLabel.TabIndex = 5;
            keyLabel.Text = "Ключ";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1077, 163);
            Controls.Add(keyLabel);
            Controls.Add(keyTextBox);
            Controls.Add(decodeButton);
            Controls.Add(encodeButton);
            Controls.Add(encodedTextBox);
            Controls.Add(decodedTextBox);
            Name = "MainForm";
            Text = "Гаммирование";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox decodedTextBox;
        private TextBox encodedTextBox;
        private Button encodeButton;
        private Button decodeButton;
        private TextBox keyTextBox;
        private Label keyLabel;
    }
}
