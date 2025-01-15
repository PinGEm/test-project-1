using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicMovement : MonoBehaviour
{
    [SerializeField] private float PlayerSpeed;
    [SerializeField] private float JumpForce;
    [SerializeField] private GameObject takeABreakMenu;
    private bool hasJumped;
    private Rigidbody rb;

    // Take a Break
    private bool TakeABreakOn;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            this.transform.position = new Vector3(transform.position.x + (-PlayerSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.position = new Vector3(transform.position.x + (PlayerSpeed * Time.deltaTime), transform.position.y, transform.position.z);
        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (PlayerSpeed * Time.deltaTime));
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + (-PlayerSpeed * Time.deltaTime));
        }

        if (Input.GetKeyDown(KeyCode.Space) && hasJumped == false)
        {
            hasJumped = true;
            rb.AddForce(Vector3.up * (JumpForce), ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TakeABreak();
        }
    }

    private void TakeABreak()
    {
        if (TakeABreakOn == false)
        {
            Time.timeScale = 0f;
            TakeABreakOn = true;
            takeABreakMenu.SetActive(true); 
        }
        else
        {
            TakeABreakOn = false;
            Time.timeScale = 1f;
            takeABreakMenu.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        hasJumped = false;
    }
}
