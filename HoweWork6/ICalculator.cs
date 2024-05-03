namespace HomeWork5
{
    public interface ICalculator
    {
        public event EventHandler<EventArgs> MyEventHandler;
        public void Sum();
        public void Div();
        public void Sub();
        public void Multy();
        public void CancelLast();
        public void Start();
    }
}
