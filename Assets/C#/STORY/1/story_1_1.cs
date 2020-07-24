using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

[System.Serializable]
public class Dialogue //집어 넣을 대화와 캐릭터이미지, 나중에 배경도 선언 하면 배경 바뀌게도 할 수 있을 듯함.
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public Sprite bg;
    public Sprite nickname;
}

public class story_1_1 : MonoBehaviour //아무런 조건도 충족하지 못함
{
    #pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter; //캐릭터
    [SerializeField] private SpriteRenderer sprite_dialogue; //대화창
    [SerializeField] private Text txt_dialogue; //대화내용
    [SerializeField] private SpriteRenderer sprite_name; //누가 말하는지 표시
    [SerializeField] private SpriteRenderer sprite_background; //배경

    private bool isDialogue = true;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

        sprite_Charcter.gameObject.SetActive(true);
        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        sprite_name.sprite = dialogue[count].nickname;
        sprite_background.sprite = dialogue[count].bg;
        count++;
    }

    // Update is called once per frame
    void Update()
    {
        if(isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if(count < dialogue.Length)
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
