using Abstractions;
using UnityEngine;

namespace Core
{
    class MainUnit : MonoBehaviour, IUnit, IDamageDealer
    {
        public int Damage => _damage;
        [SerializeField] private int _damage = 25;
    }
}
