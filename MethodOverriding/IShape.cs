namespace MethodOverriding
{
    public interface IShape
    {
        int Width { get; }
        int Height { get; }
        Position Position { get; }

        void Draw();
    }
}
