using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FW_Shop_Open : MonoBehaviour
{
    public bool isFWOpen = false;

    public GameObject Flower_Shop;
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
        
        if(hit2D.collider != null)
        {
            if(hit2D.collider.CompareTag("Flower Store"))
            {
                ActiveFWShop(true);
                HideCollider();
            }
        }
    }
    // 꽃 상점 보이기 및 닫기
    public void ActiveFWShop(bool isOpen)
    {
        Flower_Shop.SetActive(isOpen);
        Back.gameObject.SetActive(false);
        isFWOpen = true;
    }
    public void DeActiveFWShop()
    {
        ActiveFWShop(false);
        ShowCollider();
        Back.gameObject.SetActive(true);
        isFWOpen = false;
    }

    //스타트 및 업데이트 함수
    private void Start()
    {
        closeShop.onClick.AddListener(DeActiveFWShop);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}
