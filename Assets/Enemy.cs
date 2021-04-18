using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public Vector3 target;
    private Vector3 start;
    public float enemySpeed;
    private bool movingToTarget;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        movingToTarget = true;

    }

    // Update is called once per frame
    void Update()
    {
        if(movingToTarget)
        {
            transform.position = Vector3.MoveTowards(transform.position, target, enemySpeed*Time.deltaTime);
            if(transform.position == target)
            {
                movingToTarget = false;
            }
        }

        else
        {
            transform.position = Vector3.MoveTowards(transform.position, start, enemySpeed*Time.deltaTime);
            if(transform.position == start)
            {
                movingToTarget = true;
            }
        }
    }
}
