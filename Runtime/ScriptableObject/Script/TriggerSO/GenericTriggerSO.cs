using UnityEngine;

namespace EventSystem.SO
{
    public abstract class GenericTriggerSO<T> : TriggerSO
    {
        public GenericEventSO<T> events;
        
        public T modifier;
        
        public GenericEventSO<T> EventSO
        {
            get => (GenericEventSO<T>) events;
            set { events = value.GetType() == typeof(T) ? value : null; }
        }

    }
}
