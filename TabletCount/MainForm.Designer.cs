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
            drugOne = new Label();
            drugTwo = new Label();
            drugThree = new Label();
            drugOneCount = new Label();
            drugTwoCount = new Label();
            drugThreeCount = new Label();
            drugOneIncre = new Button();
            drugTwoIncre = new Button();
            drugThreeIncre = new Button();
            resetButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // drugOne
            // 
            drugOne.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugOne.Location = new Point(91, 81);
            drugOne.Name = "drugOne";
            drugOne.Size = new Size(129, 29);
            drugOne.TabIndex = 0;
            drugOne.Text = "label1";
            // 
            // drugTwo
            // 
            drugTwo.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugTwo.Location = new Point(323, 81);
            drugTwo.Name = "drugTwo";
            drugTwo.Size = new Size(129, 29);
            drugTwo.TabIndex = 1;
            drugTwo.Text = "label2";
            // 
            // drugThree
            // 
            drugThree.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugThree.Location = new Point(555, 81);
            drugThree.Name = "drugThree";
            drugThree.Size = new Size(129, 29);
            drugThree.TabIndex = 2;
            drugThree.Text = "label3";
            // 
            // drugOneCount
            // 
            drugOneCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugOneCount.Location = new Point(91, 149);
            drugOneCount.Name = "drugOneCount";
            drugOneCount.Size = new Size(129, 29);
            drugOneCount.TabIndex = 3;
            drugOneCount.Text = "count: ";
            // 
            // drugTwoCount
            // 
            drugTwoCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugTwoCount.Location = new Point(323, 149);
            drugTwoCount.Name = "drugTwoCount";
            drugTwoCount.Size = new Size(129, 29);
            drugTwoCount.TabIndex = 4;
            drugTwoCount.Text = "count: ";
            // 
            // drugThreeCount
            // 
            drugThreeCount.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            drugThreeCount.Location = new Point(555, 149);
            drugThreeCount.Name = "drugThreeCount";
            drugThreeCount.Size = new Size(129, 29);
            drugThreeCount.TabIndex = 5;
            drugThreeCount.Text = "count: ";
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
            // 
            // resetButton
            // 
            resetButton.Location = new Point(172, 325);
            resetButton.Name = "resetButton";
            resetButton.Size = new Size(140, 50);
            resetButton.TabIndex = 9;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(397, 325);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 50);
            exitButton.TabIndex = 10;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(806, 446);
            Controls.Add(exitButton);
            Controls.Add(resetButton);
            Controls.Add(drugThreeIncre);
            Controls.Add(drugTwoIncre);
            Controls.Add(drugOneIncre);
            Controls.Add(drugThreeCount);
            Controls.Add(drugTwoCount);
            Controls.Add(drugOneCount);
            Controls.Add(drugThree);
            Controls.Add(drugTwo);
            Controls.Add(drugOne);
            Name = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Label drugOne;
        private Label drugTwo;
        private Label drugThree;
        private Label drugOneCount;
        private Label drugTwoCount;
        private Label drugThreeCount;
        private Button drugOneIncre;
        private Button drugTwoIncre;
        private Button drugThreeIncre;
        private Button resetButton;
        private Button exitButton;
    }
}
