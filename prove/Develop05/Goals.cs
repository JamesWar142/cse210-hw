class Goals
{
    private string _goals;
    private int _points;
    private string _description;
    private string _name;

    public Goals(string goals, int points, string description, string name)
    {
        _goals=goals;
        _points=points;
        _description=description;
        _name=name;
    }
    public string GoalInformation()
    {
        return $"This is the {_name} where we {_description}.{_points}";
    }
}