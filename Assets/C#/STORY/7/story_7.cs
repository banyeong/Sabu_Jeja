﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEditor;

public class story_7 : MonoBehaviour
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
                    //씬전환
                }
            }
        }
    }
}