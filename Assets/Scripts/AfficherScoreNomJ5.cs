using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AfficherScoreNomJ5 : MonoBehaviour
{ 
    public Text scoreText;
    public Text nameText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        nameText.text = SwitchToGameScene.groupeName;
        scoreText.text = string.Format("{0:0}", (int)ScoreDisplay.score);


    }
}
