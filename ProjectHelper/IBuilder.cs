namespace ProjectHelper;

public interface IBuilder<out T>
{
    void Reset();
    T Build();
}