using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitManager : MonoBehaviour
{
    public void Winner(string player)
    {
        GetComponent<ScreenManager>().GoToScene("Menu");
    }
}
