using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class StudentStat
{
    public static StudentStat instance;
    
    public int weeks = 1;

    //근력
    public int currentMslStr = Mathf.Clamp(100, 0, 1000);

    //도력
    public int currentMoralStr = Mathf.Clamp(100, 0, 1000);

    //재력
    public int currentWealth = Mathf.Clamp(100, 0, 1000);

    //호감도
    public int cureentFavorability = Mathf.Clamp(100, 0, 1000);

    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
    }
}
