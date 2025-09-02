using System;
using UnityEngine.SceneManagement;

namespace _Scripts
{
    public class GameManager : Singleton<GameManager>
    {
        private Constant.GameType _gameType;
        
        public void ChangeToGameScene(Constant.GameType gameType)
        {
            _gameType = gameType;
            
            SceneManager.LoadScene("Game");
        }
        
        public void ChangeToMainScene()
        {
            SceneManager.LoadScene("Main");
        }

        protected override void OnSceneLoad(Scene scene, LoadSceneMode mode)
        {
            // throw new NotImplementedException();
        }
    }
}
