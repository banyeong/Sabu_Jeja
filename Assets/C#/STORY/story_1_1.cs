using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

[System.Serializable]
public class Dialogue //집어 넣을 대화와 캐릭터이미지, 나중에 배경도 선언 하면 배경 바뀌게도 할 수 있을 듯함.
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public Sprite nickname;
}

public class story_1_1 : MonoBehaviour //아무런 조건도 충족하지 못함
{
    #pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter;
    [SerializeField] private SpriteRenderer sprite_dialogue;
    [SerializeField] private TextMeshProUGUI txt_dialogue;
    
    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

            txt_dialogue.text = dialogue[count].dialogue;
            sprite_Charcter.sprite = dialogue[count].cg;
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
                    //씬 전환 로그 넣어야 할 듯
                }    
            }
        }
    }
}
