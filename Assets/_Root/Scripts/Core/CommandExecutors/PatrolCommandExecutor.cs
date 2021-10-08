using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core.CommandExecutors
{
	class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
	{
		public override void ExecuteSpecificCommand(IPatrolCommand command)
		{
			Debug.Log($"{name} patroling from {command.From} to {command.To}");
		}
	}
}