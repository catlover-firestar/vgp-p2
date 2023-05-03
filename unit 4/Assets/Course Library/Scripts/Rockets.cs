using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rockets : MonoBehaviour
{
    private Transform target;
    private float speed = 15;
    private bool homing;
    private float rocketStrength = 15;
    private float aliveTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Fire(Transform newTarget)
    {
        target = homingTarget;
        homing = true;
        Destroy(gameObject, aliveTime);
    }
}
