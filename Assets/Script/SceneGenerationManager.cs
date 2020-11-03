using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGenerationManager : MonoBehaviour
{
    public Transform scenneryToDuplicate;
    public int generatedScenesNumber { get; set; } = 0;
    public float sceneSize { get; set; } = 150;

    // Start is called before the first frame update 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z > 1 + generatedScenesNumber*sceneSize)
        {
            generatedScenesNumber++;
            print($"Nouveau décors généré, no {generatedScenesNumber}");

            Transform createdScennery = Instantiate(scenneryToDuplicate);

            Vector3 tempPosition = createdScennery.position;
            tempPosition.z += generatedScenesNumber * sceneSize;
            createdScennery.position = tempPosition;
        }
    }
}
