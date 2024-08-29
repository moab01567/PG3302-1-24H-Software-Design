namespace PG3302_02_Task1;

public class Person
{
    private string _fistName;
    private string _lastName;
    
    public string FirstName {
        set { _fistName = value;} get{return _fistName;} }
    public string LastName { set{} get; }
}