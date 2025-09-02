using _Scripts.Game;
using UnityEngine;

namespace _Scripts.Main
{
    public class MainPanelController : MonoBehaviour
    {
        public void OnClickSinglePlayButton()
        {
            GameManager.Instance.ChangeToGameScene(Constant.GameType.SinglePlay);
        }

        public void OnClickDualPlayButton()
        {
            GameManager.Instance.ChangeToGameScene(Constant.GameType.DualPlay);
        }

        public void OnClickMultiPlayButton()
        {
            GameManager.Instance.ChangeToGameScene(Constant.GameType.MultiPlay);
        }

        public void OnClickSettingButton()
        {
            
        }
    }
}