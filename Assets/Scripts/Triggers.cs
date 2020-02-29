using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Triggers : MonoBehaviour
{
    public bool interacted;
    public abstract void Interact();
}
