using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float moveSpeed = 0.005f;
    public float jumpPower = 300f;

    public GameManager gameManager;
    private void Update()
    {
        transform.Translate(Vector3.right * moveSpeed);
    }

    public void Jump()
    {
        GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpPower);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.transform.name == "WinCollider")
        {
            gameManager.Win();
        }
        else if (other.transform.name == "LoseCollider")
        {
            gameManager.Lose();
        }
    }
}
