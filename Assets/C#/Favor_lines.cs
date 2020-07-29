using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Favor_lines : MonoBehaviour
{
    public Text favor_lines;

    public string A = "어서오세요, 스승님";
    public string B = "식사시간 입니다.";

    public void one()
    {
        //favor_lines.text = ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            one();
        }
    }
}
