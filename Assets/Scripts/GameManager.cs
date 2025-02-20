using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;

public enum Flow {Flow1, Flow2, Flow3, Flow4, Flow5}


public class GameManager : MonoBehaviour
{
    public Flow currentFlow;

    public List<GameObject> onLamp;

    public TextContainer textContainer;

    public TMP_Text textFlow;

    public GameObject winScreen;

    public void AddLampToList(GameObject lamp, bool cond)
    {
        if(currentFlow != Flow.Flow1)
        {
            return;
        }

        if (cond)
        {
            onLamp.Add(lamp);
        }
        else
        {
            onLamp.Remove(lamp);
        }

        LampChecker();
    }

    public void LampChecker()
    {
        if(onLamp.Count >= 5 && currentFlow == Flow.Flow1)
        {
            Debug.Log("All Lamp is Finished");

            ToNextFlow();
        }
    }

    public void ToNextFlow()
    {
        Array enumValues = Enum.GetValues(typeof(Flow)); //Buat Array berdasarkan enum Flow

        int currentIndex = Array.IndexOf(enumValues, currentFlow);//mencari index currentFlow di enumValues

        int nextIndex = (currentIndex + 1); //Set Next Index

        
        if(nextIndex < enumValues.Length) //jika next index tidak  melebihi enumValues Lenght
        {
            Flow nextFlow = (Flow)enumValues.GetValue(nextIndex); //Ambil data untuk next flow dari next Index;
            currentFlow = nextFlow;
            ShowText();
        }

        if(nextIndex >= enumValues.Length) // jika next index sudah sama kaya jumlah Array
        {
            textFlow.gameObject.SetActive(false);
            winScreen.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            Debug.Log("Game is Finished");
        }
    }


    public void ShowText()
    {
        Array enumValues = Enum.GetValues(typeof(Flow)); //Buat Array berdasarkan enum Flow

        int currentIndex = Array.IndexOf(enumValues, currentFlow);//mencari index currentFlow di enumValues

        string text = textContainer.GetText(currentIndex);

        Debug.Log(text);
        textFlow.text = text;
    }

    private void Start()
    {
        ShowText();
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
