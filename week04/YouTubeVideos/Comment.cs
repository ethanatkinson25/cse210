using System;

class Comment
{
    private string _name;
    private string _text;

    // public void generateComment()
    public Comment()
    {
        Random random = new Random();

        string[] names = { "Bob434", "JAk3", "__Jess1ca__", "_the_green_bean_88", "terminallyOnline", "couldntthinkofabettername", "JuStDoIt", "Command~Block00", "__LIBERATOR65465__", "Your_Clone771" };
        string[] comments = {
            "This is the best video I've ever seen in my life!",
            "The production quality is insane!!!!",
            "Are we just in a simulation? Like in a C# program?",
            "It would be better if BYU was in there...",
            "I'm hungry",
            "A most exquisite, content filled video if I do say so myself.",
            "Can we do a collab??????",
            "I aspire to create something as beautiful as this!",
            "Save the turtles!!!",
            "10/10 would recommend",
            "Even my cat loves this!!",
            "This is what makes the internet worth it...maybe",
            "I've had this on repeat for 8 hours straight. No, I'm not sorry",
            "There's gonna be a movie made about this one day I swear",
            "I'd rather be watching hockey rn",
            "beansbeansbeansbeansbeansbeans",
            "fire comment dude ^^^^",
            "Fist comment lol",
            "My faith in humanity has been restored",
            "Where am I? What is this place???"
        };

        _name = names[random.Next(names.Length)];
        _text = comments[random.Next(comments.Length)];
    }

    public void displayComment()
    {
        Console.WriteLine($"{_name} \n {_text}");
    }
}