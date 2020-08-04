using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StudentStat
{
    public int money_weeks; //한 달마다 과외비
    public int weeks; // 12주(세 달)
    public int currentweeks; // 현재 주
    public int Story_Score; // 스토리 점수
    public int Gold_Score; // 골드 점수


    //현재 돈
    public int _current_money;
    public int Current_Money
    {
        set
        {
            _current_money = Mathf.Clamp(value, 0, 1000000);
        }
        get
        {
            return _current_money;
        }
    }

    //근력
    public int _currentMslStr;
    public int CurrentMslStr
    {
        set                      
        {
            _currentMslStr = Mathf.Clamp(value, 0, 1000);
        }
        get
        {
            return _currentMslStr;
        }
    }

    //도력
    public int _currentMoralStr;
    public int CurrentMoralStr
    {
        set
        {
            _currentMoralStr = Mathf.Clamp(value, 0, 1000);
        }
        get
        {
            return _currentMoralStr;
        }
    }

    //재력
    public int _currentWealth;
    public int CurrentWealth
    {
        set
        {
            _currentWealth = Mathf.Clamp(value, 0, 1000);
        }
        get
        {
            return _currentWealth;
        }
    }

    //호감도
    public int _cureentFavorability;
    public int CurrentFavorability
    {
        set
        {
            _cureentFavorability = Mathf.Clamp(value, 0, 1000);
        }
        get
        {
            return _cureentFavorability;
        }
    }
}
