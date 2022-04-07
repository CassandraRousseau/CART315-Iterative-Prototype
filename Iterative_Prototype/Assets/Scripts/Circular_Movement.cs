using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circular_Movement : MonoBehaviour
{
    public GameObject Player;
    [SerializeField] Transform rotationCenter;

    [SerializeField] float rotationRadius = 2f, angularSpeed = 2f;

    float posX, posY, angle = 0f;
    float posZ = 0f;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = transform;
        }

    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            Player.transform.parent = null;
        }

    }
    // Update is called once per frame
    void Update()
    {
        posX = rotationCenter.position.x + Mathf.Cos(angle) * rotationRadius;
        posY = rotationCenter.position.y + Mathf.Sin(angle) * rotationRadius;
        transform.position = new Vector3(posX, posY, posZ);
        angle = angle + Time.deltaTime * angularSpeed;

        if (angle >= 360f)
        {

            angle = 0f;
        }
    }
}
