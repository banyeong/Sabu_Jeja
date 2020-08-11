using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

public class Favor_lines : MonoBehaviour
{
    public GameObject favor_PopUp;
    public Text favor_lines;
    private int RandomNum;

    private void compare()
    {
        if ((GameManager.Instance.stat._cureentFavorability > -1) && (GameManager.Instance.stat._cureentFavorability < 100)) //호감도 0~99
        {
            var Favor1_list = FileReader.Favor1(Application.dataPath + "/Text/0~99.txt");

            RandomNum = Random.Range(0, 4);

            favor_lines.text = Favor1_list[RandomNum];
        }
        if ((GameManager.Instance.stat._cureentFavorability > 99) && (GameManager.Instance.stat._cureentFavorability < 300)) //호감도 100~299
        {
            var Favor2_list = FileReader.Favor2(Application.dataPath + "/Text/100~299.txt");

            RandomNum = Random.Range(0, 10);

            favor_lines.text = Favor2_list[RandomNum];
        }
        if ((GameManager.Instance.stat._cureentFavorability > 299) && (GameManager.Instance.stat._cureentFavorability < 500)) //호감도 300~499
        {
            var Favor3_list = FileReader.Favor3(Application.dataPath + "/Text/300~499.txt");

            RandomNum = Random.Range(0, 9);

            favor_lines.text = Favor3_list[RandomNum];
        }
        if ((GameManager.Instance.stat._cureentFavorability > 499) && (GameManager.Instance.stat._cureentFavorability < 700)) //호감도 500~699
        {
            var Favor4_list = FileReader.Favor4(Application.dataPath + "/Text/500~699.txt");

            RandomNum = Random.Range(0, 9);

            favor_lines.text = Favor4_list[RandomNum];
        }
        if ((GameManager.Instance.stat._cureentFavorability > 699) && (GameManager.Instance.stat._cureentFavorability < 900)) //호감도 700~899
        {
            var Favor5_list = FileReader.Favor5(Application.dataPath + "/Text/700~899.txt");

            RandomNum = Random.Range(0, 12);

            favor_lines.text = Favor5_list[RandomNum];
        }
        if ((GameManager.Instance.stat._cureentFavorability > 899) && (GameManager.Instance.stat._cureentFavorability < 1001)) //호감도 900~1000
        {
            var Favor6_list = FileReader.Favor6(Application.dataPath + "/Text/900~1000.txt");

            RandomNum = Random.Range(0, 10);

            favor_lines.text = Favor6_list[RandomNum];
        }
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
