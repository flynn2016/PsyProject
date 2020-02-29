using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_umb : Triggers
{
    public Transform Player_umb;
    public override void Interact()
    {
        Player_umb.GetComponent<MeshRenderer>().enabled = true;
        this.gameObject.SetActive(false);
    }
}
