using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEditor;
using TMPro;
using UnityEngine.SceneManagement;

#pragma warning disable 0649
public class story_10_choice2 : MonoBehaviour
{
    [SerializeField] private SpriteRenderer sprite_Charcter; //캐릭터
    [SerializeField] private SpriteRenderer sprite_dialogue; //대화창
    [SerializeField] private Text txt_dialogue; //대화내용
    [SerializeField] private SpriteRenderer sprite_name; //누가 말하는지 표시
    [SerializeField] private SpriteRenderer sprite_background; //배경

    [SerializeField] private UnityEngine.UI.Button choice_1; // 선택지 버튼1
    [SerializeField] private UnityEngine.UI.Button choice_2; // 선택지 버튼2

    private bool isShow = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void ShowButton() //선택지 1을 눌렀을 때 나오는 UI들
    {
        sprite_Charcter.gameObject.SetActive(true);
        choice_1.gameObject.SetActive(false);
        choice_2.gameObject.SetActive(false);
        sprite_dialogue.gameObject.SetActive(true);
        sprite_name.gameObject.SetActive(true);
        txt_dialogue.gameObject.SetActive(true);

        isShow = true;
        count = 0;

        NextDialogue();
    }

    public void NextDialogue() //대화활성화
    {
        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        sprite_name.sprite = dialogue[count].nickname;
        sprite_background.sprite = dialogue[count].bg;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if (isShow == true)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count < dialogue.Length)
                {
                    NextDialogue();
                }
                else
                {
                    SceneManager.LoadScene(15);
                }
            }
        }
    }
}