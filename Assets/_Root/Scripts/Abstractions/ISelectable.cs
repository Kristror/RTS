using UnityEngine;

namespace Abstractions
{
    public interface ISelectable : IHealth
    {
        Transform PivotPoint { get; }
        Sprite Icon { get; }
        Outline OutlineModule { get; }
    }
}