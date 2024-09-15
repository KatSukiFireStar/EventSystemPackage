using UnityEngine;

namespace EventSystem.SO
{
    public abstract class ButtonSO : ScriptableObject
    {
        private EventSO eventSO;
        
        public abstract void Trigger();
    }
}
