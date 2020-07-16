using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StudentStat
{
    public static StudentStat instance;

        public int MslStr;//근력
        public int currentMslStr = 100;

        public int MoralStr;//도력
        public int currentMoralStr = 100;

        public int Wealth;//재력
        public int currentWealth = 100;

        public int Favorability;//호감도
        public int cureentFavorability = 100;

    // Start is called before the first frame update
    public void Start()
    {
        instance = this;
    }
}
