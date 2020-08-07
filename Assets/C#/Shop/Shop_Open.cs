using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shop_Open : MonoBehaviour
{
    public GameObject shop;
    public Button closeShop;

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);
        
        if(hit2D.collider != null)
        {
            if(hit2D.collider.CompareTag("Flower Store"))
            {
                ActiveShop(true);
            }
        }
    }
    // 상점 보이기 및 닫기
    public void ActiveShop(bool isOpen)
    {
        shop.SetActive(isOpen);
    }
    public void DeActiveShop()
    {
        ActiveShop(false);
    }

    //스타트 및 업데이트 함수
    private void Start()
    {
        closeShop.onClick.AddListener(DeActiveShop);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}
