﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Data_input : MonoBehaviour
{
    public Text txtUserName;
    // Start is called before the first frame update
    public void ShowGreetings()
    {
        Debug.Log($"Hola {txtUserName.text}");
    }
}
