using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GA_Shop_Open : MonoBehaviour
{
    public GameObject Gaurd_Shop;
    public Button closeShop;

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
            }
        }
    }
    // 꽃 상점 보이기 및 닫기
    public void ActiveGAShop(bool isOpen)
    {
        Gaurd_Shop.SetActive(isOpen);
    }
    public void DeActiveGAShop()
    {
        ActiveGAShop(false);
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
