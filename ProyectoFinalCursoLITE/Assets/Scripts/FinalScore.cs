using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour {

    Text score;
    // Use this for initialization
    void Start()
    {
        score = GetComponent<Text>();
        score.text = ScoreScript.TotalScore.ToString();
    }

   
}
