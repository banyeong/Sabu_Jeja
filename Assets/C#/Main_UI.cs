﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main_UI : MonoBehaviour
{
    public Text DateText; // 메인화면 날짜 텍스트
    public Text MslStr; //근력 텍스트
    public Text MoralStr; //도력 텍스트
    public Text Wealth; //재력 텍스트
    public Text Favorability; //호감도 텍스트
    public Text Gold; //골드 텍스트

    string dateText;

    public int one_weeks = 0;
    public int one_Month = 0;
    public int one_Year = 0;

    public void DateChange()
    {
        one_weeks = GameManager.Instance.stat.currentweeks % 5;
        one_Month = GameManager.Instance.stat.currentweeks / 5;
        one_Month = one_Month % 13;
        one_Year = GameManager.Instance.stat.currentweeks / 52;

        dateText = "";

        if (one_Year > 0)
        {
            dateText += one_Year.ToString() + "년";
        }
        if (one_Month > 0)
        {
            dateText += one_Month.ToString() + "달";
        }
        if (one_weeks > 0)
        {
            dateText += one_weeks.ToString() + "주";
        }

        DateText.text = dateText;

        /*if (one_weeks % 4 == 0)
        {
            one_weeks = 1;
        }

        if (one_Month % 13 == 0)
        {
            one_Month = 1;
        }*/
    }

    public void Money()
    {
        if (GameManager.Instance.stat.currentweeks >= GameManager.Instance.stat.money_weeks)
        {
            GameManager.Instance.stat.money_weeks += 4;
            
            if ((GameManager.Instance.stat.CurrentWealth <= 100) && (GameManager.Instance.stat.CurrentFavorability <= 100))
            {
                GameManager.Instance.stat.current_money += 200;
            }
            else
            {
                GameManager.Instance.stat.current_money += 200;
                GameManager.Instance.stat.current_money += (GameManager.Instance.stat.CurrentWealth - 100) * 10;
                GameManager.Instance.stat.current_money += (GameManager.Instance.stat.CurrentFavorability - 100) * 5;
            }
        }
    }

    private void Start()
    {
        dateText = "";
    }

    void Update()
    {
        Money();
        DateChange();

        //DateText.text = (int)one_Year + "년 " + (int)one_Month + "개월 " + (int)one_weeks + "주";

        MslStr.text = "근력 : " + GameManager.Instance.stat.CurrentMslStr;
        MoralStr.text = "도력 : " + GameManager.Instance.stat.CurrentMoralStr;
        Wealth.text = "재력 : " + GameManager.Instance.stat.CurrentWealth;
        Favorability.text = "호감도 : " + GameManager.Instance.stat.CurrentFavorability;

        Gold.text = GameManager.Instance.stat.current_money + " G";
    }
}