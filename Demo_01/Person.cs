class Person
{
    private int age;
    private string name;

    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public override string ToString()
    {
        return string.Format("姓名：{0}，年龄：{1}", name, age);
    }
}