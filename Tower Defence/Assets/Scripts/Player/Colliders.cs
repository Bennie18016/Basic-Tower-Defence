using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colliders : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Enemy")
        {
            GameObject e = other.gameObject;
            Destroy(e);
            Debug.Log("Test");
        }
    }

}
