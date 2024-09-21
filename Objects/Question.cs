namespace Quiz.Objects
{
    internal class Question
    {
        public string Text {  get; set; }
        public string Answer { get; set; }

        public Question(string text, string answer) 
        { 
            this.Text = text;
            this.Answer = answer;
        }
    }
}