using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManagerEvents : MonoBehaviour
{
    public GameObject[] spwanPoint; 
    public Material[] playerColour;

    public void OnJoin(PlayerInput player)
    {
        for(int i = 0; i < 4; i++)
        {
            player.gameObject.transform.position = spwanPoint[player.playerIndex].transform.position;

            player.gameObject.GetComponent<PlayerController>().SetMaterial(playerColour[player.playerIndex]);
        }
    }
}
