using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StudentStat
{
    public static StudentStat instance;
    
    public int weeks = 1; // 3개월 지나면 초기화하기 위해. 3개월 스토리 보고 나면 초기화 되는 함수.
    public int currentweeks; // 144주 지나면 엔딩 띄우기 위해, 지금 몇 주인지 알리기 위해. 초기화 되지 않는 변수.

    //근력
    public int _currentMslStr;
    public int CurrentMslStr
    {
        set
        {
            _currentMslStr = Mathf.Clamp(_currentMslStr + value, 0, 1000);
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
            _currentMoralStr = Mathf.Clamp(_currentMoralStr + value, 0, 1000);
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
            _currentWealth = Mathf.Clamp(_currentWealth + value, 0, 1000);
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
            _cureentFavorability = Mathf.Clamp(_cureentFavorability + value, 0, 1000);
        }
        get
        {
            return _cureentFavorability;
        }
    }

    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
    }
}
