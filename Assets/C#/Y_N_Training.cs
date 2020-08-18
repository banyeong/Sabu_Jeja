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

    [SerializeField] private Button Yes;
    [SerializeField] private Button No;
    [SerializeField] private GameObject Panel;

    [SerializeField] private Dialogue[] trname;
    [SerializeField] private Dialogue[] explain;

    private int count = 0;

    static public bool istraining = false;

    public void showPOPUP()
    {
        Big.gameObject.SetActive(true);
        Panel.gameObject.SetActive(true);
        TRname.text = trname[count].dialogue;
        Explain.text = explain[count].dialogue;
        istraining = true;
    }

    public void hidePOPUP()
    {
        Big.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
        Y_N_Training.istraining = false;
    }
}