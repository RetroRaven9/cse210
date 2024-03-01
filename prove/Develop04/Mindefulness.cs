using System.Runtime.CompilerServices;
using System.Timers;
public class Mindfulness
{
    // This is the class that will go to all the other classes
    // needs the timer and load dial that is used on all the other classes
        public void animationStrings(){
            List<string> animationStrings = new List<string>();
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");
            animationStrings.Add("|");
            animationStrings.Add("/");
            animationStrings.Add("-");
            animationStrings.Add("\\");

            foreach (string s in animationStrings)
            {
                Console.Write(s);
                Thread.Sleep(100);
                Console.Write("\b \b");
            }
            Console.WriteLine("Done.");
        }

        public void Timer()
        {
           for (int i = 5; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                // /b /b clears writeline
                Console.Write ("\b \b");
            }   
            Console.WriteLine("Done.");
        }
}



