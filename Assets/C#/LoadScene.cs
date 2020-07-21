using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadTraining()
    {
        SceneManager.LoadScene(13);
    }
    public void LoadMain()
    {
        SceneManager.LoadScene(14);
    }
}
