﻿using Abstractions.Commands.CommandsInterfaces;
using System.Threading.Tasks;
using UnityEngine;

namespace Core.CommandExecutors
{
	public class AttackCommandExecutor : CommandExecutorBase<IAttackCommand>
	{
		public override async Task ExecuteSpecificCommand(IAttackCommand command)
		{
			Debug.Log($"{name} attacking {command.Target}");
		}
	}
}