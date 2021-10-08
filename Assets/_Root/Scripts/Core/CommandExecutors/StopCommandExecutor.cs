using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core.CommandExecutors
{
	class StopCommandExecutor : CommandExecutorBase<IStopCommand>
	{
		public override void ExecuteSpecificCommand(IStopCommand command)
		{
			Debug.Log($"Stop is active");
		}
	}
}