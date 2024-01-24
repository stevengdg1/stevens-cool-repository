using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScript : MonoBehaviour
{

    private float scrollSpeed = 1f;
    private float resetYPosition = -13.9f;
    private Vector3 startPosition = new Vector3(0, 0, 0);

    private void Start()
    {
        startPosition = transform.position;
    }

    private void Update()
    {
        transform.position += new Vector3(0, -1, 0) * Time.deltaTime * scrollSpeed;

        if (transform.position.y < resetYPosition )
        {
            transform.position = startPosition;
        }
    }

}
