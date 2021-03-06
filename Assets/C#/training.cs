﻿using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Story
{
    public int index; //로드할때 쓸 인덱스
    public StudentStat goalStat; //목표 점수 
    public int priority; //우선 순위(스토리 점수)
}

public class training : MonoBehaviour
{
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

    // 수련 알림창 요소
    [SerializeField] static private GameObject Big;
    [SerializeField] private Button Back;
    [SerializeField] private SpriteRenderer Finish;
    [SerializeField] static private Text Stat;
    [SerializeField] private GameObject Panel;


    //골드 점수 환산 함수
    int goal_Gold_Score = 1000; //처음 기준 골드 점수
    public void Gold_Change() //1000골드에 10골드 점수
    {
        if (GameManager.Instance.stat._current_money >= goal_Gold_Score)
        {
            goal_Gold_Score += 1000;
            GameManager.Instance.stat.Gold_Score += 10;
        }
    }
    
    //수련 클릭이 되었는가?
    static public bool isClick_Msl; //기본값 false
    static public bool isClick_Moral;
    static public bool isClick_Etc;

    public int plus;
    //애니메이션
    public GameObject mslstr_Ani;
    public GameObject moral_Ani;
    public GameObject etc_Ani;

    #region training                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                             #region trainig
    public void MOCLEAR() // 도력정제
    {
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentMoralStr += 21;
        GameManager.Instance.stat.CurrentFavorability += 7;
        
        // 호감도 장소가 오픈됐을 때
        if(GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 2;
        }
        if(GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 2;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 2;
        }

        plus += 1;
        isClick_Moral = !isClick_Moral;
        TimeCheck();
    }
    
