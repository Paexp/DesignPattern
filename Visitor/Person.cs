namespace Visitor
{
    abstract class Person
    {
        public abstract void Accept(Action visitor);
    }
}
