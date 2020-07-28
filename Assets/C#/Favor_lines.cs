using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Favor_lines : MonoBehaviour
{
    public Text faver_lines;

    public string A = "어서오세요, 스승님";
    public string B = "식사시간 입니다.";

    public void one()
    {
        if (GameManager.Instance.stat.CurrentFavorability < 100)
        {
            //faver_lines.text = A || B;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
