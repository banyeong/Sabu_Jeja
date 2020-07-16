using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class training : MonoBehaviour
{
    public int weeks = 1; // 1주 2주 3주 4주...

    #region training list
    public string MoClear = "도력 정제";
    public string MoDevelop = "도력 개발";
    public string MoPractice = "도술 연마";
    public string MoCycle = "운기조식";
    public string PhyPractice = "체술 단련";
    public string SwordsMS = "검술 단련";
    public string SpearsMS = "창술 단련";
    public string BongMS = "봉술 단련";
    public string CalcStudy = "상술 공부";
    public string BookRead = "도서 읽기";
    public string Instrument = "악기 연주";
    public string PoemWrite = "시 쓰기";
    public string drawing = "그림 그리기"; 
    #endregion

    StudentStat stat = new StudentStat();

    #region trainig
    public void MOCLEAR() // 도력정제
    {
        weeks += 2;
        
        stat.currentMslStr -= 7;
        stat.currentMoralStr += 14;
        stat.cureentFavorability += 7;

        
        Debug.Log(weeks + "주째");
        Debug.Log("근력 " + stat.currentMoralStr + ", 도력 " + stat.currentMoralStr + ", 호감도 " + stat.cureentFavorability);
        
    }

    public void MODEVELOP() // 도술개발
    {
        weeks += 3;
        
        stat.currentMslStr -= 14;
        stat.currentMoralStr += 42;
        stat.currentWealth -= 7;

        Debug.Log(weeks + "주째");
        Debug.Log("근력 " + stat.currentMoralStr + ", 도력 " + stat.currentMoralStr + ", 재력 " + stat.currentWealth);
    }

    public void MOPRACTICE() // 도술연마
    {
        weeks += 4;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 35;
        stat.currentWealth -= 14;
    }

    public void MOCYCLE() // 운기조식
    {
        weeks += 1;

        stat.currentMoralStr += 14;
        stat.cureentFavorability -= 7;
    }

    public void PHYPRACTICE() // 체술단련
    {
        weeks += 2;

        stat.currentMslStr += 14;
        stat.currentMoralStr -= 7;
        stat.cureentFavorability += 7;
    }

    public void SWORDSMS() // 검술단련
    {
        weeks += 3;

        stat.currentMslStr += 42;
        stat.currentMoralStr -= 14;
        stat.currentWealth -= 7;
    }

    public void SPEARSMS() // 창술단련
    {
        weeks += 4;

        stat.currentMslStr += 35;
        stat.currentMoralStr += 7;
        stat.currentWealth -= 14;
    }


    public void BONGMS() // 봉술단련
    {
        weeks += 1;

        stat.currentMslStr += 14;
        stat.cureentFavorability -= 7;
    }

    public void CALCSTUDY() //상술공부
    {
        weeks += 4;

        stat.currentMoralStr -= 7;
        stat.currentWealth += 35;
    }

    public void BOOKREAD() //도서읽기
    {
        weeks += 4;

        stat.currentMslStr -= 7;
        stat.currentWealth += 35;
    }

    public void INSTRUMENT() //악기연주
    {
        weeks += 2;

        stat.currentMslStr -= 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability += 14;
    }

    public void POEMWRITE() //시쓰기
    {
        weeks += 1;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability -= 14;
        stat.currentWealth += 7;
    }

    public void DRAWING() //그림그리기
    {
        weeks += 3;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability += 21;
        stat.currentWealth -= 14;
    } 
    #endregion
}