using Abstractions;
using Zenject;

namespace Core
{
    public class ChomperInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            Container.Bind<IHealth>().FromComponentInChildren();
            Container.Bind<float>().WithId("AttackDistance").FromInstance(4f);
            Container.Bind<int>().WithId("AttackPeriod").FromInstance(1400);
        }
    }
}
