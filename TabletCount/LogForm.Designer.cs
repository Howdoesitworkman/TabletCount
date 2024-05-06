namespace TabletCount
{
    partial class LogForm
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
            exitButton = new Button();
            richTextBoxLog = new RichTextBox();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.BackColor = SystemColors.ActiveCaption;
            exitButton.Location = new Point(687, 394);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 50);
            exitButton.TabIndex = 0;
            exitButton.Text = "Close";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // richTextBoxLog
            // 
            richTextBoxLog.Location = new Point(12, 12);
            richTextBoxLog.Name = "richTextBoxLog";
            richTextBoxLog.Size = new Size(669, 432);
            richTextBoxLog.TabIndex = 1;
            richTextBoxLog.Text = "";
            // 
            // LogForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(839, 456);
            Controls.Add(richTextBoxLog);
            Controls.Add(exitButton);
            Name = "LogForm";
            Text = "LogForm";
            Load += LogForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button exitButton;
        private RichTextBox richTextBoxLog;
    }
}