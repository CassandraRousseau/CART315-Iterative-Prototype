using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private GameSettings gs;
    // Start is called before the first frame update
    void Start()
    {
        gs = GameObject.FindGameObjectWithTag("GS").GetComponent<GameSettings>();
        transform.position = gs.lastCheckPointPos;
    }

    // Update is called once per frame
    void Update()
    {
        if()
    }
}
