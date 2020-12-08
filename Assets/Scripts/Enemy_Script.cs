using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Script : MonoBehaviour
{
    GameObject targetPos;
    public float speed;

    private void Update()
    {
        if (targetPos == null)
        {
            NewTarget();
        }

        transform.position = Vector3.MoveTowards(transform.position, targetPos.transform.position, speed * Time.deltaTime);
    }

    void NewTarget()
    {
        targetPos = GameObject.FindGameObjectWithTag("Gift");
    }
}