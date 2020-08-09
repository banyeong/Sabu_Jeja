using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lake_OPEN : MonoBehaviour
{
    public void RayShop()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = -10;
        RaycastHit2D hit2D = Physics2D.Raycast(mousePos, transform.forward, 30);

        if (hit2D.collider != null)
        {
            if (hit2D.collider.CompareTag("Lake"))
            {
                RandomScene();
            }
        }
    }

    public void RandomScene()
    {
        int x = Random.Range(0, 3);

        switch (x)
        {
            case 0:
                SceneManager.LoadScene(28);
                break;
            case 1:
                SceneManager.LoadScene(29);
                break;
            case 2:
                SceneManager.LoadScene(30);
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
