using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValueButton : MonoBehaviour
{
    public TextChanger textChanger;


    public void AddButton(int amount)
    {
        textChanger.AddValue(amount);
    }
}
