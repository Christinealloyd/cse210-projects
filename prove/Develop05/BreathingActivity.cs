namespace MindfulnessApp.Activities
{
    public class BreathingActivity : ActivityBase
    {
        public BreathingActivity()
        {
            Name = "Breathing";
            Description = "This activity will help you relax by guiding you through deep breathing.";
        }

        public override void Start()
        {
            base.Start();
            DateTime endTime = DateTime.Now.AddSeconds(Duration);
            while (DateTime.Now < endTime)
            {
                Console.WriteLine("Breathe in...");
                PauseWithAnimation(4);
                Console.WriteLine("Breathe out...");
                PauseWithAnimation(4);
            }
            End();
        }
    }
}

