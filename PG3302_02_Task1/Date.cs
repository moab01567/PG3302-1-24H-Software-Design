namespace PG3302_02_Task1;

public class Date {


    public Date(int month)
    {
       Month = month;
    }
    public int Month {  get; }
    /*
    public int Month
    private int month;
    {
        get { return month;}
        set {
            if (value is >= 1 and <= 12){ month = value;}
        }
        
    }
    
     public int Month { set; get; }
     public int Month { private set; get; }
     public int Month {  get; }
    */
}