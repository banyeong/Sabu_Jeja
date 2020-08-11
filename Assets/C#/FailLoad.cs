using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FailLoad : MonoBehaviour
{
    [SerializeField] private GameObject FailPopUp;
    [SerializeField] private Text FailText;

    public void ShowFailLoad()
    {
        FailPopUp.gameObject.SetActive(true);
        FailText.gameObject.SetActive(true);
    }

    public void HideFailLoad()
    {
        FailPopUp.gameObject.SetActive(false);
        FailText.gameObject.SetActive(false);
    }
}
