using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadTraining()
    {
        SceneManager.LoadScene(14);
    }
    public void LoadMain()
    {
        SceneManager.LoadScene(15);
    }
}
