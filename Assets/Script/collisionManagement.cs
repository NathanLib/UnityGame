using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisionManagement : MonoBehaviour
{
    //public generateObject myGeneratedObject;
    const string obstacleTag = "Ennemy";
    const string piecesTag = "Pieces";

    const string sphereName = "Sphere";
    const string capsuleName = "Capsule";
    const string cylinderName = "Cylinder";

    const int obstaclePoints = 5;
    const int piecesPoints = 10;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        //this.myGeneratedObject = GetComponent<>;
    }

    // Update is called once per frame
    void Update()
    {

    }

    // use trigger for pieces and collision for obstacle

    //When the character collides with the pieces
    private void OnTriggerEnter(Collider collider)
    {
        string name = collider.transform.name;
        string tag = collider.transform.tag;

        if (tag == obstacleTag)
        {
            print("Colonel! Collision detected with an obstacle! What do we do?");

            //Gestion des points
            this.score -= obstaclePoints;
        }
        else if (tag == piecesTag)
        {
            switch (name)
            {
                case sphereName: print("Arghhh, it's a sphere. Always them!"); break;
                case capsuleName: print("Ohhh, it's a capsule! Do we keep it?"); break;
                case cylinderName: print("Wow, it's a cylinder! This object is so rare!"); break;
            }

            //Gestion des points
            this.score += piecesPoints;

            //print("Before : " + this.myGeneratedObject.piecesList.Count);
            //this.myGeneratedObject.piecesList.Remove(collider.gameObject);

            Destroy(collider.gameObject);
            //collider.gameObject.SetActive(false);
        }

        print("Score : " + this.score);
    }

    //When the character exits the collision
    private void OnTriggerExit(Collider collider)
    {
        
    }

    //void OnCollisionEnter(Collision collision)
    //{
    //    string name = collision.transform.name;
    //    string tag = collision.transform.tag;

    //    if (tag == obstacleTag)
    //    {
    //        print("Colonel! Collision detected with an obstacle! What do we do?");

    //        //Gestion des points
    //        points--;
    //        print("Nombre de points : " + points);
    //    }
    //    else if (tag == piecesTag)
    //    {
    //        print("Colonel! We find something new to collect!");

    //        if (name == sphereName)
    //        {
    //            print("Arghhh, it's a sphere. Always them!");
    //        }
    //        else if (name == capsuleName)
    //        {
    //            print("Ohhh, it's a capsule! Do we keep it?");
    //        }
    //        else if (name == cylinderName)
    //        {
    //            print("Wow, it's a cylinder! This object is so rare!");
    //        }

    //        monObjetGenere.piecesList.Remove(collision.gameObject);
    //        print("Nombre d'objet dans la liste : " + monObjetGenere.piecesList.Count);

    //        Destroy(collision.gameObject);
    //        //collision.gameObject.SetActive(false);

    //        //Gestion des points
    //        points++;
    //        print("Nombre de points : " + points);
    //    }
    //}

}
