﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public void Winner()
    {
        GetComponent<ScreenManager>().GoToScene("Menu");
    }
}
