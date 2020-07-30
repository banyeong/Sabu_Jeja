using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//버튼 관리
public class NewBtn : MonoBehaviour
{
    [SerializeField] private GameObject START;
    [SerializeField] private GameObject FINISH;

    public void Go() //시작 버튼 눌렀을 때 시작하겠냐는 물음창 띄우기
    {
        START.gameObject.SetActive(true);
    }
    public void Go_YES() //메인 화면 불러오기
    {
        SceneManager.LoadScene(15);
    }
    public void Go_NO() //창 숨기기
    {
        START.gameObject.SetActive(false);
    }


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
