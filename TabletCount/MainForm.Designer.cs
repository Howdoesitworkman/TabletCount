namespace TabletCount
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
            drugOneLabel = new Label();
            drugTwoLabel = new Label();
            drugThreeLabel = new Label();
            drugOneCount = new Label();
            drugTwoCount = new Label();
            drugThreeCount = new Label();
            drugOneIncre = new Button();
            drugTwoIncre = new Button();
            drugThreeIncre = new Button();
            resetButton = new Button();
            exitButton = new Button();
            logButton = new Button();
            SuspendLayout();
            // 
            // drugOneLabel
            // 
            drugOneLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugOneLabel.Location = new Point(53, 81);
            drugOneLabel.Name = "drugOneLabel";
            drugOneLabel.Size = new Size(129, 29);
            drugOneLabel.TabIndex = 0;
            drugOneLabel.Text = "Acetaminophen";
            drugOneLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugTwoLabel
            // 
            drugTwoLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugTwoLabel.Location = new Point(285, 81);
            drugTwoLabel.Name = "drugTwoLabel";
            drugTwoLabel.Size = new Size(129, 29);
            drugTwoLabel.TabIndex = 1;
            drugTwoLabel.Text = "Oxycotin";
            drugTwoLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugThreeLabel
            // 
            drugThreeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugThreeLabel.Location = new Point(517, 81);
            drugThreeLabel.Name = "drugThreeLabel";
            drugThreeLabel.Size = new Size(129, 29);
            drugThreeLabel.TabIndex = 2;
            drugThreeLabel.Text = "Ibuprofen";
            drugThreeLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugOneCount
            // 
            drugOneCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugOneCount.Location = new Point(53, 146);
            drugOneCount.Name = "drugOneCount";
            drugOneCount.Size = new Size(129, 29);
            drugOneCount.TabIndex = 3;
            drugOneCount.Text = "count: ";
            drugOneCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugTwoCount
            // 
            drugTwoCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugTwoCount.Location = new Point(285, 146);
            drugTwoCount.Name = "drugTwoCount";
            drugTwoCount.Size = new Size(129, 29);
            drugTwoCount.TabIndex = 4;
            drugTwoCount.Text = "count: ";
            drugTwoCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugThreeCount
            // 
            drugThreeCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugThreeCount.Location = new Point(517, 146);
            drugThreeCount.Name = "drugThreeCount";
            drugThreeCount.Size = new Size(129, 29);
            drugThreeCount.TabIndex = 5;
            drugThreeCount.Text = "count: ";
            drugThreeCount.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // drugOneIncre
            // 
            drugOneIncre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            drugOneIncre.Location = new Point(69, 209);
            drugOneIncre.Name = "drugOneIncre";
            drugOneIncre.Size = new Size(104, 40);
            drugOneIncre.TabIndex = 6;
            drugOneIncre.Text = "increment";
            drugOneIncre.UseVisualStyleBackColor = true;
            drugOneIncre.Click += drugOneIncre_Click;
            // 
            // drugTwoIncre
            // 
            drugTwoIncre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            drugTwoIncre.Location = new Point(301, 209);
            drugTwoIncre.Name = "drugTwoIncre";
            drugTwoIncre.Size = new Size(104, 40);
            drugTwoIncre.TabIndex = 7;
            drugTwoIncre.Text = "increment";
            drugTwoIncre.UseVisualStyleBackColor = true;
            drugTwoIncre.Click += drugTwoIncre_Click;
            // 
            // drugThreeIncre
            // 
            drugThreeIncre.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            drugThreeIncre.Location = new Point(533, 209);
            drugThreeIncre.Name = "drugThreeIncre";
            drugThreeIncre.Size = new Size(104, 40);
            drugThreeIncre.TabIndex = 8;
            drugThreeIncre.Text = "increment";
            drugThreeIncre.UseVisualStyleBackColor = true;
            drugThreeIncre.Click += drugThreeIncre_Click;
            // 
            // resetButton
            // 
            resetButton.BackColor = SystemColors.ActiveCaption;
            resetButton.Location = new Point(96, 325);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(140, 50);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = false;
            resetButton.Click += resetButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = SystemColors.ActiveCaption;
            exitButton.Location = new Point(466, 325);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 50);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // logButton
            // 
            logButton.BackColor = SystemColors.ActiveCaption;
            logButton.Location = new Point(281, 325);
            logButton.Name = "logButton";
            logButton.Size = new Size(140, 50);
            logButton.TabIndex = 11;
            logButton.Text = "Log File";
            logButton.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            ClientSize = new Size(806, 446);
            Controls.Add(logButton);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(drugThreeIncre);
            Controls.Add(drugTwoIncre);
            Controls.Add(drugOneIncre);
            Controls.Add(drugThreeCount);
            Controls.Add(drugTwoCount);
            Controls.Add(drugOneCount);
            Controls.Add(drugThreeLabel);
            Controls.Add(drugTwoLabel);
            Controls.Add(drugOneLabel);
            Name = "MainForm";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Label drugOneLabel;
        private Label drugTwoLabel;
        private Label drugThreeLabel;
        private Label drugOneCount;
        private Label drugTwoCount;
        private Label drugThreeCount;
        private Button drugOneIncre;
        private Button drugTwoIncre;
        private Button drugThreeIncre;
        private Button resetButton;
        private Button exitButton;
        private Button logButton;
    }
}
