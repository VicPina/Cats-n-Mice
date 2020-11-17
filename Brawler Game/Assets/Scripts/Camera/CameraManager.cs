using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    Camera mainCam;
    void Awake()
    {
        mainCam = Camera.main;
    }
}
