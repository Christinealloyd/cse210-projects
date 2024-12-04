namespace MindfulnessApp.Activities
{
    public abstract class ActivityBase
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Duration { get; set; }

        public virtual void Start()
        {
            Console.WriteLine($"Starting {Name} activity.");
            Console.WriteLine(Description);
            Console.WriteLine("Prepare to begin...");
            PauseWithAnimation(3);
        }

        public virtual void End()
        {
            Console.WriteLine($"Good job! You completed the {Name} activity for {Duration} seconds.");
            PauseWithAnimation(2);
        }

        protected void PauseWithAnimation(int seconds)
        {
            DateTime endTime = DateTime.Now.AddSeconds(seconds);
            while (DateTime.Now < endTime)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
            Console.WriteLine();
        }
    }
}

