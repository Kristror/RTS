using Abstractions;
using Core.CommandExecutors;
using UnityEngine;
using UserControlSystem.CommandsRealization;

namespace Core
{
    public sealed class Chomper : MonoBehaviour, ISelectable, IAttackable
    {
        public float Health => _health;
        public float MaxHealth => _maxHealth;
        public Transform PivotPoint => _pivot;
        public Sprite Icon => _icon;
        public Outline OutlineModule => _outline;
        [SerializeField] private float _maxHealth = 100;
        [SerializeField] private Sprite _icon;
        [SerializeField] private Transform _pivot;
        [SerializeField] private Animator _animator;
        [SerializeField] private StopCommandExecutor _stopCommand;

        private Outline _outline;

        private float _health = 100;

        public void Awake()
        {
            _outline = gameObject.GetComponent<Outline>();
            _outline.enabled = false;
        }
        public void RecieveDamage(int amount)
        {
            if (_health <= 0)
            {
                return;
            }
            _health -= amount;
            if (_health <= 0)
            {
                _animator.SetTrigger("Death");
                Invoke(nameof(destroy), 1f);
            }
        }
        private async void destroy()
        {
            await _stopCommand.ExecuteSpecificCommand(new StopCommand());
            Destroy(gameObject);
        }

    }
}