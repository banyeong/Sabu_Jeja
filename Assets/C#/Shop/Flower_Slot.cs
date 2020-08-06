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

    [SerializeField] private GameObject POP_UP;

    bool isEmpty = true;
    
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

    //팝업창 보이기 & 숨기기 함수
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

        if(item == null)
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
}
