using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticValue : MonoBehaviour {
    public static string controlType = "keyboard";

    public void ChooseController()
    {
        Debug.Log(controlType);
        controlType = "acceleromter";
    }

}
