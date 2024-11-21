using System;

public class NerdLove
{
    private int _confidenceLevel = 0; // The more confidence, the better the interaction. 😉

    public bool ComplimentsEnabled { get; set; }
    public string SassLevel { get; set; }
    public bool AutoFlirt { get; set; }

    public NerdLove(bool complimentsEnabled = false, string sassLevel = "mild", bool autoFlirt = false)
    {
        ComplimentsEnabled = complimentsEnabled;
        SassLevel = sassLevel;
        AutoFlirt = autoFlirt;
    }

    // Initiates a nerdy interaction with a hint of flirtation. 
    public void InitiateInteraction(Action<string> callback)
    {
        Console.WriteLine("Initializing nerdy interaction... 🤓");

        var pickupLines = new string[]
        {
            "Are you a method? Because I can't stop calling you. 😏",
            "Are you a constructor? Because you just initialized my heart. 🧡",
            "You must be a class, because I can see you’re the blueprint to my happiness. ❤️"
        };

        var randomLine = pickupLines[new Random().Next(pickupLines.Length)];

        if (AutoFlirt)
        {
            Console.WriteLine($"Auto-Flirt Activated: \"{randomLine}\"");
            callback("🥰");
        }
        else
        {
            Console.WriteLine("Waiting for response... 🫣");
            callback("🥺");
        }
    }

    // Boosts confidence level to make the interaction more exciting.
    public void BoostConfidence(int amount = 1)
    {
        _confidenceLevel += amount;
        Console.WriteLine($"Confidence level increased to {_confidenceLevel}. Feeling bolder. 😏");
    }

    // Shares a compliment (if enabled).
    public void ShareCompliment()
    {
        if (!ComplimentsEnabled)
        {
            Console.WriteLine("Compliments are disabled. Oh no! 😅");
            return;
        }

        var compliments = new string[]
        {
            "Your code? Perfect. 🧑‍💻💋",
            "I’ve never seen such elegant syntax before. 😘",
            "Is it hot in here, or is it just your logic? 🔥"
        };

        var randomCompliment = compliments[new Random().Next(compliments.Length)];
        Console.WriteLine($"Compliment: \"{randomCompliment}\"");
    }

    // Adjusts sass level.
    public void AdjustSassLevel(string level)
    {
        var validLevels = new[] { "mild", "spicy", "feral" };
        if (Array.Exists(validLevels, x => x == level))
        {
            SassLevel = level;
            Console.WriteLine($"Sass level set to '{SassLevel}'. Watch out! 💅");
        }
        else
        {
            Console.WriteLine("Invalid sass level. Defaulting to 'mild'. 🧐");
            SassLevel = "mild";
        }
    }
}

// Example usage:
class Program
{
    static void Main()
    {
        var nerd = new NerdLove(complimentsEnabled: true, sassLevel: "spicy", autoFlirt: true);

        nerd.InitiateInteraction(response => Console.WriteLine($"Response: {response}"));
        nerd.ShareCompliment();
        nerd.BoostConfidence(5);
        nerd.AdjustSassLevel("feral");
    }
}

namespace LB1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
