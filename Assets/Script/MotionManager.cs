using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionManager : MonoBehaviour
{
    const float force = 15;
    const float borne = 14.5f;

    public float vitesse = 0.1f; 
    public float speed;

    private static float[] linesPositions = { -6, -3, 0, 3, 6 };
    private int oldLine = 2;
    private int lineNumber = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = vitesse * Time.deltaTime;

        transform.Translate(0, 0, speed);

        if (Input.GetKeyDown(KeyCode.LeftArrow) && (transform.position.x > -borne)) {
            if (lineNumber != 0) lineNumber--;
         
       
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) && (transform.position.x < borne))
        {
            if (lineNumber != 4) lineNumber++;
        }


        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<Rigidbody>().AddForce(0, force, 0);
        }
        //déplacement doux
        if (oldLine != lineNumber)
        {
            transform.Translate(Mathf.Sign(lineNumber - oldLine) * speed, 0, 0);
            print(transform.position.x - linesPositions[lineNumber]) ;
            if (Mathf.Abs(transform.position.x - linesPositions[lineNumber]) < 0.25f)
            {
                oldLine = lineNumber;
            }
        }
    }
}
