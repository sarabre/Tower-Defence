using UnityEngine;
using System;

[CreateAssetMenu(fileName = "void", menuName = "Event/Void")]
public class VoidEvent : ScriptableObject
{
    public Action OnEventRaise;

    public void EventRaise()
    {
        OnEventRaise?.Invoke();
    }
}
