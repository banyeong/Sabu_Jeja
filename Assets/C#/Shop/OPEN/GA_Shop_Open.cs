﻿using UnityEngine;
using UnityEngine.UI;

public class GA_Shop_Open : MonoBehaviour
{
    public bool isGAOpen = false;

    public GameObject Gaurd_Shop;
    public Button closeShop;
    public Button Back;

    //박스 콜라이더
    public BoxCollider2D Flower;
    public BoxCollider2D Weapon;
    public BoxCollider2D Gaurd;
    public BoxCollider2D MT;
    public BoxCollider2D RT;
    public BoxCollider2D LK;

    private void HideCollider() //콜라이더 비활성화
    {
        Flower.enabled = false;
        Weapon.enabled = false;
        Gaurd.enabled = false;
        MT.enabled = false;
        RT.enabled = false;
        LK.enabled = false;
    }
    private void ShowCollider() //콜라이더 활성화
    {
        Flower.enabled = true;
        Weapon.enabled = true;
        Gaurd.enabled = true;
        MT.enabled = true;
        RT.enabled = true;
        LK.enabled = true;
    }

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Gaurd Store"))
            {
                ActiveGAShop(true);
                HideCollider();
            }
        }
    }
    // 방어구 상점 보이기 및 닫기
    public void ActiveGAShop(bool isOpen)
    {
        Gaurd_Shop.SetActive(isOpen);
        Back.gameObject.SetActive(false);
        isGAOpen = true;
        GoOut_Finish.openShop = true;
    }
    public void DeActiveGAShop()
    {
        ActiveGAShop(false);
        ShowCollider();
        Back.gameObject.SetActive(true);
        isGAOpen = false;
        GoOut_Finish.openShop = false;
    }

    //스타트 및 업데이트 함수
    private void Start()
    {
        closeShop.onClick.AddListener(DeActiveGAShop);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}
