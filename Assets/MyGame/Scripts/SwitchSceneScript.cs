using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneScript : MonoBehaviour
{
     public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void EarlierScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
