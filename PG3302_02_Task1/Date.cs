namespace PG3302_02_Task1;

public class Date(int month) {
    public enum months {
        january = 1,
        february,
        mars,
        april,
        may,
        jun,
        july,
        august,
        september,
        october,
        november,
        december
    }

    private int _month = month;

    public string Month {
        get { return ((months)_month).ToString(); }
    }
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