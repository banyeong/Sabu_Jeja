using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    StudentStat stat;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);//깃허브 봇 실험
    }
}
