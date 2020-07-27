using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; set; }

    public StudentStat stat { get; set; }

   

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
        
    }
}
