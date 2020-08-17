using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending
{
    public StudentStat goalStat;
    public int priority;
}
public class EndCard : MonoBehaviour
{
    [SerializeField] private Button xBTN;

    private Ending[] endings =
    {
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 900, _currentMoralStr = 900, _currentWealth = -1}, priority = 1},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 800, _currentMoralStr = 800, _currentWealth = 500}, priority = 2},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 600, _currentMoralStr = 600, _currentWealth = 800}, priority = 3},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 800, _currentMoralStr = 600, _currentWealth = -1}, priority = 4},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 600, _currentMoralStr = 800, _currentWealth = -1}, priority = 5},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 600, _currentMoralStr = 600, _currentWealth = -1}, priority = 6},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 200, _currentMoralStr = 200, _currentWealth = 500}, priority = 7},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 300, _currentMoralStr = 500, _currentWealth = -1}, priority = 8},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 400, _currentMoralStr = 300, _currentWealth = 300}, priority = 9},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = 300, _currentMoralStr = 300, _currentWealth = -1}, priority = 10},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = -1, _currentWealth = 300}, priority = 11},
        new Ending() {goalStat = new StudentStat(){_currentMslStr = -1, _currentMoralStr = -1, _currentWealth = -1}, priority = 12},
    };

    //카드
    #region
    [SerializeField] private SpriteRenderer card_1;
    [SerializeField] private SpriteRenderer card_2;
    [SerializeField] private SpriteRenderer card_3;
    [SerializeField] private SpriteRenderer card_4;
    [SerializeField] private SpriteRenderer card_5;
    [SerializeField] private SpriteRenderer card_6;
    [SerializeField] private SpriteRenderer card_7;
    [SerializeField] private SpriteRenderer card_8;
    [SerializeField] private SpriteRenderer card_9;
    [SerializeField] private SpriteRenderer card_10;
    [SerializeField] private SpriteRenderer card_11;
    [SerializeField] private SpriteRenderer card_12;
    #endregion

    public void ShowEndCard()
    {
        Ending curEnding = null;

        foreach (Ending ending in endings)
        {
            if (ending.goalStat._currentMslStr < GameManager.Instance.stat.CurrentMslStr && ending.goalStat._currentMoralStr < GameManager.Instance.stat.CurrentMoralStr
                && ending.goalStat._currentWealth < GameManager.Instance.stat.CurrentWealth)
            {
                if (curEnding != null)
                {
                    curEnding = ending.priority > curEnding.priority ? curEnding : ending;
                }
                else
                {
                    curEnding = ending;
                }
            }
        }

        //카드 불러오기
        #region
        if (curEnding.priority == 1)
        {
            card_1.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 2)
        {
            card_2.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 3)
        {
            card_3.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 4)
        {
            card_4.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 5)
        {
            card_5.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 6)
        {
            card_6.gameObject.SetActive(true);;
        }
        else if (curEnding.priority == 7)
        {
            card_7.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 8)
        {
            card_8.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 9)
        {
            card_9.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 10)
        {
            card_10.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 11)
        {
            card_11.gameObject.SetActive(true);
        }
        else if (curEnding.priority == 12)
        {
            card_12.gameObject.SetActive(true);
        }
        #endregion
    }

    private void Start()
    {
        ShowEndCard();
        xBTN.gameObject.SetActive(true);
    }
}
