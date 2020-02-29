using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_props : Triggers
{
    public override void Interact()
    {
        this.GetComponent<Animator>().SetBool("interacting",true);
    }
}
