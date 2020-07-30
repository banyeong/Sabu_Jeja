using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Story
{
    public int index; //로드할때 쓸 인덱스
    public StudentStat goalStat; //목표 점수 
    public int priority; //우선 순위(스토리 점수)
}

public class training : MonoBehaviour
{
    StudentStat stat = new StudentStat();

    /*#region training list
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
    #endregion*/

    //모든 스토리 ( index, stat{ 0, 0, 0, 0 }, priority )
    private Story[] storys =
                            {
                            new Story() { index = 1, goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = -1, _currentWealth = -1, _cureentFavorability = -1}, priority = 0 }, //1
                            new Story() { index = 2, goalStat = new StudentStat(){_currentMslStr = 300, _currentMoralStr = -1, _currentWealth = -1, _cureentFavorability = -1}, priority = 20 }, //2
                            new Story() { index = 4, goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = 300, _currentWealth = -1, _cureentFavorability = -1}, priority = 30 }, //3
                            new Story() { index = 5, goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = -1, _currentWealth = 500, _cureentFavorability = -1}, priority = 40 }, //4
                            new Story() { index = 6, goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = -1, _currentWealth = -1, _cureentFavorability = 300}, priority = 60 }, //5
                            new Story() { index = 7, goalStat = new StudentStat(){_currentMslStr = 500, _currentMoralStr = 500, _currentWealth = -1, _cureentFavorability = -1}, priority = 70 }, //6
                            new Story() { index = 8, goalStat = new StudentStat(){_currentMslStr = 500, _currentMoralStr = -1, _currentWealth = 500, _cureentFavorability = -1}, priority = 80 }, //7
                            new Story() { index = 9, goalStat = new StudentStat(){_currentMslStr = 500, _currentMoralStr = 300, _currentWealth = -1, _cureentFavorability = 500}, priority = 90 }, //8
                            new Story() { index = 10, goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = 500, _currentWealth = 500, _cureentFavorability = 500}, priority = 110 }, //9
                            new Story() { index = 11, goalStat = new StudentStat(){_currentMslStr = 800, _currentMoralStr = 500, _currentWealth = -1, _cureentFavorability = 500}, priority = 150 }, //10
                            new Story() { index = 12, goalStat = new StudentStat(){_currentMslStr = 500, _currentMoralStr = 800, _currentWealth = -1, _cureentFavorability = 500}, priority = 170 }, //11
                            new Story() { index = 13, goalStat = new StudentStat(){_currentMslStr = 800, _currentMoralStr = 800, _currentWealth = -1, _cureentFavorability = 500}, priority = 200 }, //12
                            };

    #region training                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             #region trainig
    public void MOCLEAR() // 도력정제
    {
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentMoralStr += 18;
        GameManager.Instance.stat.CurrentFavorability += 7;

        Debug.Log(GameManager.Instance.stat.currentweeks + "주째");
        Debug.Log("근력 " + GameManager.Instance.stat.CurrentMslStr + ", 도력 " + GameManager.Instance.stat.CurrentMoralStr + ", 호감도 " + GameManager.Instance.stat.CurrentFavorability + ", 재력" + GameManager.Instance.stat.CurrentWealth);

    }

    public void MODEVELOP() // 도술개발
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr -= 12;
        GameManager.Instance.stat.CurrentMoralStr += 42;
        GameManager.Instance.stat.CurrentWealth -= 7;

        Debug.Log(GameManager.Instance.stat.currentweeks + "주째");
        Debug.Log("근력 " + GameManager.Instance.stat.CurrentMslStr + ", 도력 " + GameManager.Instance.stat.CurrentMoralStr + ", 재력 " + GameManager.Instance.stat.CurrentWealth);
    }

    public void MOPRACTICE() // 도술연마
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr += 7;
        GameManager.Instance.stat.CurrentMoralStr += 35;
        GameManager.Instance.stat.CurrentWealth -= 14;
    }

    public void MOCYCLE() // 운기조식
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMoralStr += 20;
        GameManager.Instance.stat.CurrentFavorability -= 7;
    }

    public void PHYPRACTICE() // 체술단련
    {
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr += 18;
        GameManager.Instance.stat.CurrentMoralStr -= 7;
        GameManager.Instance.stat.CurrentFavorability += 7;
    }

    public void SWORDSMS() // 검술단련
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr += 42;
        GameManager.Instance.stat.CurrentMoralStr -= 12;
        GameManager.Instance.stat.CurrentWealth -= 7;
    }

    public void SPEARSMS() // 창술단련
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr += 35;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentWealth -= 14;
    }


    public void BONGMS() // 봉술단련
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMslStr += 20;
        GameManager.Instance.stat.CurrentFavorability -= 7;
    }

    public void CALCSTUDY() //상술공부
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMoralStr -= 7;
        GameManager.Instance.stat.CurrentWealth += 30;
    }

    public void BOOKREAD() //도서읽기
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentWealth += 30;
    }

    public void INSTRUMENT() //악기연주
    {;
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability += 28;
    }

    public void POEMWRITE() //시쓰기
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMslStr += 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability -= 14;
        GameManager.Instance.stat.CurrentWealth += 7;
    }

    public void DRAWING() //그림그리기
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr += 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability += 28;
        GameManager.Instance.stat.CurrentWealth -= 14;
    }
    #endregion

    public void StoryProgress() //3개월 스토리 진행 함수
    {
        Story curStory = null; //로드할 스토리

        if (GameManager.Instance.stat.currentweeks >= GameManager.Instance.stat.weeks) // 3개월 루프
        {
            GameManager.Instance.stat.weeks += 12; // 늘어나야 되는 주

            foreach (Story story in storys) //foreach 반복문
            {
                if (story.goalStat._currentMslStr < GameManager.Instance.stat.CurrentMslStr && story.goalStat._currentMoralStr < GameManager.Instance.stat.CurrentMoralStr
                    && story.goalStat._currentWealth < GameManager.Instance.stat.CurrentWealth && story.goalStat._cureentFavorability < GameManager.Instance.stat.CurrentFavorability) //모든 조건 검사
                {
                    if (curStory != null) //만약 조건에 부합하는 스토리가 이미 존재했을경우
                    {
                        //우선순위를 비교하고 curStory에 넣어준다.
                        curStory = story.priority < curStory.priority ? curStory : story;
                    }
                    else //만약 조건에 부합하는 스토리가 최초일경우
                    {
                        //curStory에 넣어준다.
                        curStory = story;
                    }
                }
                //curStory의 index로 Scene을 Load한다.
                SceneManager.LoadScene(curStory.index);
            }
        }

        else if (GameManager.Instance.stat.currentweeks >= 144)
        {
            //엔딩 함수
        }
    }
}