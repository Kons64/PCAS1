using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoTos : MonoBehaviour
{
    public void GoToMovingThenStop()
    {
        SceneManager.LoadScene(1);
    }

    public void GoToStaticThenMove()
    {
        SceneManager.LoadScene(2);
    }

    public void GoToStatic()
    {
        SceneManager.LoadScene(3);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
