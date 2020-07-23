using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    StudentStat stat = new StudentStat();

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
