using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

public class Favor_lines : MonoBehaviour
{
    public Text favor_lines;
    private int RandomNum;

    private void compare()
    {
        TextAsset textAsset = null;
        AssetBundle favorline = AssetBundleManager.Load(Path.Combine(Application.streamingAssetsPath, "favorline"));

        if (GameManager.Instance.stat._cureentFavorability < 100) //호감도 0~99
        {
            textAsset = FileReader.ReadFile(favorline, "0~99");

            RandomNum = Random.Range(0, 4);
        }
        else if ((GameManager.Instance.stat._cureentFavorability > 99) && (GameManager.Instance.stat._cureentFavorability < 300)) //호감도 100~299
        {
            textAsset = FileReader.ReadFile(favorline, "100~299");

            RandomNum = Random.Range(0, 10);
        }
        else if ((GameManager.Instance.stat._cureentFavorability > 299) && (GameManager.Instance.stat._cureentFavorability < 500)) //호감도 300~499
        {
            textAsset = FileReader.ReadFile(favorline, "300~499");

            RandomNum = Random.Range(0, 9);
        }
        else if ((GameManager.Instance.stat._cureentFavorability > 499) && (GameManager.Instance.stat._cureentFavorability < 700)) //호감도 500~699
        {
            textAsset = FileReader.ReadFile(favorline, "500~699");

            RandomNum = Random.Range(0, 9);
        }
        else if ((GameManager.Instance.stat._cureentFavorability > 699) && (GameManager.Instance.stat._cureentFavorability < 900)) //호감도 700~899
        {
            textAsset = FileReader.ReadFile(favorline, "700~899");

            RandomNum = Random.Range(0, 12);
        }
        else if ((GameManager.Instance.stat._cureentFavorability > 899) && (GameManager.Instance.stat._cureentFavorability < 1001)) //호감도 900~1000
        {
            textAsset = FileReader.ReadFile(favorline, "900~1000");

            RandomNum = Random.Range(0, 10);
        }

        string textData = Encoding.UTF8.GetString(textAsset.bytes, 0, textAsset.bytes.Length);
        string[] textDatas = textData.Split('\n');

        favor_lines.text = textDatas[RandomNum];
    }

    private void FavorClick()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Favor"))
            {
                compare();
            }
        }
    }

    private void Start()
    {
        compare();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            FavorClick();
        }
    }
}
