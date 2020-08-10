using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Mountain_OPEN : MonoBehaviour
{
    //3개월 후에 갈 수 있음을 알려주기 위한 알림창
    [SerializeField] private SpriteRenderer UI;
    [SerializeField] private Text txt;

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

    private void ShowUI()
    {
        UI.gameObject.SetActive(true);
        txt.text = "3개월이 지난 후 다시 갈 수 있습니다.\n 남은 주 : " + (13 - GameManager.Instance.stat.MT_Open_weeks);
    }
    public void HideUI()
    {
        UI.gameObject.SetActive(false);
        ShowCollider();
    }

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Mountain"))
            {
                if(GameManager.Instance.stat.MT_Open_weeks == 1)
                {
                    GameManager.Instance.stat.isMTOpen = true;
                    GameManager.Instance.stat.MT_Open_weeks += 1;
                    RandomScene();
                }
                else
                {
                    if (GameManager.Instance.stat.MT_Open_weeks >= 13) // 3개월 이상이 됐을 때
                    {
                        GameManager.Instance.stat.isMTOpen = false;
                        GameManager.Instance.stat.MT_Open_weeks = 1;
                    }
                    else
                    {
                        ShowUI();
                        HideCollider();
                    }
                }
            }
        }
    }

    public void RandomScene()
    {
        int x = Random.Range(0, 2);

        switch (x)
        {
            case 0:
                SceneManager.LoadScene(26);
                break;
            case 1:
                SceneManager.LoadScene(27);
                break;
        }
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}
