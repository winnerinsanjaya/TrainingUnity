using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LightSwitch : MonoBehaviour
{
    public UnityEvent OnClick;

    public bool canClickTwoTimes;

    public bool canClick;

    private bool alreadyClicked;

    public void OnMouseDown()
    {
        if (!canClick)
        {
            return;
        }

        if (canClickTwoTimes)
        {
            AudioPlayer.instance.PlaySFX(2);
            OnClick.Invoke();
        }
        else
        {
            if (!alreadyClicked)
            {
                alreadyClicked = true;

                AudioPlayer.instance.PlaySFX(2);
                OnClick.Invoke();
            }
        }
    }


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnMouseDown();
        }
    }



    public void SetCanClick(bool cond)
    {
        canClick = cond;
    }
}
