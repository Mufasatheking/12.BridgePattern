namespace BridgePattern
{
    //ConcreteImplementor-2
    public class OffState : IState
    {
        public void MoveState()
        {
            Console.Write("Off State");
        }
    }
}