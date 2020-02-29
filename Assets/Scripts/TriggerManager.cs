using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public Transform text;
    public Transform text_exit;
    private bool interacting;
    public Transform interactables;

    public void Update()
    {
        text_exit.position = new Vector3(this.transform.position.x, -0.5f, this.transform.position.z);
        text.position = new Vector3(this.transform.position.x, -0.5f, this.transform.position.z);
        if (Input.GetKeyDown(KeyCode.E))
        {
            interacting = true;
        }
    }
    public void OnTriggerStay(Collider col)
    {
        if(col.name == "CropTrigger"|| col.name == "Chicken_farm"||col.name=="Umbrella"
            )
        {
            if (!col.GetComponent<Triggers>().interacted)
            {
                text.GetComponent<MeshRenderer>().enabled = true;
            }
            if (interacting)
            {
                col.GetComponent<Triggers>().Interact();
                text.GetComponent<MeshRenderer>().enabled = false;
                interacting = false;
            }
        }

        if (col.name == "Gate")
        {
            bool temp = true;
            foreach (Transform child in interactables)
            {
                temp &= child.GetComponent<Triggers>().interacted;
            }
            if (temp)
            {
                text_exit.GetComponent<MeshRenderer>().enabled = true;
                if (interacting)
                {
                    Debug.Log("Exit");
                    this.transform.GetComponent<PlayerController>().enabled = false;
                    Application.Quit();
                }
            }
        }
    }

    public void OnTriggerExit(Collider col)
    {
        text.GetComponent<MeshRenderer>().enabled = false;
        if(col.name == "Gate")
        text_exit.GetComponent<MeshRenderer>().enabled = false;
    }
}
