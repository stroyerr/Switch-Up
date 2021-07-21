using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class dialogue
{

    [TextArea(1, 2)]
    public string name;

    [TextArea(1, 2)]
    public string[] chars;

    [TextArea(3, 10)]
    public string[] sentence;

}