using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObject : MonoBehaviour
{
    public List<GameObject> piecesList = new List<GameObject>();
    private string tagToAdd = "Pieces";



    // Start is called before the first frame update
    void Start()
    {

        foreach (GameObject piece in GameObject.FindGameObjectsWithTag(tagToAdd))
        {
            piecesList.Add(piece);
        }

        print("Nombre de pièces : " + piecesList.Count);
    }

    // Update is called once per frame
    void Update()
    {
        if (piecesList.Count < 3)
        {
            // faire fonction get max z
            float posZLastObject = piecesList[piecesList.Count - 1].transform.position.z;

            GameObject piece = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            piece.transform.position = new Vector3(0, 0.75f, posZLastObject + 20f);
            piece.gameObject.tag = "Pieces";
            piece.GetComponent<SphereCollider>().isTrigger = true;

            piecesList.Add(piece);
        }
    }
}
