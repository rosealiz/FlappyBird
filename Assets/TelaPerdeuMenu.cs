using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TelaPerdeuMenu : MonoBehaviour
{
    public void replay()
    {
        SceneManager.LoadSceneAsync(1);
    }

    public void BackMenu()
    {
        SceneManager.LoadSceneAsync(0);
    }
}

