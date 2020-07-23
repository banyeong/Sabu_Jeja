using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public static StudentStat stat;

    private void Awake()
    {
        new StudentStat();
        DontDestroyOnLoad(gameObject);
    }
}
