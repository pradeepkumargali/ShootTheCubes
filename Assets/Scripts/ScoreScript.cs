using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreScript : MonoBehaviour {

    public Text scoreText;
    private int counter = 100;
    // Use this for initialization
    void Start () {
        scoreText.text = "SCORE = " + CubeBehaviorScript.score.ToString();
    }
	// Update is called once per frame
	void Update () {
        scoreText.text = "SCORE = " + CubeBehaviorScript.score.ToString();
    }
}
