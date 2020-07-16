using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class Story1 : MonoBehaviour
{
    void Start()
    {

    }

    // Use this for initialization

    string m_strPath = "Assets/Resources/ex_1";

    public void WriteData(string strData)
    {
        FileStream f = new FileStream(m_strPath + "ex_1.txt", FileMode.Append, FileAccess.Write);

        StreamWriter writer = new StreamWriter(f, System.Text.Encoding.Unicode);

        writer.WriteLine(strData);

        writer.Close();
    }
    public void Parse()
    {
        TextAsset ex_1 = Resources.Load("ex_1", typeof(TextAsset)) as TextAsset;

        StringReader sr = new StringReader(ex_1.text);

        // 먼저 한줄을 읽는다. 

        string source = sr.ReadLine();

        string[] values;                // 쉼표로 구분된 데이터들을 저장할 배열 (values[0]이면 첫번째 데이터 )

        while (source != null)
        {
            values = source.Split(',');  // 쉼표로 구분한다. 저장시에 쉼표로 구분하여 저장하였다.
            if (values.Length == 0)
            {
                sr.Close();
                return;
            }
            source = sr.ReadLine();    // 한줄 읽는다.
        }
    }
    void Update()
    {
        
    }
}
