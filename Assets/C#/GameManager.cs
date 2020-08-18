using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public StudentStat stat { get; set; }
    public StudentStat endCard { get; set; }

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }

        DontDestroyOnLoad(gameObject);

        stat = new StudentStat()
        {
            _current_money = 0,
            money_weeks = 4,
            weeks = 12,
            currentweeks = 1,
            _currentMslStr = 100,
            _currentMoralStr = 100,
            _currentWealth = 100,
            _cureentFavorability = 100,
            Story_Score = 0,
            Gold_Score = 0,
            RT_Open_weeks = 1,
            isRTOpen = false,
            MT_Open_weeks = 1,
            isMTOpen = false,
            LK_Open_weeks = 1,
            isLKOpen = false,
        };
    }

    [SerializeField] GameObject afterLoad;
    [SerializeField] GameObject ignorePanel;
    public void GameSave()
    {
        //주, 능력치 등등...
        PlayerPrefs.SetInt("Current Money", GameManager.Instance.stat.Current_Money);
        PlayerPrefs.SetInt("Weeks", GameManager.Instance.stat.weeks);
        PlayerPrefs.SetInt("Current Weeks", GameManager.Instance.stat.currentweeks);
        PlayerPrefs.SetInt("Money Weeks", GameManager.Instance.stat.money_weeks);
        PlayerPrefs.SetInt("Current MslStr", GameManager.Instance.stat.CurrentMslStr);
        PlayerPrefs.SetInt("Current MoralStr", GameManager.Instance.stat.CurrentMoralStr);
        PlayerPrefs.SetInt("Current Wealth", GameManager.Instance.stat.CurrentWealth);
        PlayerPrefs.SetInt("Current Favorability", GameManager.Instance.stat.CurrentFavorability);

        PlayerPrefs.SetInt("Story score", GameManager.Instance.stat.Story_Score);
        PlayerPrefs.SetInt("Gold score", GameManager.Instance.stat.Gold_Score);

        PlayerPrefs.SetInt("RT_Open_weeks", GameManager.Instance.stat.RT_Open_weeks);
        PlayerPrefs.SetInt("MT_Open_weeks", GameManager.Instance.stat.MT_Open_weeks);
        PlayerPrefs.SetInt("LK_Open_weeks", GameManager.Instance.stat.LK_Open_weeks);

        PlayerPrefs.Save();
        afterLoad.gameObject.SetActive(false);
        ignorePanel.gameObject.SetActive(false);
    }
    public void GameLoad()
    {
        if (!PlayerPrefs.HasKey("Current Money")) 
        {
            FailLoad failLoad = new FailLoad();
            failLoad.ShowFailLoad();
        }
        SceneManager.LoadScene(15);
        int Money = PlayerPrefs.GetInt("Current Money");
        int Weeks = PlayerPrefs.GetInt("Weeks");
        int CurrentWeeks = PlayerPrefs.GetInt("Current Weeks");
        int MoneyWeeks = PlayerPrefs.GetInt("Money Weeks");
        int MslStr = PlayerPrefs.GetInt("Current MslStr");
        int MoralStr = PlayerPrefs.GetInt("Current MoralStr");
        int Wealth = PlayerPrefs.GetInt("Current Wealth");
        int Favorability = PlayerPrefs.GetInt("Current Favorability");

        int storyScore = PlayerPrefs.GetInt("Story score");
        int goldScore = PlayerPrefs.GetInt("Gold score");

        int RT = PlayerPrefs.GetInt("RT_Open_weeks");
        int MT = PlayerPrefs.GetInt("MT_Open_weeks");
        int LK = PlayerPrefs.GetInt("LK_Open_weeks");

        GameManager.Instance.stat.Current_Money = Money;
        GameManager.Instance.stat.weeks = Weeks;
        GameManager.Instance.stat.currentweeks = CurrentWeeks;
        GameManager.Instance.stat.money_weeks = MoneyWeeks;
        GameManager.Instance.stat.CurrentMslStr = MslStr;
        GameManager.Instance.stat.CurrentMoralStr = MoralStr;
        GameManager.Instance.stat.CurrentWealth = Wealth;
        GameManager.Instance.stat.CurrentFavorability = Favorability;

        GameManager.Instance.stat.Story_Score = storyScore;
        GameManager.Instance.stat.Gold_Score = goldScore;

        GameManager.Instance.stat.RT_Open_weeks = RT;
        GameManager.Instance.stat.MT_Open_weeks = MT;
        GameManager.Instance.stat.LK_Open_weeks = LK;
    }
}
