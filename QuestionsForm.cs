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

        private List<Question>? Questions { get; set; }
        private List<int> IndexAnswerQuestions { get; set; }

        private Random Random {  get; set; }

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

                debugLabel.Text = "Devido a um erro não é possível iniciar o jogo! Tente reiniciar a aplicação.";
            }
            else
            {
                PermanentError = false;
            }

            RefreshQuiz(this.Started && !PermanentError);
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            this.Started = !this.Started;

            bool active = this.Started && !PermanentError;

            RefreshQuiz(active);

            if (active)
            {
                RefreshQuestion();
                debugLabel.Text = "Você iniciou o jogo.";
            }
            else
            {
                questionLabel.Text = "";

                // Limpa as variáveis.
                Points = 0;
                IndexAnswerQuestions.Clear();

                // Mensagem de Aviso
                debugLabel.Text = "Você finalizou o jogo.";

                // Atualiza a pontuação após as variáveis serem limpas.
                RefreshScore();
            }
        }

        private void ResponseButton_Click(object sender, EventArgs e)
        {
            if (Questions == null) return;

            string text = questionLabel.Text;
            string answer = responseTextBox.Text.ToLower();

            Question? question = Questions.FirstOrDefault(x => x.Text == text);

            if (question == null)
            {
                debugLabel.Text = "Não foi possível encontrar a questão atual! A mesma será trocada automáticamente.";
                responseTextBox.Clear();

                RefreshQuestion();
                return;
            }

            if (string.IsNullOrEmpty(answer.Replace(" ", "")))
            {
                debugLabel.Text = "A resposta não pode estar vazia.";
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
            }

            responseTextBox.Clear();

            RefreshScore();
            RefreshQuestion();
        }

        /* Helpers */

        private void RefreshQuiz(bool active)
        {
            this.responseTextBox.ReadOnly = !active;
            this.responseButton.Visible = active;

            this.toggleButton.BackColor = (!active ? Color.SeaGreen : Color.Red);
            this.toggleButton.Text = (active ? "Terminar" : "Iniciar");

            statusLabel.Text = (active ? "Iniciado" : "Desativado");
            statusLabel.ForeColor = (active ? Color.SeaGreen : Color.Red);

            RefreshScore();
        }

        private void RefreshQuestion()
        {
            if (Questions == null) return;

            int count = Questions.Count;

            if (IndexAnswerQuestions.Count == count)
            {
                IndexAnswerQuestions.Clear();
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