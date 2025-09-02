using _Scripts.Common;
using _Scripts.Panel;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts.Game
{
    public class GameManager : Singleton<GameManager>
    {
        [SerializeField] private GameObject confirmPanelPrefab;
        private Constant.GameType _gameType;
        private Canvas _canvas;
        
        public void ChangeToGameScene(Constant.GameType gameType)
        {
            _gameType = gameType;
            SceneManager.LoadScene("Game");
        }
        
        public void ChangeToMainScene()
        {
            SceneManager.LoadScene("Main");
        }
        
        public void OpenConfirmPanel(string message)
        {
            if (_canvas == null) return;
            
            var confirmPanel = Instantiate(confirmPanelPrefab, _canvas.transform);
            
            confirmPanel.GetComponent<ConfirmPanelController>().ActivePanel(message);
            
            
        }

        protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
        {
            _canvas = FindFirstObjectByType<Canvas>();
        }
    }
}
