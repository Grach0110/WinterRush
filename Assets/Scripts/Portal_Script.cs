using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Портал
/// </summary>
public class Portal_Script : MonoBehaviour
{
    /// <summary>
    /// Точка появления
    /// </summary>
    public GameObject pointSpawn;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            collision.gameObject.transform.position = pointSpawn.transform.position;
        }
    }
}