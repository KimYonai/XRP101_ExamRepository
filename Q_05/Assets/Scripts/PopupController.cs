using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopupController : MonoBehaviour
{
    [SerializeField] private float _deactiveTime;
    private WaitForSeconds _wait;
    private Button _popupButton;

    [SerializeField] private GameObject _popup;

    private void Awake()
    {
        Init();
    }

    private void Init()
    {
        _wait = new WaitForSeconds(_deactiveTime);
        _popupButton = GetComponent<Button>();
        SubscribeEvent();
    }

    private void SubscribeEvent()
    {
        _popupButton.onClick.AddListener(Activate);
    }

    private void Activate()
    {
        StartCoroutine(DeactivateRoutine());
        _popup.gameObject.SetActive(true);
        
        GameManager.Instance.Pause();
    }

    private void Deactivate()
    {
        GameManager.Instance.Resume();
        _popup.gameObject.SetActive(false);
    }

    private IEnumerator DeactivateRoutine()     // 해당 코루틴을 다시 작동시키는 부분에서 진행이 막혔습니다.
    {                                           // bool 변수를 여럿 추가하고 bool 변수의 값이 변할때마다 체크하게 하려는 시도도 해봤지만
        yield return _wait;                     // 제대로 동작하지 않아 막혔습니다.    
        Deactivate();
    }
}
