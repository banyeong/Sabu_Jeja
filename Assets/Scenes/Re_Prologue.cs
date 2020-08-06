using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Re_Prologue : MonoBehaviour
{
    [SerializeField] private Button Click;

    public Text tx;
    private string m_text = "세계에서 제일 이름난 도사인 주인공은" + "\n"
        + "방랑벽이 있어 한 곳에 머물지 않고" + "\n"
        + "이곳저곳을 돌아다니다 그만 빈털털이가" + "\n"
        + "되어버리고 말았습니다." + "\n\n"
        + "구걸을 하던 도중 돈을 줄테니 3년 동안" + "\n"
        + "제자로 받아달라는 남자가 찾아 오는데" + "\n"
        + "돈에 눈이 먼 주인공은 그 사람을 제자로" + "\n"
        + "받아들이기로 합니다.";

    public bool text_cut = false;
    public bool text_full = false;

    void Start()
    {
        StartCoroutine(_typing());
    }

    IEnumerator _typing()
    {
        for (int i = 0; i <= m_text.Length; i++)
        {
            if (text_cut == true)
            {
                break;
            }
            tx.text = m_text.Substring(0, i);

            yield return new WaitForSeconds(0.1f);
        }

        tx.text = m_text;
        text_full = true;
        Click.gameObject.SetActive(true); //클릭 버튼 보임
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            text_cut = true;
            StartCoroutine(_typing());
        }
    }
}
