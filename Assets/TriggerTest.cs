using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour
{
    public GameObject lampu;

    public bool isPlayerOnArea;

    public GameObject canvasText;



    private void Start()
    {
        canvasText.SetActive(false);
        lampu.SetActive(false);
    }


    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            canvasText.SetActive(true);
            isPlayerOnArea = true;
            Debug.Log("Player Masuk");
        }
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
            Debug.Log("Player Stay");
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            canvasText.SetActive(false);
            isPlayerOnArea = false;            
            Debug.Log("Player Keluar");
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnOffButton();
        }
    }

    public void OnOffButton()
    {
        if (isPlayerOnArea)
        {
            if (lampu.active)
            {
                lampu.SetActive(false);
            }
            else
            {
                lampu.SetActive(true);
            }
        }
    }
}
