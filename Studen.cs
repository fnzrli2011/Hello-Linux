class Studen
{
    public string Name {get; set;}
    private string surname;
    public string Surname
    {
        get
        {
            return surname;
        }
        set
        {
            if(Char.IsUpper(value[0])) surname=value;
        }
    }
}