﻿using Abstractions;
using System;
using UnityEngine;
using UserControlSystem;
using Utils;
using Zenject;

[CreateAssetMenu(fileName = nameof(AssetsInstaller), menuName = "Installers/" + nameof(AssetsInstaller))]
public class AssetsInstaller : ScriptableObjectInstaller<AssetsInstaller>
{
	[SerializeField] private AssetsContext _legacyContext;
	[SerializeField] private Vector3Value _groundClicksRMB;
	[SerializeField] private AttackableValue _attackableClicksRMB;
	[SerializeField] private SelectableValue _selectables;
	[SerializeField] private Sprite _chomperSprite;

	public override void InstallBindings()
	{
		Container.BindInstances(_legacyContext, _groundClicksRMB, _attackableClicksRMB, _selectables);
		Container.Bind<IAwaitable<IAttackable>>()
			.FromInstance(_attackableClicksRMB);
		Container.Bind<IAwaitable<Vector3>>()
			 .FromInstance(_groundClicksRMB);
		Container.Bind<IObservable<ISelectable>>().FromInstance(_selectables);

		Container.Bind<Sprite>().WithId("Chomper").FromInstance(_chomperSprite);

	}
}