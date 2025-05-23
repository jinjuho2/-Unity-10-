using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balsadae : MonoBehaviour
{


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.rigidbody.AddForce(Vector3.up * 50, ForceMode.Impulse);
        }
    }

    




}
