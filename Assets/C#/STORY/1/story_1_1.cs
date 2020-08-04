using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[System.Serializable]
public class Dialogue
{
    [TextArea]
    public string dialogue;
    public Sprite cg;
    public Sprite bg;
    public Sprite nickname;
}

public class story_1_1 : MonoBehaviour
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
        sprite_Charcter.gameObject.SetActive(true);
        txt_dialogue.text = dialogue[count].dialogue;
        sprite_Charcter.sprite = dialogue[count].cg;
        sprite_name.sprite = dialogue[count].nickname;
        sprite_background.sprite = dialogue[count].bg;
        count++;
    }

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
                    GameManager.Instance.stat.Story_Score += 0;
                    SceneManager.LoadScene(15);
                }
            }
        }
    }
}
