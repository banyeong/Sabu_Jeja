using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//버튼 관리
public class NewBtn : MonoBehaviour
{
    public BTNType currentType;

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.New:
                print("새게임");
                break;
            case BTNType.Continue:
                print("이어하기");
                break;
            case BTNType.Quit:
                print("나가기");
                break;
        }
    }
}
