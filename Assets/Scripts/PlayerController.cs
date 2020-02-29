using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Vector3 inputMovement;

    public float lookSpeed = 10;
    public Animator m_animator;
    public Rigidbody m_rb;

    // Start is called before the first frame update
    void Start()
    {
        m_rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        inputMovement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        if (inputMovement == Vector3.zero)
        {
            m_animator.SetBool("running", false);
        }
        else
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(inputMovement), lookSpeed*Time.deltaTime);
            m_animator.SetBool("running", true);
        }
        m_rb.velocity = inputMovement.normalized * moveSpeed;
    }
}
