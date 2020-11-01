using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionManager : MonoBehaviour
{
    const float force = 15;
    const float borne = 14.5f;

    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed);

        if (Input.GetKey(KeyCode.LeftArrow) && (transform.position.x > -borne)) {
            transform.Translate(-speed, 0, 0);
        }

        if (Input.GetKey(KeyCode.RightArrow) && (transform.position.x < borne))
        {
            transform.Translate(speed, 0, 0);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, force, 0);
        }
    }
}
