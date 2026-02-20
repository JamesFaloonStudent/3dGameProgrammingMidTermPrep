using UnityEngine;
using UnityEngine.SceneManagement;


public class SceneController : MonoBehaviour
{
    public void LoadScene(string sceneName) 
    {
        SceneManager.LoadScene(sceneName);
    }


    public void QuitGame()
    {
        SceneManager.QuitGame();
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
