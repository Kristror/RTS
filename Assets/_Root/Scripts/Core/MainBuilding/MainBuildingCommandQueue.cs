using Abstractions;
using Abstractions.Commands.CommandsInterfaces;
using Core;
using UnityEngine;
using Zenject;

namespace Core
{
	public class MainBuildingCommandQueue : MonoBehaviour, ICommandsQueue
	{
		[Inject] CommandExecutorBase<IProduceUnitCommand> _produceUnitCommandExecutor;
		[Inject] CommandExecutorBase<ISetRallyPointCommand> _setRallyPointCommandExecutor;

		public void Clear() { }

		public async void EnqueueCommand(object command)
		{
			await _produceUnitCommandExecutor.TryExecuteCommand(command);
			await _setRallyPointCommandExecutor.TryExecuteCommand(command);
		}
	}
}