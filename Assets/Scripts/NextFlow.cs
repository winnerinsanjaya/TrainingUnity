using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class NextFlow : MonoBehaviour
{
    public Flow flowState;

    public GameManager gameManager;

    public bool FlowChecker()
    {
        return gameManager.currentFlow == flowState; 
    }

    public UnityEvent OnClick;

    public bool canClickTwoTimes;

    public bool canClick;

    private bool alreadyClicked;

    public void OnMouseDown()
    {
        if (!canClick || !FlowChecker())
        {
            return;
        }

        if (!alreadyClicked)
        {
            alreadyClicked = true;
            gameManager.ToNextFlow();

            AudioPlayer.instance.PlaySFX(1);
            Destroy(transform.parent.gameObject);
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
