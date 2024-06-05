using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plateform : MonoBehaviour
{
    Vector3 movement;
    GameObject topLine;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        movement.y = speed;
        topLine = GameObject.Find("TopLine");
    }

    // Update is called once per frame
    void Update()
    {
        MovePlateform();
    }

    void MovePlateform()
    {
        transform.position += movement * Time.deltaTime;

        if (transform.position.y >= topLine.transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
