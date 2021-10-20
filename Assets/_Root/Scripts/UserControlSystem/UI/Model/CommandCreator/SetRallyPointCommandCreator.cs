using Abstractions;
using UnityEngine;
using UserControlSystem.CommandsRealization;

namespace UserControlSystem
{
	public class SetRallyPointCommandCreator : CancellableCommandCreatorBase<ISetRallyPointCommand, Vector3>
	{
		protected override ISetRallyPointCommand createCommand(Vector3 argument) => new SetRallyPointCommand(argument);
	}
}