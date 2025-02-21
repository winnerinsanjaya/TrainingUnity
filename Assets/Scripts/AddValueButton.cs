using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValueButton : MonoBehaviour
{
    public TextChanger textChanger;


    public void AddButton(int amount)
    {
        AudioPlayer.instance.PlaySFX(0);
        textChanger.AddValue(amount);
    }
}
