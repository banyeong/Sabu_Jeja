using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;
using System.IO;

public class Prologue : MonoBehaviour
{
    void Start()
    {

    }
    // Use this for initialization

    string m_strPath = "Assets/";

    public void WriteData(string strData)
    {
        FileStream f = new FileStream(m_strPath + "Prologue.txt", FileMode.Append, FileAccess.Write);

        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);

        writer.WriteLine(strData);

        writer.Close();
    }

    public void Parse()
    {
        TextAsset data = Resources.Load("Prologue", typeof(TextAsset)) as TextAsset;

        StringReader sr = new StringReader(data.text);

        // 먼저 한줄을 읽는다./

        string source = sr.ReadLine();

        string[] values;                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )


        while (source != null)
        {
            values = source.Split('\n');
            if (values.Length == 0)
            {
                sr.Close();
                return;
            }
            source = sr.ReadLine();    // 한줄 읽는다.
        }
    }
}