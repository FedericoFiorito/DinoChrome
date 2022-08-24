using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float velocityMax;
    public float velocityMin;

    private float velocity;

    // Start is called before the first frame update
    void Start()
    {
        velocity = Random.Range(velocityMin, velocityMax);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * velocity * Time.deltaTime);
    }
}
