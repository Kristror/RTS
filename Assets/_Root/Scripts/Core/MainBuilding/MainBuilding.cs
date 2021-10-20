using Abstractions;
using Abstractions.Commands;
using Abstractions.Commands.CommandsInterfaces;
using UnityEngine;

namespace Core
{
    public sealed class MainBuilding : MonoBehaviour, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth; 
        public Transform PivotPoint => _pivot;
        public Sprite Icon => _icon; 
        public Outline OutlineModule => _outline;

        public Vector3 RallyPoint { get; set; }
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
    }
}