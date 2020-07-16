using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class story_2_2 : MonoBehaviour
{
#pragma warning disable 0649

    [SerializeField] private SpriteRenderer sprite_Charcter;
    [SerializeField] private SpriteRenderer sprite_dialogue;

    [SerializeField] private TextMeshProUGUI txt_choice1;

    [SerializeField] private UnityEngine.UI.Button pgButton;
    [SerializeField] private UnityEngine.UI.Button choice_1;
    [SerializeField] private UnityEngine.UI.Button choice_2;

    private bool isDialogue = false;
    private int count = 0;

    [SerializeField] private Dialogue[] dialogue_1;

    public void ShowDialogue() //대화가 보이도록 하는 함수
    {
        choice_1.gameObject.SetActive(false);
        choice_2.gameObject.SetActive(false);
        txt_choice1.gameObject.SetActive(true);
        NextDialogue();
    }

    public void NextDialogue() //대화활성화
    {
        StudentStat studentStat = new StudentStat();

        txt_choice1.text = dialogue_1[count].dialogue;
        sprite_Charcter.sprite = dialogue_1[count].cg;
        count++;
    }

    void Update()
    {
        if (isDialogue)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (count < dialogue_1.Length)
                {
                    NextDialogue();
                }
            }
        }
    }
}
