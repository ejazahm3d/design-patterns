namespace Behavioural.Iterator
{
    public interface IIterator<T>
    {
        bool HasNext();
        T Current();
        void Next();
    }
}