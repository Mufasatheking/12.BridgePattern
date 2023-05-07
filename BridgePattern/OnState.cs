namespace BridgePattern
{
    //ConcreteImplementor-1
    public class OnState : IState
    {
        public void MoveState()
        {
            Console.Write("On State");
        }
    }
}