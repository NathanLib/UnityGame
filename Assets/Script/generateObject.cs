using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObject : MonoBehaviour
{
    //    public List<GameObject> piecesList = new List<GameObject>();
    //    private string tagToAdd = "Pieces";


    void Start() { }

    void Update() {
        transform.Translate(0, 0, -0.15f);
    }
    //    // Start is called before the first frame update
    //    void Start()
    //    {

    //        foreach (GameObject piece in GameObject.FindGameObjectsWithTag(tagToAdd))
    //        {
    //            piecesList.Add(piece);
    //        }

    //        print("Nombre de pièces : " + piecesList.Count);
    //    }

    //    // Update is called once per frame
    //    void Update()
    //    {
    //        print("Pos Z : " + MaxPosZ(piecesList));

    //        if (piecesList.Count < 3)
    //        {
    //            // faire fonction get max z
    //            //float posZLastObject = piecesList[piecesList.Count - 1].transform.position.z;

    //            print("Pos Z : " + MaxPosZ(piecesList));

    //            GameObject piece = GameObject.CreatePrimitive(PrimitiveType.Sphere);
    //            piece.transform.position = new Vector3(0, 0.75f, MaxPosZ(piecesList) + 20f);
    //            piece.gameObject.tag = "Pieces";
    //            piece.GetComponent<SphereCollider>().isTrigger = true;

    //            piecesList.Add(piece);
    //    }
    //}

    //    private float MaxPosZ(List<GameObject> piecesList)
    //    {
    //        // Inspiration from: https://forum.unity.com/threads/find-game-object-with-highest-y-value.325408/

    //        float maxPosZ = 0;

    //        //start with a value that could never be higher than all my objects
    //        float highestPosZ = -9999f;

    //        foreach (GameObject piece in piecesList)
    //        {
    //            float currentPosZ = piece.transform.position.z;
    //            if (currentPosZ > highestPosZ) highestPosZ = currentPosZ;
    //        }

    //        return maxPosZ;
    //    }
}
