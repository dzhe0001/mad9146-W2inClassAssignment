class Car
{
    private string model;
    public string Model
    {
        get { return model; }
        set { model = value; }
    }
    
    private Engine engine;
    public Engine Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public void Describe()
    {
        Console.WriteLine("Model: " + this.model);
        Console.WriteLine("Engine: " + this.engine.HorsePower);
    }
}