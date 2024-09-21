using Quiz.Json;
using Quiz.Objects;
using Quiz.Util.Extra;
using System.Text.Json;

namespace Quiz
{
    public partial class QuestionsForm : Form
    {
        /* Varibles */

        private bool Started { get; set; }
        private bool PermanentError { get; set; }

        private int Points { get; set; }
        private int Time { get; set; }

        private List<Question>? Questions { get; set; }
        private List<int> IndexAnswerQuestions { get; set; }

        private Random Random { get; set; }

        /* Procedures */

        public QuestionsForm()
        {
            InitializeComponent();
        }

        private async void QuestionsForm_Load(object sender, EventArgs e)
        {
            this.Started = false;

            IndexAnswerQuestions = new List<int>();
            Random = new Random();

            Questions = await JsonHelper.GetJsonQuestions("questions.json");

            if (Questions == null || Questions.Count == 0)
            {
                PermanentError = true;

                HandleDebug("Devido a um erro não é possível iniciar o jogo! Tente reiniciar a aplicação.", true);
            }
            else
            {
                PermanentError = false;
            }

            RefreshQuiz(this.Started && !PermanentError);
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            if (this.Started && !PermanentError)
            {
                Time++;
                timeLabel.Text = TimeUtil.FormatTime(Time, true);
            }
        }

        private void responseTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                HandleResponse();
            }
        }

        private void ResponseButton_Click(object sender, EventArgs e)
        {
            HandleResponse();
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            this.Started = !this.Started;

            bool active = this.Started && !PermanentError;

            RefreshQuiz(active);

            if (active)
            {
                timeTimer.Start();

                RefreshQuestion();
                HandleDebug("Você iniciou o jogo.");
            }
            else
            {
                timeTimer.Stop();

                questionLabel.Text = "";

                // Limpa as variáveis.
                Points = 0;
                IndexAnswerQuestions.Clear();

                // Mensagem de Aviso
                HandleDebug("Você finalizou o jogo.");

                // Atualiza a pontuação após as variáveis serem limpas.
                RefreshScore();
            }
        }

        /* Helpers */

        public async void HandleDebug(string s, bool isError = false)
        {
            debugLabel.ForeColor = (isError ? Color.Red : Color.Green);
            debugLabel.Text = s;

            await Task.Delay(3000);

            debugLabel.Text = "";
        }

        public void HandleResponse()
        {
            if (Questions == null) return;

            string text = questionLabel.Text;
            string answer = responseTextBox.Text.ToLower();

            Question? question = Questions.FirstOrDefault(x => x.Text == text);

            if (question == null)
            {
                HandleDebug("Não foi possível encontrar a questão atual! A mesma será trocada automáticamente.", true);
                responseTextBox.Clear();

                RefreshQuestion();
                return;
            }

            if (string.IsNullOrEmpty(answer.Replace(" ", "")))
            {
                HandleDebug("A resposta não pode estar vazia.");
                return;
            }

            string correctAnswer = question.Answer.ToLower();

            if (FormatterUtil.RemoveAccents(answer) == FormatterUtil.RemoveAccents((correctAnswer)))
            {
                Points += 100;
            }
            else
            {
                if (Points > 0)
                    Points -= 50;

                HandleDebug($"Ops! A resposta correta era \"{question.Answer}\"");
            }

            responseTextBox.Clear();

            RefreshScore();
            RefreshQuestion();
        }

        private void RefreshQuiz(bool active)
        {
            this.responseTextBox.ReadOnly = !active;
            this.responseButton.Visible = active;

            this.toggleButton.BackColor = (!active ? Color.SeaGreen : Color.Red);
            this.toggleButton.Text = (active ? "Terminar" : "Iniciar");

            statusLabel.Text = (active ? "Iniciado" : "Desativado");
            statusLabel.ForeColor = (active ? Color.Green : Color.Red);

            RefreshScore();
        }

        private void RefreshQuestion()
        {
            if (Questions == null) return;

            int count = Questions.Count;

            if (IndexAnswerQuestions.Count == count)
            {
                IndexAnswerQuestions.Clear();
                HandleDebug("Quiz terminado em " + TimeUtil.FormatTime(Time));
            }

            int index = Random.Next(count);

            while (IndexAnswerQuestions.Contains(index))
            {
                index = Random.Next(count);
            }

            IndexAnswerQuestions.Add(index);

            questionLabel.Text = Questions[index].Text;
        }

        private void RefreshScore()
        {
            if (Questions == null) return;

            answersLabel.Text = IndexAnswerQuestions.Count + "/" + Questions.Count;
            scoreLabel.Text = Points.ToString();
        }
    }
}