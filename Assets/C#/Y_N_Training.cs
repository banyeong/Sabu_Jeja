using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[System.Serializable]

public class Y_N_Training : MonoBehaviour
{
    [SerializeField] private GameObject Big;
    [SerializeField] private SpriteRenderer POPUP;
    [SerializeField] private Text TRname;
    [SerializeField] private Text Explain;

    [SerializeField] private UnityEngine.UI.Button Yes;
    [SerializeField] private UnityEngine.UI.Button No;

    [SerializeField] private Dialogue[] trname;
    [SerializeField] private Dialogue[] explain;

    private int count = 0;

    public void showPOPUP()
    {
        Big.gameObject.SetActive(true);
        TRname.text = trname[count].dialogue;
        Explain.text = explain[count].dialogue;
    }

    public void hidePOPUP()
    {
        Big.gameObject.SetActive(false);
    }
}