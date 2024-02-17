public class Reference
{
    // Is the bookk chapter and verse for the scripture
    private string _book;
    private string _chapter;
    private string _verse;

    public string Book
    {
        get { return _book; }
        set { _book = value; }
    }

    public string Chapter
    {
        get { return _chapter; }
        set { _chapter = value; }
    }

    public string Verse
    {
        get { return _verse; }
        set { _verse = value; }
    }

    // Add constructors and any additional methods or properties as needed
}