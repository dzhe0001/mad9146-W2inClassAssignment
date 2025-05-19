class Student
{
    private string name;
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    private int grade;
    public int Grade
    {
        get { return grade; }
        set
        {
            if (value >= 0 && value <= 100)
            {
                grade = value;
            }
        }
    }

    public bool IsPassing()
    {
        return this.grade >= 50;
    }
}