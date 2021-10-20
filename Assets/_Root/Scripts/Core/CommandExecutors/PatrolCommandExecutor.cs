using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.CommandExecutors
{
	class PatrolCommandExecutor : CommandExecutorBase<IPatrolCommand>
	{
		public override async Task ExecuteSpecificCommand(IPatrolCommand command)
		{
			Debug.Log($"{name} patroling from {command.From} to {command.To}");
		}
	}
}