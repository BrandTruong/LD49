using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    public void pressedPlay()
    {
        Debug.Log("Detected press");
        SceneManager.LoadScene(sceneName: "Iteration1");
    }
}
