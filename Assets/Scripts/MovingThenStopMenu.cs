using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovingThenStopMenu : MonoBehaviour
{
    public void GoTo1()
    {
        SceneManager.LoadScene(4);
    }

    public void GoTo2()
    {
        SceneManager.LoadScene(5);
    }

    public void GoTo3()
    {
        SceneManager.LoadScene(6);
    }

    public void GoTo4()
    {
        SceneManager.LoadScene(7);
    }
}
