using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Walk_Pattern : MonoBehaviour
{
    GameObject target;
    NavMeshAgent enemy;

    private void Start()
    {
        target = GameObject.FindGameObjectWithTag("Target");
        enemy = gameObject.GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        enemy.SetDestination(target.transform.position);
    }
}
