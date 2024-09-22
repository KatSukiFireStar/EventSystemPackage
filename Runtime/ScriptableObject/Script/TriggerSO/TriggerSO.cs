using UnityEngine;

namespace EventSystem.SO
{
    public abstract class TriggerSO : ScriptableObject
    {
        private EventSO eventSO;
        
        public abstract void Trigger();
    }
}
