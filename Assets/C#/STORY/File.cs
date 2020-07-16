using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class File : MonoBehaviour
{
    public Text fieldText; //출력할 텍스트
    public TextAsset My_Text;

    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if (My_Text != null)
            {
                string currentText = My_Text.text.Substring(0 - My_Text.text.Length - 1);
                fieldText.text = currentText;
                Debug.Log(currentText);
            }
        }
    }

    public static string ReadAllText(string assetPath)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }
}