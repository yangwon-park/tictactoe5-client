using UnityEngine;

namespace _Scripts
{
    public class GameUIController : MonoBehaviour
    {
        public void OnClickBackButton()
        {
            GameManager.Instance.ChangeToMainScene();
        }
        
        
    }
}