public class ReflectingActivity
{
    private string _question;

    public ReflectingActivity(string question)
    {
        _question = question;
    }

    public void AskQuestion()
    {
        Console.WriteLine(_question);
        string response = Console.ReadLine();

        // Optional: Store or process the response here
    }


    public void Main()
    {
        // Example with a specific question
        // Reflect activity = new Reflect();
        // activity.AskQuestion();

        // Example with prompt selection (replace with actual prompts)
        string[] prompts = { "What are your biggest challenges right now?", "What are you currently learning?" };
        int choice = ChoosePrompt(prompts);
        // activity = new Reflect(prompts[choice]);
        // activity.AskQuestion();
    }

    private int ChoosePrompt(string[] options)
    {
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }

        while (true)
        {
            Console.Write("Enter your choice (1 - " + options.Length + "): ");
            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice) && choice > 0 && choice <= options.Length)
            {
                return choice - 1; // Adjust for zero-based indexing
            }
            Console.WriteLine("Invalid input. Please enter a number between 1 and " + options.Length);
        }
    }
}