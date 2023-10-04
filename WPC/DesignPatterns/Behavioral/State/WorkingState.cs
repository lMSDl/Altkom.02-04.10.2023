using System.Threading;
using System.Threading.Tasks;

namespace WPC.DesignPatterns.Behavioral.State
{
    internal class WorkingState : State
    {
        private readonly CancellationTokenSource _cancellationTokenSource;

        public WorkingState(CoffeeMachine coffeeMachine, int time) : base(coffeeMachine)
        {
            _cancellationTokenSource = new CancellationTokenSource();

            Task.Delay(time, _cancellationTokenSource.Token).ContinueWith(x =>
           {
               CoffeeMachine.State = new IdleState(CoffeeMachine);
               _cancellationTokenSource.Dispose();
           });
        }

        public override void Large()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }

        public override void Small()
        {
            System.Console.WriteLine("Anulacja");
            _cancellationTokenSource.Cancel();
        }
    }
}