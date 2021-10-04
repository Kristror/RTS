using Abstractions;
using UnityEngine;

namespace Core
{
    public sealed class Chomper : MonoBehaviour, ISelectable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Sprite Icon => _icon;
        public Outline OutlineModule => _outline;       

        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;

        private Outline _outline;

        private float _health = 100;

        public void Awake()
        {
            _outline = gameObject.GetComponent<Outline>();
            _outline.enabled = false;
        }
        //public override void ExecuteSpecificCommand(IAttackCommand command)
        //{
        //    Debug.Log("Attack");
        //}
        //public override void ExecuteSpecificCommand(IMoveCommand command)
        //{
        //    Debug.Log("Move");
        //}
        //public override void ExecuteSpecificCommand(IPatrolCommand command)
        //{
        //    Debug.Log("Patrol");
        //}
        //public override void ExecuteSpecificCommand(IStopCommand command)
        //{
        //    Debug.Log("Stop");
        //}
    }
}