using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WP_Shop_Open : MonoBehaviour
{
    public GameObject Weapon_Shop;
    public Button closeShop;

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Weapon Store"))
            {
                ActiveWPShop(true);
            }
        }
    }
    // 꽃 상점 보이기 및 닫기
    public void ActiveWPShop(bool isOpen)
    {
        Weapon_Shop.SetActive(isOpen);
    }
    public void DeActiveWPShop()
    {
        ActiveWPShop(false);
    }

    //스타트 및 업데이트 함수
    private void Start()
    {
        closeShop.onClick.AddListener(DeActiveWPShop);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}
