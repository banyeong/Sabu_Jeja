using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//콜라이더 활성화 및 비활성화 관리
public class ColliderManager : MonoBehaviour
{
    public BoxCollider2D obj_1;
    public BoxCollider2D obj_2;

    public void ShowCollider()
    {
        obj_1.enabled = true;
        obj_2.enabled = true;
    }

    public void HideCollider()
    {
        obj_1.enabled = false;
        obj_2.enabled = false;
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            HideCollider();
        }
    }
}
