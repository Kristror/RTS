using Abstractions;
using UnityEngine;

namespace Core
{
    public sealed class Chomper : MonoBehaviour, ISelectable, IAttackable,IUnit
    {        
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Transform PivotPoint => _pivot;
        public Sprite Icon => _icon;
        public Outline OutlineModule => _outline;       

        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;
        [SerializeField] private Transform _pivot;

        private Outline _outline;

        private float _health = 100;

        public void Awake()
        {
            _outline = gameObject.GetComponent<Outline>();
            _outline.enabled = false;
        }
    }
}