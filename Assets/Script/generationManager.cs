using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generationManager : MonoBehaviour
{

    public Transform decorsToDuplicate;
    int nbGeneratedDecors = 0;
    float decorsSize = 50;

    public Transform sphereModel, cylinderModel, capsuleModel, ennemyModel;

    // Start is called before the first frame update
    void Start()
    {
        RandomPiecesGeneration(sphereModel, 3, 5);
        RandomPiecesGeneration(cylinderModel, 2, 3);
        RandomPiecesGeneration(capsuleModel, 1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 10 + nbGeneratedDecors*decorsSize)
        {
            nbGeneratedDecors++;
            print($"Nouveau décors généré, no {nbGeneratedDecors}");

            Transform createdDecors = Instantiate(decorsToDuplicate);

            Vector3 tempPosition = createdDecors.position;
            tempPosition.z += nbGeneratedDecors * decorsSize;
            createdDecors.position = tempPosition;

            RandomPiecesGeneration(sphereModel, 3, 5);
            RandomPiecesGeneration(cylinderModel, 2, 3);
            RandomPiecesGeneration(capsuleModel, 1, 2);

            RandomEnemiesGeneration(ennemyModel);

        }
    }

    private void RandomPiecesGeneration(Transform model, int nbMin, int nbMax)
    {
        int nbObject = Random.Range(nbMin, nbMax);

        for (int i = 0; i < nbObject; i++)
        {
            Transform newObject = Instantiate(model);

            float posX = Random.Range(-8, 8); //random pos X
            float posZrelatif = Random.Range(-decorsSize / 2, decorsSize / 2);
            float posZ = nbGeneratedDecors * decorsSize + posZrelatif;

            newObject.position = new Vector3(posX, newObject.position.y, posZ);
        }
    }

    private void RandomEnemiesGeneration(Transform model)
    {
        for (int i = 0; i < 2; i++)
        {
            Transform newObject = Instantiate(model);

            float posX = Random.Range(-8, 8); //random pos X
            float posZrelatif = Random.Range(0, decorsSize);
            float posZ = nbGeneratedDecors * decorsSize + posZrelatif;

            newObject.position = new Vector3(posX, 2, posZ); //newObject.position.y
            newObject.transform.Translate(Time.deltaTime * 20 * Vector3.forward);
        }
    }
}
