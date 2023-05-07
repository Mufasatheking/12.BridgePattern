namespace BridgePattern
{
    //Refined Abstraction
    public class Television : ElectronicGoods
    {
        //public Television(IState state) : base(state)
        //{
        //}
        /*Implementation specific:
         * We are delegating the implementation to the Implementor object*/
        public override void MoveToCurrentState()
        {
            Console.Write("\n Television is functioning at : ");
            state.MoveState();
        }
    }
}