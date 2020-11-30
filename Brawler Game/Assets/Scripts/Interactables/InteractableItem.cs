using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableItem : MonoBehaviour
{
    public bool pickable, ladder, gap, mechanism, catapult;
    public AudioClip sfx;
    public GameObject affectePlayer, itemPrefab, affectedMechanism;
    private int task;
    
    private void Awake()
    {
        if (ladder) { task = 0; }
        if (gap) { task = 1; }
        if (mechanism) { task = 2; }
        if (catapult) { task = 3; }
    }

    public void Interaction()
    {
        switch (task)
        {
            case 0:
                Ladder();
                break;
            case 1:
                Gap();
                break;
            case 2:
                Mechanism();
                break;
            case 3:
                Catapult();
                break;
        }
    }
    public void Ladder()
    {
        Vector3 newPosition = new Vector3(affectePlayer.transform.position.x + 0.5f, affectePlayer.transform.position.y + 2f, affectePlayer.transform.position.z + 0.5f);
        affectePlayer.transform.position = newPosition;
    }
    public void Gap()
    {
        Vector3 newPosition = new Vector3(affectePlayer.transform.position.x - 1.85f, affectePlayer.transform.position.y, affectePlayer.transform.position.z + 1.85f);
        affectePlayer.transform.position = newPosition;
    }
    public void Mechanism()
    {

    }
    public void Catapult()
    {
        Vector3 newPosition = new Vector3(affectePlayer.transform.position.x - 1f, affectePlayer.transform.position.y, affectePlayer.transform.position.z + 5f);
        affectePlayer.transform.position = newPosition;
    }
}
