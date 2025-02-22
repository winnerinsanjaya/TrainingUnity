using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerTest : MonoBehaviour
{

    public bool isPlayerOnArea;

    public GameObject canvasText;

    public GameObject canvasParent;


    public UnityEvent triggerEvent;
    public UnityEvent triggerEventOnExit;
    public UnityEvent triggerEventOnEnter;


    private void Start()
    {
        canvasText.SetActive(false);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canvasText.SetActive(true);
            isPlayerOnArea = true;
            //Debug.Log("Player Masuk");
            triggerEventOnEnter.Invoke();

            SetCanvas(other.transform);
        }
    }

    public void OnTriggerStay(Collider other)
    {
       // if (other.tag == "Player")
            //Debug.Log("Player Stay");
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasText.SetActive(false);
            isPlayerOnArea = false;
            triggerEventOnExit.Invoke();
            //Debug.Log("Player Keluar");
        }
    }

    private void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            OnOffButton();
        }
    }

    public void OnOffButton()
    {
        if (isPlayerOnArea)
        {
            AudioPlayer.instance.PlaySFX(2);
            triggerEvent.Invoke();
        }
    }


    public void SetCanvas(Transform player)
    {
        canvasParent.transform.LookAt(player);
    }
}
