using UnityEngine;
using EventSystem.SO;
using UnityEngine.UI;

namespace EventSystem.Script
{
    public class TriggerSOHolder : MonoBehaviour
    {
        [SerializeField]
        private TriggerSO triggerSO;

        void Start()
        {
            gameObject.GetComponent<Button>().onClick.AddListener(() => { triggerSO.Trigger();});
        }
    }
}
