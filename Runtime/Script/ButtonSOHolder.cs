using UnityEngine;
using EventSystem.SO;
using UnityEngine.UI;

namespace EventSystem.Script
{
    public class ButtonSOHolder : MonoBehaviour
    {
        [SerializeField]
        private ButtonSO buttonSO;

        void Start()
        {
            gameObject.GetComponent<Button>().onClick.AddListener(() => { buttonSO.Trigger();});
        }
    }
}
