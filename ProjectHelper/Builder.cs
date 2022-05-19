namespace ProjectHelper;

public abstract class Builder<T>: IBuilder<T> where T: new()
{
    protected T Result;

    protected Builder()
    {
        this.Result = new T();
    }

    public void Reset()
    {
        this.Result = new T();
    }

    public T Build()
    {
        T build = Result;
        this.Reset();
        return build;
    }
}