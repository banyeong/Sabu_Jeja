using System.Collections;
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

    public int one_Month = 12; //기본 한 달
    public int one_Year = 12; //기본 일 년
    public int Year;
    public int Month;

    //날짜 치환 함수 필요할 것 같음
    public void DateChange()
    {
        if (GameManager.Instance.stat.currentweeks >= one_Month) //12주 되면 한 달 취급
        {
            Month++;
            one_Month++;
        }

        if (Month >= one_Year) //12달 되면 일 년 취급
        {
            Year++;
            one_Year++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        DateChange();
        DateText.text = Year + "년 " + Month + "개월 " + GameManager.Instance.stat.currentweeks + "주";

        MslStr.text = "근력 : " + GameManager.Instance.stat.CurrentMslStr;
        MoralStr.text = "도력 : " + GameManager.Instance.stat.CurrentMoralStr;
        Wealth.text = "재력 : " + GameManager.Instance.stat.CurrentWealth;
        Favorability.text = "호감도 : " + GameManager.Instance.stat.CurrentFavorability;
    }
}
