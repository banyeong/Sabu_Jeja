using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//콜라이더 활성화 및 비활성화 관리
public class ColliderManager : MonoBehaviour
{
    public BoxCollider2D FWShop;
    public BoxCollider2D WPShop;
    public BoxCollider2D GAShop;

    public BoxCollider2D Restaurant;
    public BoxCollider2D Mountain;
    public BoxCollider2D Lake;

    public void ShowCollider()
    {
        FWShop.enabled = true;
        WPShop.enabled = true;
        GAShop.enabled = true;

        Restaurant.enabled = true;
        Mountain.enabled = true;
        Lake.enabled = true;
    }

    public void HideCollider()
    {
        FWShop.enabled = false;
        WPShop.enabled = false;
        GAShop.enabled = false;

        Restaurant.enabled = false;
        Mountain.enabled = false;
        Lake.enabled = false;
    }
}
