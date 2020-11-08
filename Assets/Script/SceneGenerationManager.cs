using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneGenerationManager : MonoBehaviour
{
    private Transform scenneryToDuplicate;
    private Transform character;

    public int generatedScenesNumber { get; set; } = 0;
    public float sceneSize { get; set; } = 150;

    // Start is called before the first frame update 
    void Start()
    {
        character = GameObject.Find("Character").GetComponent<Transform>();
        scenneryToDuplicate = GameObject.Find("Scene").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (character.transform.position.z > 1 + generatedScenesNumber*sceneSize)
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
