using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoatController : MonoBehaviour
{
    public GameObject tmpro;
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if(other.tag=="Player")
        {
            tmpro.GetComponent<TextMeshPro>().enabled = true;

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            tmpro.GetComponent<TextMeshPro>().enabled = false;

        }
    }
}
