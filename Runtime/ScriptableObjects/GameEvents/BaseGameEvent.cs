using System.Collections.Generic;
using UnityEngine;

namespace Watona.Events
{
    public abstract class BaseGameEvent<TParameter> : ScriptableObject
    {
        [SerializeField] private List<IEventListener<TParameter>> _listeners = new List<IEventListener<TParameter>>();
    
        public void Raise(TParameter t)
        {
            for (int i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].RaiseEvent(t);
            }
        }
        public void RegisterListener(IEventListener<TParameter> listener)
        {
            if (!_listeners.Contains(listener)) { _listeners.Add(listener); }
        }
        public void UnRegisterListener(IEventListener<TParameter> listener)
        {
            if (_listeners.Contains(listener)) { _listeners.Remove(listener); }
        }
    }
}