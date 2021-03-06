﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bad_End_2 : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter; //캐릭터
    [SerializeField] private SpriteRenderer sprite_dialogue; //대화창
    [SerializeField] private Text txt_dialogue; //대화내용
    [SerializeField] private SpriteRenderer sprite_name; //누가 말하는지 표시
    [SerializeField] private SpriteRenderer sprite_background; //배경

    [SerializeField] private GameObject menu;

    private bool isDialogue = true;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue;

    public void NextDialogue() //대화활성화
    {
        sprite_name.gameObject.SetActive(true);
        sprite_Charcter.gameObject.SetActive(true);
        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        sprite_name.sprite = dialogue[count].nickname;
        sprite_background.sprite = dialogue[count].bg;
        count++;
    }

    //시간 경과
    float time;
    float checkTime;
    private void Start()
    {
        time = 0.0f;
        checkTime = 1.0f;
    }

    void Update()
    {
        if (isDialogue == true)
        {
            if (NewBtn.isESC == false)
            {
                if (Input.GetMouseButtonDown(0))
                {
                    if (count < dialogue.Length)
                    {
                        NextDialogue();
                    }
                    else
                    {
                        SceneManager.LoadScene(31);
                    }
                }
            }
            else if (menu.activeSelf == true)
            {
                time += Time.deltaTime;
                if (time > checkTime)
                {
                    menu.gameObject.SetActive(false);
                    NewBtn.isESC = false;
                    time = 0.0f;
                }
            }
        }
    }
}
