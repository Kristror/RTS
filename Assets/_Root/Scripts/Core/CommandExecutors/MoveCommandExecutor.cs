using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core.CommandExecutors
{
	class MoveCommandExecutor : CommandExecutorBase<IMoveCommand>
	{
		public override void ExecuteSpecificCommand(IMoveCommand command)
		{
			Debug.Log($"Move is active");
		}
	}
}
