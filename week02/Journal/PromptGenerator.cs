using System.Collections.Generic;
using System.Text.RegularExpressions;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts = [
            "What made you feel confident today?",
            "What made you feel confident today?",
            "Did you understand Lord's voice?",
            "What do you want to improve the next day?",
            "What is a feeling from today that I dont want to feel again?",
            "What made you smile today?",
            "Describe a challenge you overcame recently.",
            "What are you grateful for right now?",
            "Write about a moment of peace you experienced.",
            "What is something that you learned today?"
        ];

        // number of items in the list
        int lenPrompts = _prompts.Count();

        // Get random number within the renge of number of items
        Random random = new Random();
        int randomPromptIndex = random.Next(lenPrompts);

        // return the indexed prompt
        return _prompts[randomPromptIndex];
    }
}