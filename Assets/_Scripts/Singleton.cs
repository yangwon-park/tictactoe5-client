using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace _Scripts
{
    public abstract class Singleton<T> : MonoBehaviour where T : Component
    {
        private static T _instance;

        public static T Instance
        {
            get
            {
                if (!_instance)
                {
                    _instance = FindFirstObjectByType<T>();

                    if (!_instance)
                    {
                        var obj = new GameObject
                        {
                            name = typeof(T).Name
                        };

                        _instance = obj.AddComponent<T>();
                    }
                }
                
                return _instance;
            }
        }

        private void Awake()
        {
            if (!_instance)
            {
                _instance = this as T;
                DontDestroyOnLoad(gameObject);
                
                // 씬 전환시에 호출되는 Action 할당
                SceneManager.sceneLoaded += OnSceneLoad;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        protected abstract void OnSceneLoad(Scene scene, LoadSceneMode mode);
    }
}