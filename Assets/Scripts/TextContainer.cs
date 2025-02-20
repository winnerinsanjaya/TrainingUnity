using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextContainer : MonoBehaviour
{
    [TextArea]
    public List<string> textList;

    public string GetText(int index)
    {
        return textList[index];
    }



    private void Start()
    {
        //Debug.Log(GetText(2));
    }
}
