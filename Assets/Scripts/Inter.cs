using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inter : MonoBehaviour
{

    public enum InteractionType { Door, Button, Pickup }
    public InteractionType type;

    public void Activate()
    {
        Debug.Log(this.name + " was actiavted");
    }
}