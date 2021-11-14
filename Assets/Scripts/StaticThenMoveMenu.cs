using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticThenMoveMenu : MonoBehaviour
{
    public void GoTo5()
    {
        SceneManager.LoadScene(8);
    }

    public void GoTo6()
    {
        SceneManager.LoadScene(9);
    }

    public void GoTo7()
    {
        SceneManager.LoadScene(10);
    }
}
