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
            titleLabel = new Label();
            pictureBox1 = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            titleLabel.Location = new Point(12, 9);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(96, 45);
            titleLabel.TabIndex = 0;
            titleLabel.Text = "QUIZ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.Location = new Point(12, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 110);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // statusTitleLabel
            // 
            statusTitleLabel.AutoSize = true;
            statusTitleLabel.BackColor = SystemColors.Control;
            statusTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            statusTitleLabel.Location = new Point(538, 132);
            statusTitleLabel.Name = "statusTitleLabel";
            statusTitleLabel.Size = new Size(42, 15);
            statusTitleLabel.TabIndex = 2;
            statusTitleLabel.Text = "Estado";
            statusTitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answersTitleLabel
            // 
            answersTitleLabel.AutoSize = true;
            answersTitleLabel.BackColor = SystemColors.Control;
            answersTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            answersTitleLabel.Location = new Point(76, 131);
            answersTitleLabel.Name = "answersTitleLabel";
            answersTitleLabel.Size = new Size(59, 15);
            answersTitleLabel.TabIndex = 3;
            answersTitleLabel.Text = "Respostas";
            // 
            // scoreTitleLabel
            // 
            scoreTitleLabel.AutoSize = true;
            scoreTitleLabel.BackColor = SystemColors.Control;
            scoreTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            scoreTitleLabel.Location = new Point(303, 131);
            scoreTitleLabel.Name = "scoreTitleLabel";
            scoreTitleLabel.Size = new Size(64, 15);
            scoreTitleLabel.TabIndex = 4;
            scoreTitleLabel.Text = "Pontuação";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.BackColor = SystemColors.Control;
            statusLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            statusLabel.ForeColor = Color.Red;
            statusLabel.Location = new Point(525, 112);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new Size(84, 20);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Desativado";
            statusLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // answersLabel
            // 
            answersLabel.AutoSize = true;
            answersLabel.BackColor = SystemColors.Control;
            answersLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            answersLabel.ForeColor = Color.Green;
            answersLabel.Location = new Point(88, 112);
            answersLabel.Name = "answersLabel";
            answersLabel.Size = new Size(31, 20);
            answersLabel.TabIndex = 6;
            answersLabel.Text = "0/0";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.BackColor = SystemColors.Control;
            scoreLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            scoreLabel.ForeColor = Color.Green;
            scoreLabel.Location = new Point(328, 112);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(17, 20);
            scoreLabel.TabIndex = 7;
            scoreLabel.Text = "0";
            // 
            // toggleButton
            // 
            toggleButton.BackColor = Color.SeaGreen;
            toggleButton.FlatStyle = FlatStyle.Flat;
            toggleButton.ForeColor = SystemColors.ControlLightLight;
            toggleButton.Location = new Point(12, 173);
            toggleButton.Name = "toggleButton";
            toggleButton.Size = new Size(120, 40);
            toggleButton.TabIndex = 8;
            toggleButton.Text = "Iniciar";
            toggleButton.UseVisualStyleBackColor = false;
            toggleButton.Click += ToggleButton_Click;
            // 
            // responseButton
            // 
            responseButton.BackColor = Color.SeaGreen;
            responseButton.FlatStyle = FlatStyle.Flat;
            responseButton.ForeColor = SystemColors.ControlLightLight;
            responseButton.Location = new Point(138, 173);
            responseButton.Name = "responseButton";
            responseButton.Size = new Size(120, 40);
            responseButton.TabIndex = 9;
            responseButton.Text = "Responder";
            responseButton.UseVisualStyleBackColor = false;
            responseButton.Visible = false;
            responseButton.Click += ResponseButton_Click;
            // 
            // questionLabel
            // 
            questionLabel.AutoSize = true;
            questionLabel.ForeColor = Color.FromArgb(64, 64, 64);
            questionLabel.Location = new Point(21, 250);
            questionLabel.Name = "questionLabel";
            questionLabel.Size = new Size(0, 15);
            questionLabel.TabIndex = 11;
            // 
            // responseTextBox
            // 
            responseTextBox.BorderStyle = BorderStyle.FixedSingle;
            responseTextBox.Location = new Point(12, 302);
            responseTextBox.Name = "responseTextBox";
            responseTextBox.ReadOnly = true;
            responseTextBox.Size = new Size(345, 23);
            responseTextBox.TabIndex = 12;
            responseTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // responseTitleLabel
            // 
            responseTitleLabel.AutoSize = true;
            responseTitleLabel.ForeColor = SystemColors.ControlDarkDark;
            responseTitleLabel.Location = new Point(12, 284);
            responseTitleLabel.Name = "responseTitleLabel";
            responseTitleLabel.Size = new Size(54, 15);
            responseTitleLabel.TabIndex = 13;
            responseTitleLabel.Text = "Resposta";
            // 
            // debugLabel
            // 
            debugLabel.AutoSize = true;
            debugLabel.BackColor = SystemColors.Control;
            debugLabel.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            debugLabel.ForeColor = Color.Red;
            debugLabel.Location = new Point(12, 57);
            debugLabel.Name = "debugLabel";
            debugLabel.Size = new Size(0, 12);
            debugLabel.TabIndex = 14;
            // 
            // QuestionsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(684, 423);
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
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "QuestionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quiz";
            Load += QuestionsForm_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label titleLabel;
        private PictureBox pictureBox1;
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
    }
}
