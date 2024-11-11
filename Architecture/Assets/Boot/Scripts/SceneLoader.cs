using UnityEngine;
using UnityEngine.SceneManagement;

namespace Boot.Scripts
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadScene(int sceneName)
        {
            print(sceneName);
            SceneManager.LoadScene(sceneName);
        }
    }
}
