using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Animation : MonoBehaviour
{
    [SerializeField] private GameObject Big;
    [SerializeField] private Button Back;
    [SerializeField] private SpriteRenderer Finish;
    [SerializeField] private Text Stat;
    [SerializeField] private GameObject Panel;

    public void TR_Finish()//수련 완료 했을 때 뜨는 알림창 함수
    {
        Big.gameObject.SetActive(true);

        Stat.text = "현재 " + GameManager.Instance.stat.currentweeks + "주" + "\n" + "근력 " + GameManager.Instance.stat.CurrentMslStr + " / " + "도력 " + GameManager.Instance.stat.CurrentMoralStr + " / " + "재력 "
                    + GameManager.Instance.stat.CurrentWealth + " / " + "호감도 " + GameManager.Instance.stat.CurrentFavorability;
    }

    public void TR_HIDE() //완료창 뒤로가기 눌렀을 때 숨겨짐
    {
        Big.gameObject.SetActive(false);
        Panel.gameObject.SetActive(false);
    }

    float time;
    public float checkTime;
    public GameObject mslstr_Ani; //근력 애니
    public GameObject moral_Ani; //도력 애니
    public GameObject etc_Ani; //기타 애니

    private void Start()
    {
        time = 0;
        checkTime = 1.5f;
    }
    void Update()
    {
        if (mslstr_Ani.activeSelf == true) //근력 애니메이션이 활성화 돼있으면
        {
            time += Time.deltaTime;
            Debug.Log(time);
            if (time > checkTime)
            {
                mslstr_Ani.gameObject.SetActive(false);

                TR_Finish();
                training.isClick_Msl = false;
                time = 0.0f;
            }
        }
        else if (moral_Ani.activeSelf == true) //도력 애니메이션이 활성화 돼있으면
        {
            time += Time.deltaTime;
            Debug.Log(time);
            if (time > checkTime)
            {
                moral_Ani.gameObject.SetActive(false);

                TR_Finish();
                training.isClick_Moral = false;
                time = 0.0f;
            }
        }
        else if (etc_Ani.activeSelf == true)
        {
            time += Time.deltaTime;
            Debug.Log(time);
            if (time > checkTime)
            {
                etc_Ani.gameObject.SetActive(false);

                TR_Finish();
                training.isClick_Etc = false;
                time = 0.0f;
            }
        }
    }
}
