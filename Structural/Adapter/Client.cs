using DesignPatterns.Structural.Adapter.Interfaces;

namespace DesignPatterns.Structural.Adapter
{
    internal class Client
    {
        private readonly INewTarget _newTarget;

        public Client(INewTarget newTarget)
        {
            this._newTarget = newTarget;
        }

        public void MakeRequest()
        {
            _newTarget.NewMethod();
        }
    }
}