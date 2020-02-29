using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_coop : Triggers
{
    public Transform chickens;
    public void Start()
    {
       
    }

    public override void Interact()
    {
        foreach (Transform chicken in chickens)
        {
            chicken.GetComponent<Animator>().SetBool("isfeeding",true);
        }
        interacted = true;
    }
}
