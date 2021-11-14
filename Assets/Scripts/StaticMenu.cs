using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StaticMenu : MonoBehaviour
{
    public void GoTo8()
    {
        SceneManager.LoadScene(11);
    }

    public void GoTo9()
    {
        SceneManager.LoadScene(12);
    }

    public void GoTo10()
    {
        SceneManager.LoadScene(13);
    }
}
