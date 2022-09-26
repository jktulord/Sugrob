using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewPortControl : MonoBehaviour
{
    Scrollbar scrollbar;
    public bool ScrollingDown;
    // Start is called before the first frame update
    void Start()
    {
        scrollbar = GetComponent<Scrollbar>();
        if (ScrollingDown)
            scrollbar.value -= Time.deltaTime;
    }

    public void ScrollToBottom(){
        scrollbar.value = 0;
        //scrollbar.SetValueWithoutNotify(0);
    }

    public void ScrollToTop(){
        scrollbar.value = 1;
        //scrollbar.SetValueWithoutNotify(1);
    }

}
