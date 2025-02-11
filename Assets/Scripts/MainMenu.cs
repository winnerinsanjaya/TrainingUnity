using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadGame()
    {
        GoToScene("Gameplay", "test", 2, 3);
    }


    public void GoToScene(string name, string a, int b, int c)
    {
        Debug.Log(name + "-" + a + "-" + b + "-" + c);
        SceneManager.LoadScene(name);
    }


}
