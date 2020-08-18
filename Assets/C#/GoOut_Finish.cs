using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoOut_Finish : MonoBehaviour
{
    [SerializeField] private GameObject FINISH;

    FW_Shop_Open FW = new FW_Shop_Open();
    GA_Shop_Open GA = new GA_Shop_Open();
    WP_Shop_Open WP = new WP_Shop_Open();

    //콜라이더 활성 및 비활성
    #region
    public BoxCollider2D FWShop;
    public BoxCollider2D WPShop;
    public BoxCollider2D GAShop;

    public BoxCollider2D Restaurant;
    public BoxCollider2D Mountain;
    public BoxCollider2D Lake;

    static public bool openShop = false;
    [SerializeField] private Button ignoreBTN;
    [SerializeField] private GameObject fwShop;
    [SerializeField] private GameObject wpShop;
    [SerializeField] private GameObject gaShop;

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
    #endregion

    public void ESC() //ESC 눌렀을 때 게임 종료 창 띄우기
    {
        FINISH.gameObject.SetActive(true);
        HideCollider();
        ignoreBTN.gameObject.SetActive(false);
    }
    public void ESC_YES() //게임 종료
    {
#if UNITY_EDITOR //에디터일때
        UnityEditor.EditorApplication.isPlaying = false;
        ShowCollider();
#else
        Application.Quit();
#endif
    }
    public void ESC_NO() //종료 창 숨기기
    {
        FINISH.gameObject.SetActive(false);
        ShowCollider();
        ignoreBTN.gameObject.SetActive(true);
    }

    private void Update()
    {
        if (openShop == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                ESC();
            }
        }
    }
}
