namespace PG3302_02_Task1;

public class Person
{
    private string _firstName="<first name not set>";
    private string _lastName="<last name not set>";
    
    public string FirstName {
        set { _firstName = value;} get{return _firstName;} }

    public string LastName { 
        set { _lastName = value.Trim(); } get { return _lastName; } 
    }

    public string FullName {
        get { return $"{_firstName} {_lastName}"; 
    }



}