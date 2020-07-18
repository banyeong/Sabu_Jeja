using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEditor;

public class story_10 : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter; //캐릭터
    [SerializeField] private SpriteRenderer sprite_dialogue; //대화창
    [SerializeField] private Text txt_dialogue; //대화내용
    [SerializeField] private SpriteRenderer sprite_name; //누가 말하는지 표시
    [SerializeField] private SpriteRenderer sprite_background; //배경

    [SerializeField] private UnityEngine.UI.Button choice_1; // 선택지 버튼1
    [SerializeField] private UnityEngine.UI.Button choice_2; // 선택지 버튼2

    private bool isDialogue = true;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowButton() //선택지버튼과 제자 캐릭터만 보이게 하는 함수
    {
        choice_1.gameObject.SetActive(true);
        choice_2.gameObject.SetActive(true);
        sprite_dialogue.gameObject.SetActive(false);
        sprite_name.gameObject.SetActive(false);
        txt_dialogue.gameObject.SetActive(false);

        isDialogue = false;
    }

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        sprite_name.sprite = dialogue[count].nickname;
        sprite_background.sprite = dialogue[count].bg;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (isDialogue == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    ShowButton();
                }
            }
        }
    }
}