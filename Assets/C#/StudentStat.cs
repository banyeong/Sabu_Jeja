using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StudentStat
{
    public static StudentStat instance;
    
    public int weeks; 
    public int currentweeks;

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

    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
    }
}
