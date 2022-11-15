using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private GameSettings gs;

    private void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GS").GetComponent<GameSettings>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") {
            gs.lastCheckpointPos = transform.position;
        }

    }
  
}
