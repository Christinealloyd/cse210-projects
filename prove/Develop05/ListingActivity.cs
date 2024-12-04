namespace MindfulnessApp.Activities
{
    public class ListingActivity : ActivityBase
    {
        private static readonly string[] Prompts =
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "What are things you are grateful for?"
        };

        public ListingActivity()
        {
            Name = "Listing";
            Description = "This activity will help you focus on the positive by listing items in a given area.";
        }

        public override void Start()
        {
            base.Start();
            Random random = new Random();
            string prompt = Prompts[random.Next(Prompts.Length)];
            Console.WriteLine(prompt);

            PauseWithAnimation(3);
            Console.WriteLine("Start listing items:");
            DateTime endTime = DateTime.Now.AddSeconds(Duration);

            int count = 0;
            while (DateTime.Now < endTime)
            {
                Console.Write("Enter an item: ");
                string item = Console.ReadLine();
                if (!string.IsNullOrEmpty(item))
                {
                    count++;
                }
            }

            Console.WriteLine($"You listed {count} items!");
            End();
        }
    }
}

