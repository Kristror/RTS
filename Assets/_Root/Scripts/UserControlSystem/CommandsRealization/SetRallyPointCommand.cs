using UnityEngine;
using Abstractions;

namespace UserControlSystem.CommandsRealization
{
	public class SetRallyPointCommand : ISetRallyPointCommand
	{
		public Vector3 RallyPoint { get; }

		public SetRallyPointCommand(Vector3 rallyPoint)
		{
			RallyPoint = rallyPoint;
		}
	}
}