using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampScript : MonoBehaviour
{
    public GameManager gameManager;
    public bool isOn;

    public void TurnOn()
    {
        Debug.Log("Lamp is ON");

        if(isOn == false)
        {
            isOn = true;
            AddLamp(true);
            SetOn(true);
        }
        else
        {
            isOn = false;
            AddLamp(false);
            SetOn(false);
        }
    }

    public void AddLamp(bool cond)
    {
        Debug.Log("Lamp sent to Game Manager " + gameObject.name);
        gameManager.AddLampToList(this.gameObject, cond);
    }

    public void SetOn(bool cond)
    {
        this.gameObject.SetActive(cond);
    }
}
