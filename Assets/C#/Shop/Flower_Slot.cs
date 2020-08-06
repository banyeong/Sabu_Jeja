using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Flower_Slot : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [HideInInspector] //인스펙터에 안 나타나도록
    public ItemProperty item;
    public Image image;

    [SerializeField] private GameObject POP_UP; //커서 갖다댈 시 뜨는 설명 팝업창

    [SerializeField] private GameObject Buy_POP_UP; //아이템 구매 완료시 뜨는 팝업창
    [SerializeField] private Text IsBuy; //구매 완료? 실패?
    [SerializeField] private Text Buy_ex; //구매 완료시 정보 표시, 실패시 돈 부족합니다.

    //입력 정보
    public int price; //아이템 가격
    public int Msl_Str; //근력
    public int Moral_Str; //도력
    public int Favorability; //호감도

    bool isEmpty = true;
    bool isBuy = false;

    //마우스 커서 갖다댔을 때 팝업창 뜨도록 하기
    public void OnPointerEnter(PointerEventData eventData)//IPointerEnterHandler
    {
        //팝업창 나타남
        if (!isEmpty)
        {
            Show_Pop_up(transform.position);
        }
    }
    public void OnPointerExit(PointerEventData eventData)//IPointerExitHandler
    {
        //팝업창 가림
        Hide_Pop_up();
    }

    //설명 팝업창 보이기 & 숨기기 함수
    public void Show_Pop_up(Vector3 position)
    {
        POP_UP.SetActive(true);
        POP_UP.transform.position = position;
    }
    public void Hide_Pop_up()
    {
        POP_UP.SetActive(false);
    }

    // 아이템 등록
    public void SetItem(ItemProperty item)
    {
        this.item = item;

        if (item == null)
        {
            image.enabled = false;
            isEmpty = true;

            gameObject.name = "Empty";
        }
        else
        {
            image.enabled = true;
            isEmpty = false;

            gameObject.name = item.name;
            image.sprite = item.sprite;
        }
    }

    // 아이템 구매 성공 팝업창 띄우기
    public void Success_ShowBuy()
    {
        Buy_POP_UP.gameObject.SetActive(true);
        IsBuy.text = "구매 완료";
        Buy_ex.text = "남은 골드 : " + GameManager.Instance.stat.Current_Money + "\n"
            + "근력 : " + GameManager.Instance.stat.CurrentMslStr + "\n"
            + "도력 : " + GameManager.Instance.stat.CurrentMoralStr + "\n"
            + "호감도 : " + GameManager.Instance.stat.CurrentFavorability;
    }

    //아이템 구매 실패 팝업창 띄우기
    public void Fail_ShowBuy()
    {
        Buy_POP_UP.gameObject.SetActive(true);
        IsBuy.text = "구매 실패";
        Buy_ex.text = "골드가 부족합니다.";
    }

    public void BuyItem() //아이템 구매시 정보 변경 및 성공 팝업창 함수 불러오기
    {
        GameManager.Instance.stat.Current_Money -= price;

        GameManager.Instance.stat.CurrentMslStr += Msl_Str;
        GameManager.Instance.stat.CurrentMoralStr += Moral_Str;
        GameManager.Instance.stat.CurrentFavorability += Favorability;

        Success_ShowBuy();
    }
    public void NoBuyItem() // 팝업 사라짐
    {
        Buy_POP_UP.gameObject.SetActive(false);
    }

    //버튼 적용 함수
    public void ClickBuy_Item()
    {
        if (GameManager.Instance.stat.Current_Money >= price)
        {
            BuyItem();
        }
        else
        {
            Fail_ShowBuy();
        }
    }

    private void Update()
    {

    }
}
