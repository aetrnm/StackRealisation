namespace StackRealisation
{
    public interface IStack
    {
        int Pop();
        int Peek();
        void Push(int value);
        bool IsEmpty();
    }
}