﻿using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class file_INOUT : MonoBehaviour
{
   
    // Use this for initialization


    string m_strPath = "Assets/Resources/";

    public void WriteData(string strData)
    {
        FileStream f = new FileStream(m_strPath + "ex_1.txt", FileMode.Append, FileAccess.Write);

        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);

        writer.WriteLine(strData);

        writer.Close();
    }

    public void Parse()
    {
        TextAsset data = Resources.Load("ex_1", typeof(TextAsset)) as TextAsset;

        StringReader sr = new StringReader(data.text);

        // 먼저 한줄을 읽는다. 

        string source = sr.ReadLine();

        string[] values;                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )

        if(Input.GetMouseButtonDown(0))
        {
            while (source != null)
            {
                values = source.Split(':');  // 쉼표로 구분한다. 저장시에 쉼표로 구분하여 저장하였다.

                if (values.Length == 0)
                {
                    sr.Close();

                    return;
                }
                source = sr.ReadLine();
                // 한줄 읽는다.
            }


        }

        void Start()
        {

        }
        // Update is called once per frame
        void Update()
        {

        }
    }
}