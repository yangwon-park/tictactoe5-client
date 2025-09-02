using TMPro;
using UnityEngine;

namespace _Scripts.Panel
{
    public class ConfirmPanelController : PanelController
    {
        [SerializeField] private TMP_Text messageText;
        
        public void ActivePanel(string message)
        {
            messageText.text = message;
            base.ActivePanel();
        }
        
        public void OnClickConfirmButton()
        {
            base.DeActivePanel();
        }
        
        public void OnClickCloseButton()
        {
            base.DeActivePanel();
        }
    }
}