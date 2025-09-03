using TMPro;
using UnityEngine;

namespace _Scripts.Panel
{
    public class ConfirmPanelController : PanelController
    {
        [SerializeField] private TMP_Text messageText;
        
        public delegate void OnConfirmButonCLicked();
        private OnConfirmButonCLicked _onConfirmButonCLicked;
        
        public void ActivePanel(string message, OnConfirmButonCLicked onConfirmButonCLicked)
        
        {
            messageText.text = message;
            _onConfirmButonCLicked = onConfirmButonCLicked;
            base.ActivePanel();
        }
        
        public void OnClickConfirmButton()
        {
            base.DeActivePanel();
        }
        
        public void OnClickCloseButton()
        {
            base.DeActivePanel(() =>
            {
                _onConfirmButonCLicked?.Invoke();
            });
        }
    }
}