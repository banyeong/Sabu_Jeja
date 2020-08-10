using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RT_OPEN : MonoBehaviour
{
    //3개월 후에 갈 수 있음을 알려주기 위한 알림창
    [SerializeField] private SpriteRenderer UI;
    [SerializeField] private Text txt;

    private void ShowUI()
    {
        UI.gameObject.SetActive(true);
        txt.text = "3개월이 지난 후 다시 갈 수 있습니다.\n 남은 주 : " + (13 - GameManager.Instance.stat.RT_Open_weeks);
    }

    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Restaurant")) // 음식점에 닿았을 때
            {
                if (GameManager.Instance.stat.RT_Open_weeks == 1) //최초 or 이벤트를 본지 3개월 후라면
                {
                    GameManager.Instance.stat.isRTOpen = true;
                    GameManager.Instance.stat.RT_Open_weeks += 1;
                    RandomScene(); // 이벤트 호출
                }
                else // 최초가 아닌데 3개월 후도 아니라면
                {
                    if (GameManager.Instance.stat.RT_Open_weeks >= 13) // 3개월 이상이 됐을 때
                    {
                        GameManager.Instance.stat.isRTOpen = false;
                        GameManager.Instance.stat.RT_Open_weeks = 1;
                    }
                    else
                    {
                        ShowUI();
                    }
                }
            }
        }
    }

    public void RandomScene()
    {
        int x = Random.Range(0, 2);

        switch(x)
        {
            case 0:
                SceneManager.LoadScene(24);
                break;
            case 1:
                SceneManager.LoadScene(25);
                break;
        }
    }

    //스타트 및 업데이트 함수
    private void Start()
    {
        //closeShop.onClick.AddListener(DeActiveGAShop);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RayShop();
        }
    }
}