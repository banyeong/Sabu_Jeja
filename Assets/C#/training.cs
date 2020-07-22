using System.Collections;
using System.Collections.Generic;
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

    //모든 스토리 ( index, stat{ 0, 0, 0, 0 }, priority )
    private Story[] storys =
                            {
                            new Story() { index = 2, goalStat = new StudentStat(){currentMslStr = -1, currentMoralStr = -1, currentWealth = -1, cureentFavorability = -1}, priority = 0 }, //1
                            new Story() { index = 3, goalStat = new StudentStat(){currentMslStr = 300, currentMoralStr = -1, currentWealth = -1, cureentFavorability = -1}, priority = 20 }, //2
                            new Story() { index = 4, goalStat = new StudentStat(){currentMslStr = -1, currentMoralStr = 300, currentWealth = -1, cureentFavorability = -1}, priority = 30 }, //3
                            new Story() { index = 5, goalStat = new StudentStat(){currentMslStr = -1, currentMoralStr = -1, currentWealth = 500, cureentFavorability = -1}, priority = 40 }, //4
                            new Story() { index = 6, goalStat = new StudentStat(){currentMslStr = -1, currentMoralStr = -1, currentWealth = -1, cureentFavorability = 300}, priority = 60 }, //5
                            new Story() { index = 7, goalStat = new StudentStat(){currentMslStr = 500, currentMoralStr = 500, currentWealth = -1, cureentFavorability = -1}, priority = 70 }, //6
                            new Story() { index = 8, goalStat = new StudentStat(){currentMslStr = 500, currentMoralStr = -1, currentWealth = 500, cureentFavorability = -1}, priority = 80 }, //7
                            new Story() { index = 9, goalStat = new StudentStat(){currentMslStr = 500, currentMoralStr = 300, currentWealth = -1, cureentFavorability = 500}, priority = 90 }, //8
                            new Story() { index = 10, goalStat = new StudentStat(){currentMslStr = -1, currentMoralStr = 500, currentWealth = 500, cureentFavorability = 500}, priority = 110 }, //9
                            new Story() { index = 11, goalStat = new StudentStat(){currentMslStr = 800, currentMoralStr = 500, currentWealth = -1, cureentFavorability = 500}, priority = 150 }, //10
                            new Story() { index = 12, goalStat = new StudentStat(){currentMslStr = 500, currentMoralStr = 800, currentWealth = -1, cureentFavorability = 500}, priority = 170 }, //11
                            new Story() { index = 0, goalStat = new StudentStat(){currentMslStr = 800, currentMoralStr = 800, currentWealth = -1, cureentFavorability = 500}, priority = 200 }, //12
                            };

    #region trainig
    public void MOCLEAR() // 도력정제
    {
        stat.weeks += 2;

        stat.currentMslStr -= 7;
        stat.currentMoralStr += 14;
        stat.cureentFavorability += 7;

        Debug.Log(stat.weeks + "주째");
        Debug.Log("근력 " + stat.currentMoralStr + ", 도력 " + stat.currentMoralStr + ", 호감도 " + stat.cureentFavorability + ", 재력" + stat.currentWealth);

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

    public void StoryProgress()
    {
        Story curStory = null; //로드할 스토리

        foreach (Story story in storys) //foreach 반복문
        {
            if (story.goalStat.currentMslStr < stat.currentMslStr && story.goalStat.currentMoralStr < stat.currentMoralStr
                && story.goalStat.currentWealth < stat.currentWealth && story.goalStat.cureentFavorability < stat.cureentFavorability) //모든 조건 검사
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
}