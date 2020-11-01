using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerationManager : MonoBehaviour
{
    public SceneGenerationManager sceneGenerationManager;

    private static int[] linesPositions = {-6, -3, 0, 3, 6};
    private int tempGeneratedScenes = 0;

    public Transform sphereModel, ennemyModel;
    private Transform[] piecesModel;


    // Start is called before the first frame update
    void Start()
    {
        piecesModel = new Transform[7];
        RandomPiecesGeneration(sphereModel);

    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(0, 0, -0.15f);

        //ennemyModel.position = Vector3.MoveTowards(ennemyModel.position, ennemyModel.position, (1 * Time.deltaTime));
        if (tempGeneratedScenes == sceneGenerationManager.generatedScenesNumber - 1)
        {
           
            RandomEnemiesGeneration(ennemyModel);
            RandomPiecesGeneration(sphereModel);
            tempGeneratedScenes = sceneGenerationManager.generatedScenesNumber;

        }
    }

    private void RandomEnemiesGeneration(Transform model)
    {
        for (int i = 0; i < 2; i++)
        {
            Transform newObject = Instantiate(model);
            float posX = RandomListPosition();
            float posZrelatif = Random.Range(0, sceneGenerationManager.sceneSize);
            float posZ = sceneGenerationManager.generatedScenesNumber * sceneGenerationManager.sceneSize + posZrelatif;

            newObject.position = new Vector3(posX, 2, posZ);
            
        }
    }

    

    private void RandomPiecesGeneration(Transform model)
    {
        float posX = RandomListPosition();
        float posZrelatif = Random.Range(-sceneGenerationManager.sceneSize / 2, sceneGenerationManager.sceneSize / 2);
        float posZ = sceneGenerationManager.generatedScenesNumber * sceneGenerationManager.sceneSize + posZrelatif;

        int rand = (int) Random.Range(3, piecesModel.Length);

        for (int i = 0; i < rand; i++)
        {
            Transform newObject = Instantiate(model);

            piecesModel[i] = newObject;
            piecesModel[i].position = new Vector3(posX, newObject.position.y, posZ+(i*5)); 
        }
    }

    private static float RandomListPosition()
    {
        int posTabX = (int)Random.Range(0, linesPositions.Length);
        float posX = (float)linesPositions[posTabX];

        return posX;
    }

}
