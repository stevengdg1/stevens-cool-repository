using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinusoidalPathScript : MonoBehaviour
{

    [SerializeField] private float frequency = 15f;
    [SerializeField] private float magnitude = 15f;

    private void Update()
    {
        float sinCalcs = Mathf.Sin(7 * Time.time * frequency) + Mathf.Cos(4 * Time.time * frequency);
        transform.position += transform.right * sinCalcs * magnitude * Time.deltaTime;
    }

}
