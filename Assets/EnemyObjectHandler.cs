using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyObjectHandler : MonoBehaviour
{
    public Rigidbody enemyObject;
    public float forwardForce = 100f;
    // Start is called before the first frame update
    void Start()
    {        
        enemyObject.AddForce(0,0,-forwardForce * 10 * Time.deltaTime, ForceMode.VelocityChange);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        enemyObject.AddForce(0,0,-forwardForce * Time.deltaTime);
        Debug.Log(Time.frameCount);
    }
}
