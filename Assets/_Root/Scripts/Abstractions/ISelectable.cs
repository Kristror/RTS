using UnityEngine;

namespace Abstractions
{
    public interface ISelectable : IHealth, IIconHolder
    {
        Transform PivotPoint { get; }
        Outline OutlineModule { get; }
    }
}