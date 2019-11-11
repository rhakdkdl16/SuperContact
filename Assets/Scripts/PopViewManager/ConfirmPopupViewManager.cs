using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfirmPopupViewManager : PopupViewManager
{
    public delegate void ConfirmPopupViewManagerDelegate();
    public ConfirmPopupViewManagerDelegate confirmPopupViewManagerDelegate;
    Text text;
    private void Start()
    {
        text = GetComponent<Text>();
        
    }

    public void OnClickOK()
    {
        confirmPopupViewManagerDelegate?.Invoke();
        
        // 창 닫기
        Close();
    }

    public void OnClickCancel()
    {
        Close();
    }
}
