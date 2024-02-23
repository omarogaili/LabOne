namespace Metoder;
//this class should contain this property date, rubric and content  objects & orintering 
public class DiaryEntry
{
      public DateTime datum;
    public string? rubric;
    public string? content;

 public DiaryEntry( DateTime datumO,string rubric, string content)
        {
            this.Datum = datumO;
            this.rubric = rubric;
            this.content = content;
        }

    public DiaryEntry(DateTime? datum1, string? rubric, string? content)
    {
        Datum1 = datum1;
        this.rubric = rubric;
        this.content = content;
    }

    public DateTime Datum
        {
            get { return datum; }   
            set { datum = value; }
        }
    public string? Content
    {
        get { return content; }
        set { content = value; }
    }

    public DateTime? Datum1 { get; }
}
