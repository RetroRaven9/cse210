public class Comment
{
    private string _commnet;
    private string _name; 
    public void comments()
    {
        Comment comments = new Comment();
        comments._commnet = "This video is great";
        comments._name = "Tylar Hill";
        Console.WriteLine($"{comments._name} -{comments._commnet}");
        
        Comment comments1 = new Comment();
        comments1._commnet = "This video sucks";
        comments1._name = "Merrik Ward";
        Console.WriteLine($"{comments1._name} -{comments1._commnet}");

        Comment comments2 = new Comment();
        comments2._commnet = "I love this video";
        comments2._name = "Mason McNiff";
        Console.WriteLine($"{comments2._name} -{comments2._commnet}");

        Comment comments3 = new Comment();
        comments3._commnet = "I hate this video";
        comments3._name = "Jacob Rigby";
        Console.WriteLine($"{comments3._name} -{comments3._commnet}");
    }
}