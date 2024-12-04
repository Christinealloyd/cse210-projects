namespace MindfulnessApp.Activities
{
    public class ReflectionActivity : ActivityBase
    {
        private static readonly string[] Prompts =
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need."
        };

        private static readonly string[] Questions =
        {
            "Why was this experience meaningful to you?",
            "What did you learn from this experience?",
            "How can you apply this in the future?"
        };

        public ReflectionActivity()
        {
            Name = "Reflection";
            Description = "This activity will help you reflect on moments of strength and resilience.";
        }

        public override void Start()
        {
            base.Start();
            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Length)];
            Console.WriteLine(prompt);

            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                string question = Questions[random.Next(Questions.Length)];
                Console.WriteLine(question);
                PauseWithAnimation(5);
            }
            End();
        }
    }
}
