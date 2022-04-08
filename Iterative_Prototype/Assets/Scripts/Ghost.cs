using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghost : MonoBehaviour
{
    private Collider collide;
    private MeshRenderer mesh;
    public float triggerTime = 2.5f;

    bool flipFlop;
    
    void Start()
    {
        collide = GetComponent<BoxCollider>();
        mesh = GetComponent<MeshRenderer>();
        
        Invoke("Hide", triggerTime);
    }

    void Hide()
    {
        collide.enabled = flipFlop;
        mesh.enabled = flipFlop;
        flipFlop = !flipFlop;
        
        Invoke("Hide", triggerTime);
    }
}
 