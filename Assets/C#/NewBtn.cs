using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//버튼 관리
public class NewBtn : MonoBehaviour
{
    [SerializeField] private GameObject FINISH;

    public void ESC() //ESC 눌렀을 때 게임 종료 창 띄우기
    {
        FINISH.gameObject.SetActive(true);
    }

    public void ESC_YES() //게임 종료
    {
#if UNITY_EDITOR //에디터일때
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    public void ESC_NO() //종료 창 숨기기
    {
        FINISH.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ESC();
        }
    }
}
