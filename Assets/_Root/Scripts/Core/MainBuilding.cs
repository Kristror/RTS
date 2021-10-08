using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : CommandExecutorBase<IProduceUnitCommand>, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth; 
        public Transform PivotPoint => _pivot;
        public Sprite Icon => _icon; 
        public Outline OutlineModule => _outline;

        [SerializeField] private Transform _unitsParent;
        [SerializeField] private Transform _pivot;
        [SerializeField] private float _maxHealth = 1000;
        [SerializeField] private Sprite _icon;

        private Outline _outline;

        private float _health = 1000;

        public void Awake()
        {
            _outline = gameObject.GetComponent<Outline>();
            _outline.enabled = false;
        }

        public override void ExecuteSpecificCommand(IProduceUnitCommand command)
        {
            Instantiate(command.UnitPrefab, new Vector3(Random.Range(-10, 10), 0, Random.Range(-10, 10)), Quaternion.identity, _unitsParent);
        }

    }
}