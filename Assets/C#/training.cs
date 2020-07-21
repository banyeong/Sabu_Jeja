using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class training : MonoBehaviour
{
    StudentStat stat = new StudentStat();

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

    #region trainig
    public void MOCLEAR() // 도력정제
    {
        stat.weeks += 2;
        
        stat.currentMslStr -= 7;
        stat.currentMoralStr += 14;
        stat.cureentFavorability += 7;

        
        Debug.Log(stat.weeks + "주째");
        Debug.Log("근력 " + stat.currentMoralStr + ", 도력 " + stat.currentMoralStr + ", 호감도 " + stat.cureentFavorability);
        
    }

    public void MODEVELOP() // 도술개발
    {
        stat.weeks += 3;
        
        stat.currentMslStr -= 14;
        stat.currentMoralStr += 42;
        stat.currentWealth -= 7;

        Debug.Log(stat.weeks + "주째");
        Debug.Log("근력 " + stat.currentMoralStr + ", 도력 " + stat.currentMoralStr + ", 재력 " + stat.currentWealth);
    }

    public void MOPRACTICE() // 도술연마
    {
        stat.weeks += 4;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 35;
        stat.currentWealth -= 14;
    }

    public void MOCYCLE() // 운기조식
    {
        stat.weeks += 1;

        stat.currentMoralStr += 14;
        stat.cureentFavorability -= 7;
    }

    public void PHYPRACTICE() // 체술단련
    {
        stat.weeks += 2;

        stat.currentMslStr += 14;
        stat.currentMoralStr -= 7;
        stat.cureentFavorability += 7;
    }

    public void SWORDSMS() // 검술단련
    {
        stat.weeks += 3;

        stat.currentMslStr += 42;
        stat.currentMoralStr -= 14;
        stat.currentWealth -= 7;
    }

    public void SPEARSMS() // 창술단련
    {
        stat.weeks += 4;

        stat.currentMslStr += 35;
        stat.currentMoralStr += 7;
        stat.currentWealth -= 14;
    }


    public void BONGMS() // 봉술단련
    {
        stat.weeks += 1;

        stat.currentMslStr += 14;
        stat.cureentFavorability -= 7;
    }

    public void CALCSTUDY() //상술공부
    {
        stat.weeks += 4;

        stat.currentMoralStr -= 7;
        stat.currentWealth += 35;
    }

    public void BOOKREAD() //도서읽기
    {
        stat.weeks += 4;

        stat.currentMslStr -= 7;
        stat.currentWealth += 35;
    }

    public void INSTRUMENT() //악기연주
    {
        stat.weeks += 2;

        stat.currentMslStr -= 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability += 14;
    }

    public void POEMWRITE() //시쓰기
    {
        stat.weeks += 1;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability -= 14;
        stat.currentWealth += 7;
    }

    public void DRAWING() //그림그리기
    {
        stat.weeks += 3;

        stat.currentMslStr += 7;
        stat.currentMoralStr += 7;
        stat.cureentFavorability += 21;
        stat.currentWealth -= 14;
    }
    #endregion

    public void WEEKS()
    {
            if (stat.weeks >= 12)
            {
                STORY();
            }
    }
    public void STORY()
    {
        if ((stat.currentMslStr < 300) && (stat.currentMoralStr < 300) && (stat.currentWealth < 500) && (stat.cureentFavorability < 300)) //스토리1
        {
            SceneManager.LoadScene(2);
        }
        if (stat.currentMslStr >= 300) //스토리2
        {
            SceneManager.LoadScene(3);
        }
        if (stat.currentMoralStr >= 300) //스토리3
        {
            SceneManager.LoadScene(4);
        }
        if (stat.currentWealth >= 500) //스토리4
        {
            SceneManager.LoadScene(5);
        }
        if (stat.cureentFavorability >= 300) //스토리5
        {
            SceneManager.LoadScene(6);
        }
        if ((stat.currentMslStr >= 500) && (stat.currentMoralStr >= 500)) //스토리6
        {
            SceneManager.LoadScene(7);
        }
        if ((stat.currentMslStr >= 500) && (stat.currentWealth >= 500)) //스토리7
        {
            SceneManager.LoadScene(8);
        }
        if ((stat.currentMslStr >= 500) && (stat.currentMoralStr >= 300) && (stat.cureentFavorability >= 500)) //스토리8
        {
            SceneManager.LoadScene(9);
        }
        if ((stat.currentMoralStr >= 500) && (stat.currentWealth >= 500) && (stat.cureentFavorability >= 500)) //스토리9
        {
            SceneManager.LoadScene(10);
        }
        if ((stat.currentMslStr >= 800) && (stat.currentMoralStr >= 500) && (stat.cureentFavorability >= 500)) //스토리10
        {
            SceneManager.LoadScene(11);
        }
        if ((stat.currentMslStr >= 500) && (stat.currentMoralStr >= 800) && (stat.cureentFavorability >= 500)) //스토리11
        {
            SceneManager.LoadScene(12);
        }
        if ((stat.currentMslStr >= 800) && (stat.currentMoralStr >= 800) && (stat.cureentFavorability >= 500)) //스토리12
        {
            SceneManager.LoadScene(13);
        }
    }
}

public class Progress_Story : MonoBehaviour
{
    StudentStat stat = new StudentStat();


}