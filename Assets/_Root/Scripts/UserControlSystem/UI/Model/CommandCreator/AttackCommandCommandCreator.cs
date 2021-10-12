using System;
using System.Threading;
using Abstractions;
using Abstractions.Commands.CommandsInterfaces;
using UserControlSystem.CommandsRealization;
using Utils;
using Zenject;

namespace UserControlSystem
{
    public sealed class AttackCommandCommandCreator : CancellableCommandCreatorBase<IAttackCommand, IAttackable>
    {
        protected override IAttackCommand createCommand(IAttackable argument) => new AttackCommand(argument);
    }
}
