using Abstractions;
using UnityEngine;

namespace UserControlSystem
{
    public class OutlinePresenter : MonoBehaviour
    {
        [SerializeField] private SelectableValue _selectedValue;

        private ISelectable _currentValue;

        private void Start()
        {
            _selectedValue.OnNewValue += ONSelected;
            ONSelected(_selectedValue.CurrentValue);
        }
        private void ONSelected(ISelectable selected)
        {
            if (_currentValue != null) 
                if(_currentValue.OutlineModule != null) _currentValue.OutlineModule.enabled = false;
            if (selected != null) selected.OutlineModule.enabled = true;
            _currentValue = selected;
        }
    }
}