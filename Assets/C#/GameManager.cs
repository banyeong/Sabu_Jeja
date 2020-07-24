using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public StudentStat stat { get; set; }

    public Text DateText; // 메인화면 날짜 텍스트
    public int Year;
    public int Month;

    //날짜 치환 함수 필요할 것 같음
    public void DateChange()
    {
        
    }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);
    }

    private void Start()
    {
        stat = new StudentStat() { weeks = 12, currentweeks = 1, _currentMslStr = 100, _currentMoralStr = 100, _currentWealth = 100, _cureentFavorability = 100 };
    }

    private void Update()
    {
        DateText.text = GameManager.Instance.stat.currentweeks + "주"; //몇 년 몇 개월 몇 주로 작성할 필요 있음
    }
}
