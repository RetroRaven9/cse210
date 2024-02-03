public class PromptGenerator
{
    public string[] _prompts = new string[]
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the lords hand in my life today?",
        "What was the stongst emotion i felt today?",
        "If i had one thing I could do over today, what would it be?",
    };

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Length);
        return _prompts[index];
    }
}