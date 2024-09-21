namespace Quiz
{
    partial class QuestionsForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionsForm));
            titleLabel = new Label();
            blackgroundPictureBox = new PictureBox();
            statusTitleLabel = new Label();
            answersTitleLabel = new Label();
            scoreTitleLabel = new Label();
            statusLabel = new Label();
            answersLabel = new Label();
            scoreLabel = new Label();
            toggleButton = new Button();
            responseButton = new Button();
            questionLabel = new Label();
            responseTextBox = new TextBox();
            responseTitleLabel = new Label();
            debugLabel = new Label();
            timeTimer = new System.Windows.Forms.Timer(components);
            timeLabel = new Label();
            timeTitleLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)blackgroundPictureBox).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            resources.ApplyResources(titleLabel, "titleLabel");
            titleLabel.ForeColor = Color.FromArgb(0, 64, 0);
            titleLabel.Name = "titleLabel";
            // 
            // blackgroundPictureBox
            // 
            blackgroundPictureBox.BackColor = SystemColors.Control;
            resources.ApplyResources(blackgroundPictureBox, "blackgroundPictureBox");
            blackgroundPictureBox.Name = "blackgroundPictureBox";
            blackgroundPictureBox.TabStop = false;
            // 
            // statusTitleLabel
            // 
            resources.ApplyResources(statusTitleLabel, "statusTitleLabel");
            statusTitleLabel.BackColor = SystemColors.Control;
            statusTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            statusTitleLabel.Name = "statusTitleLabel";
            // 
            // answersTitleLabel
            // 
            resources.ApplyResources(answersTitleLabel, "answersTitleLabel");
            answersTitleLabel.BackColor = SystemColors.Control;
            answersTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            answersTitleLabel.Name = "answersTitleLabel";
            // 
            // scoreTitleLabel
            // 
            resources.ApplyResources(scoreTitleLabel, "scoreTitleLabel");
            scoreTitleLabel.BackColor = SystemColors.Control;
            scoreTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            scoreTitleLabel.Name = "scoreTitleLabel";
            // 
            // statusLabel
            // 
            resources.ApplyResources(statusLabel, "statusLabel");
            statusLabel.BackColor = SystemColors.Control;
            statusLabel.ForeColor = Color.Red;
            statusLabel.Name = "statusLabel";
            // 
            // answersLabel
            // 
            resources.ApplyResources(answersLabel, "answersLabel");
            answersLabel.BackColor = SystemColors.Control;
            answersLabel.ForeColor = Color.Green;
            answersLabel.Name = "answersLabel";
            // 
            // scoreLabel
            // 
            resources.ApplyResources(scoreLabel, "scoreLabel");
            scoreLabel.BackColor = SystemColors.Control;
            scoreLabel.ForeColor = Color.Green;
            scoreLabel.Name = "scoreLabel";
            // 
            // toggleButton
            // 
            toggleButton.BackColor = Color.SeaGreen;
            resources.ApplyResources(toggleButton, "toggleButton");
            toggleButton.ForeColor = SystemColors.ControlLightLight;
            toggleButton.Name = "toggleButton";
            toggleButton.UseVisualStyleBackColor = false;
            toggleButton.Click += ToggleButton_Click;
            // 
            // responseButton
            // 
            responseButton.BackColor = Color.SeaGreen;
            resources.ApplyResources(responseButton, "responseButton");
            responseButton.ForeColor = SystemColors.ControlLightLight;
            responseButton.Name = "responseButton";
            responseButton.UseVisualStyleBackColor = false;
            responseButton.Click += ResponseButton_Click;
            // 
            // questionLabel
            // 
            resources.ApplyResources(questionLabel, "questionLabel");
            questionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            questionLabel.Name = "questionLabel";
            // 
            // responseTextBox
            // 
            responseTextBox.BorderStyle = BorderStyle.FixedSingle;
            resources.ApplyResources(responseTextBox, "responseTextBox");
            responseTextBox.Name = "responseTextBox";
            responseTextBox.ReadOnly = true;
            responseTextBox.KeyDown += responseTextBox_KeyDown;
            // 
            // responseTitleLabel
            // 
            resources.ApplyResources(responseTitleLabel, "responseTitleLabel");
            responseTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            responseTitleLabel.Name = "responseTitleLabel";
            // 
            // debugLabel
            // 
            resources.ApplyResources(debugLabel, "debugLabel");
            debugLabel.BackColor = SystemColors.Control;
            debugLabel.ForeColor = Color.Red;
            debugLabel.Name = "debugLabel";
            // 
            // timeTimer
            // 
            timeTimer.Enabled = true;
            timeTimer.Interval = 1000;
            timeTimer.Tick += timeTimer_Tick;
            // 
            // timeLabel
            // 
            resources.ApplyResources(timeLabel, "timeLabel");
            timeLabel.BackColor = SystemColors.Control;
            timeLabel.ForeColor = Color.Green;
            timeLabel.Name = "timeLabel";
            // 
            // timeTitleLabel
            // 
            resources.ApplyResources(timeTitleLabel, "timeTitleLabel");
            timeTitleLabel.BackColor = SystemColors.Control;
            timeTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            timeTitleLabel.Name = "timeTitleLabel";
            // 
            // QuestionsForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            Controls.Add(timeLabel);
            Controls.Add(timeTitleLabel);
            Controls.Add(titleLabel);
            Controls.Add(debugLabel);
            Controls.Add(responseTitleLabel);
            Controls.Add(responseTextBox);
            Controls.Add(questionLabel);
            Controls.Add(responseButton);
            Controls.Add(toggleButton);
            Controls.Add(scoreLabel);
            Controls.Add(answersLabel);
            Controls.Add(statusLabel);
            Controls.Add(scoreTitleLabel);
            Controls.Add(answersTitleLabel);
            Controls.Add(statusTitleLabel);
            Controls.Add(blackgroundPictureBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuestionsForm";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)blackgroundPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox blackgroundPictureBox;
        private Label statusTitleLabel;
        private Label answersTitleLabel;
        private Label scoreTitleLabel;
        private Label statusLabel;
        private Label answersLabel;
        private Label scoreLabel;
        private Button toggleButton;
        private Button responseButton;
        private Label questionLabel;
        private TextBox responseTextBox;
        private Label responseTitleLabel;
        private Label debugLabel;
        private System.Windows.Forms.Timer timeTimer;
        private Label timeLabel;
        private Label timeTitleLabel;
    }
}
