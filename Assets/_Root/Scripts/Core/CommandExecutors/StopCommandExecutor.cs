using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using System.Threading;
using UnityEngine;

namespace Core.CommandExecutors
{
	class StopCommandExecutor : CommandExecutorBase<IStopCommand>
	{
		public CancellationTokenSource CancellationTokenSource { get; set; }

		public override void ExecuteSpecificCommand(IStopCommand command)
		{
			CancellationTokenSource?.Cancel();
		}
	}
}