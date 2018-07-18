using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticValue : MonoBehaviour {
    public static string controlType = "screen";

    public void ChooseAcceleometer()
    {
        controlType = "acceleromter";
    }

    public void ChooseScreen()
    {
        controlType = "screen";
    }

    public void ChooseKeyboard()
    {
        controlType = "keyboard";
    }

}
