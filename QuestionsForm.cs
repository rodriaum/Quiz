namespace Quiz
{
    public partial class QuestionsForm : Form
    {
        /* Varibles */

        private bool Started { get; set; }

        /* Procedures */

        public QuestionsForm()
        {
            InitializeComponent();
        }

        private void QuestionsForm_Load(object sender, EventArgs e)
        {
            this.Started = false;

            RefreshQuiz();
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            this.Started = !this.Started;

            RefreshQuiz();
        }

        /* Helpers */

        private void RefreshQuiz()
        {
            this.responseTextBox.ReadOnly = !this.Started;
            this.responseButton.Visible = this.Started;

            this.toggleButton.BackColor = (!this.Started ? Color.SeaGreen : Color.Red);
            this.toggleButton.Text = (this.Started ? "Terminar" : "Iniciar");

            statusLabel.Text = (this.Started ? "Iniciado" : "Desativado");
            statusLabel.ForeColor = (this.Started ? Color.SeaGreen : Color.Red);
        }
    }
}
