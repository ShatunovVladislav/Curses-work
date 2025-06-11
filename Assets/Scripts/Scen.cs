using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OpenGame()
    {
        SceneManager.LoadScene("Game");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            Debug.Log("Key Enter");
            OpenGame();
        }
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("Key Esc");
            OpenMenu();
        }

        //Любая кнопка
        if (Input.anyKeyDown)
        {
            Debug.Log("AnyKey");
        }
    }
}