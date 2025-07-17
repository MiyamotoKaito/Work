using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour
{
    public void Load(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
