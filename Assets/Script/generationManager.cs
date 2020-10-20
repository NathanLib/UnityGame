using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generationManager : MonoBehaviour
{

    public Transform scenneryToDuplicate;
    int nbGeneratedScennery = 0;
    float scennerySize = 50;

    public Transform sphereModel, cylinderModel, capsuleModel, ennemyModel;
    private Transform[] piecesModel;

    // Start is called before the first frame update 
    void Start()
    {
        piecesModel = new Transform[5];
        piecesGeneration();

        //RandomPiecesGeneration(sphereModel, 3, 5);
        //RandomPiecesGeneration(cylinderModel, 2, 3);
        //RandomPiecesGeneration(capsuleModel, 1, 2);

        print("taille " + piecesModel.Length);
    }

    private void piecesGeneration()
    {
        float posX = Random.Range(-8, 8);

        float posZrelatif = Random.Range(-scennerySize / 2, scennerySize / 2);
        float posZ = nbGeneratedScennery * scennerySize + posZrelatif;

        for (int i = 0; i < piecesModel.Length; i++)
        {
            piecesModel[i] = RandomPiecesGeneration(sphereModel, posX, posZ + (i * 10));
            //piecesModel[i].position.z = posZ * i;
            print($"Piece : {piecesModel[i]}");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 10 + nbGeneratedScennery*scennerySize)
        {
            nbGeneratedScennery++;
            print($"Nouveau décors généré, no {nbGeneratedScennery}");

            Transform createdScennery = Instantiate(scenneryToDuplicate);

            Vector3 tempPosition = createdScennery.position;
            tempPosition.z += nbGeneratedScennery * scennerySize;
            createdScennery.position = tempPosition;

            piecesGeneration();

            //RandomPiecesGeneration(sphereModel, 3, 5);
            //RandomPiecesGeneration(cylinderModel, 2, 3);
            //RandomPiecesGeneration(capsuleModel, 1, 2);

            RandomEnemiesGeneration(ennemyModel);

        }
    }

    private Transform RandomPiecesGeneration(Transform model, float posX, float posZ)
    {
        //int nbMin, int nbMax
        //int nbObject = Random.Range(nbMin, nbMax);

        Transform newObject = Instantiate(model);

        float posZrelatif = Random.Range(-scennerySize / 2, scennerySize / 2);
        //float posZ = nbGeneratedScennery * scennerySize + posZrelatif;

        newObject.position = new Vector3(posX, newObject.position.y, posZ);

        return newObject;
    }

    private void RandomEnemiesGeneration(Transform model)
    {
        for (int i = 0; i < 2; i++)
        {
            Transform newObject = Instantiate(model);

            float posX = Random.Range(-8, 8); //random pos X
            float posZrelatif = Random.Range(0, scennerySize);
            float posZ = nbGeneratedScennery * scennerySize + posZrelatif;

            newObject.position = new Vector3(posX, 2, posZ); //newObject.position.y
            newObject.transform.Translate(Time.deltaTime * 20 * Vector3.forward);
        }
    }
}