    public void MODEVELOP() // 도술개발
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentMoralStr += 42;
        GameManager.Instance.stat.CurrentWealth -= 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 3;
        }

        plus += 1;
        isClick_Moral = !isClick_Moral;
        TimeCheck();
    }

    public void MOPRACTICE() // 도술연마
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr += 14;
        GameManager.Instance.stat.CurrentMoralStr += 35;
        GameManager.Instance.stat.CurrentWealth -= 14;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 4;
        }

        plus += 1;
        isClick_Moral = !isClick_Moral;
        TimeCheck();
    }

    public void MOCYCLE() // 운기조식
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMoralStr += 21;
        GameManager.Instance.stat.CurrentFavorability -= 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 1;
        }

        plus += 1;
        isClick_Moral = !isClick_Moral;
        TimeCheck();
    }

    public void PHYPRACTICE() // 체술단련
    {
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr += 21;
        GameManager.Instance.stat.CurrentMoralStr -= 7;
        GameManager.Instance.stat.CurrentFavorability += 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 2;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 2;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 2;
        }

        plus += 1;
        isClick_Msl = !isClick_Msl;
        TimeCheck();
    }

    public void SWORDSMS() // 검술단련
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr += 42;
        GameManager.Instance.stat.CurrentMoralStr -= 7;
        GameManager.Instance.stat.CurrentWealth -= 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 3;
        }

        plus += 1;
        isClick_Msl = !isClick_Msl;
        TimeCheck();
    }
    
    public void SPEARSMS() // 창술단련
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr += 35;
        GameManager.Instance.stat.CurrentMoralStr += 14;
        GameManager.Instance.stat.CurrentWealth -= 14;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 4;
        }

        plus += 1;
        isClick_Msl = !isClick_Msl;
        TimeCheck();
    }

    public void BONGMS() // 봉술단련
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMslStr += 21;
        GameManager.Instance.stat.CurrentFavorability -= 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 1;
        }

        plus += 1;
        isClick_Msl = !isClick_Msl;
        TimeCheck();
    }
    
    public void CALCSTUDY() //상술공부
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMoralStr -= 7;
        GameManager.Instance.stat.CurrentWealth += 35;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 4;
        }

        plus += 1;
        isClick_Etc = !isClick_Etc;
        TimeCheck();
    }

    public void BOOKREAD() //도서읽기
    {
        GameManager.Instance.stat.currentweeks += 4;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentWealth += 35;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 4;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 4;
        }

        plus += 1;
        isClick_Etc = !isClick_Etc;
        TimeCheck();
    }

    public void INSTRUMENT() //악기연주
    {;
        GameManager.Instance.stat.currentweeks += 2;

        GameManager.Instance.stat.CurrentMslStr -= 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability += 21;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 2;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 2;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 2;
        }

        plus += 1;
        isClick_Etc = !isClick_Etc;
        TimeCheck();
    }

    public void POEMWRITE() //시쓰기
    {
        GameManager.Instance.stat.currentweeks += 1;

        GameManager.Instance.stat.CurrentMslStr += 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability -= 7;
        GameManager.Instance.stat.CurrentWealth += 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 1;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 1;
        }

        plus += 1;
        isClick_Etc = !isClick_Etc;
        TimeCheck();
    }

    public void DRAWING() //그림그리기
    {
        GameManager.Instance.stat.currentweeks += 3;

        GameManager.Instance.stat.CurrentMslStr += 7;
        GameManager.Instance.stat.CurrentMoralStr += 7;
        GameManager.Instance.stat.CurrentFavorability += 21;
        GameManager.Instance.stat.CurrentWealth -= 7;

        if (GameManager.Instance.stat.isRTOpen == true)
        {
            GameManager.Instance.stat.RT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isMTOpen == true)
        {
            GameManager.Instance.stat.MT_Open_weeks += 3;
        }
        if (GameManager.Instance.stat.isLKOpen == true)
        {
            GameManager.Instance.stat.LK_Open_weeks += 3;
        }

        plus += 1;
        isClick_Etc = !isClick_Etc;
        TimeCheck();
    }
    
    #endregion
   

    public void StoryProgress() //3개월 스토리 진행 함수
    {
        Y_N_Training.istraining = false;
        Story curStory = null; //로드할 스토리

        if ((GameManager.Instance.stat.currentweeks >= GameManager.Instance.stat.weeks) && (GameManager.Instance.stat.currentweeks < 144)) // 3개월 루프
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
            }
            //curStory의 index로 Scene을 Load한다.
            SceneManager.LoadScene(curStory.index);
        }

        else if (GameManager.Instance.stat.currentweeks >= 144) // 3년이 지났을 때 엔딩
        {
            Y_N_Training.istraining = false;

            int Final_Gold = GameManager.Instance.stat.Gold_Score - GameManager.Instance.stat.Story_Score;
            int Final_Story = GameManager.Instance.stat.Story_Score - GameManager.Instance.stat.Gold_Score;

            if (GameManager.Instance.stat.Gold_Score > GameManager.Instance.stat.Story_Score) // 골드 점수가 스토리 점수보다 더 높다면
            {
                if (Final_Gold <= 300) //골드 점수와 스토리 점수의 차 300 이하 = 비호감도 엔딩 1
                {
                    SceneManager.LoadScene(16);
                }
                else if (Final_Gold > 300 && Final_Gold <= 500) // 300 초과 500 이하 = 비호감도 엔딩 2
                {
                    SceneManager.LoadScene(17);
                }
                else // 500초과 = 비호감도 엔딩 3
                {
                    SceneManager.LoadScene(18);
                }
            }
            else
            {
                if (Final_Story <= 300) //300 이하 = 호감도 엔딩 1
                {
                    SceneManager.LoadScene(19);
                }
                else if (Final_Story > 300 && Final_Story <= 500) // 300 초과 500 이하 = 호감도 엔딩 2
                {
                    SceneManager.LoadScene(20);
                }
                else // 500 초과 = 호감도 엔딩 3
                {
                    SceneManager.LoadScene(21);
                }
            }
        }
    }

    //시간 경과
    float time;
    float checkTime;
    private void Start()
    {
        isClick_Msl = false;
        time = 0.0f;
        checkTime = 2.0f;
    }
    private void TimeCheck()
    {
        if (isClick_Msl)
        {
            mslstr_Ani.gameObject.SetActive(true);
        }
        if (isClick_Moral)
        {
            moral_Ani.gameObject.SetActive(true);
        }
        if (isClick_Etc)
        {
            etc_Ani.gameObject.SetActive(true);
        }
    }
}