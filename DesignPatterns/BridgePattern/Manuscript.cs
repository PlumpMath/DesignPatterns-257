namespace DesignPatterns.BridgePattern
{
    public abstract class Manuscript
    {
        protected readonly ICustomFormatter _formatter;

        public Manuscript(ICustomFormatter formatter)
        {
            _formatter = formatter; 
        }

        abstract public void Print(); 
    }
}
