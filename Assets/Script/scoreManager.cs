using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int Score { get; set; }

    private Text scoreDisplay;

    // Start is called before the first frame update
    void Start()
    {
       scoreDisplay = GameObject.Find("ScoreDisplay").GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreDisplay.text = $"Score : {Score.ToString()}";
    }

}
