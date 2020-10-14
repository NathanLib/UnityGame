using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManagement : MonoBehaviour
{
    public generateObject monObjetGenere;

    const string obstacleTag = "Ennemy";
    const string piecesTag = "Pieces";

    const string sphereName = "Sphere";
    const string capsuleName = "Capsule";
    const string cylinderName = "Cylinder";

    private int points = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        string name = collision.transform.name;
        string tag = collision.transform.tag;

        if (tag == obstacleTag)
        {
            print("Colonel! Collision detected with an obstacle! What do we do?");

            //Gestion des points
            points--;
            print("Nombre de points : " + points);
        }
        else if (tag == piecesTag)
        {
            print("Colonel! We find something new to collect!");

            if (name == sphereName)
            {
                print("Arghhh, it's a sphere. Always them!");
            }
            else if (name == capsuleName)
            {
                print("Ohhh, it's a capsule! Do we keep it?");
            }
            else if (name == cylinderName)
            {
                print("Wow, it's a cylinder! This object is so rare!");
            }

            monObjetGenere.piecesList.Remove(collision.gameObject);
            print("Nombre d'objet dans la liste : " + monObjetGenere.piecesList.Count);
            
            Destroy(collision.gameObject);
            //collision.gameObject.SetActive(false);

            //Gestion des points
            points++;
            print("Nombre de points : " + points);
        }
    }

}
