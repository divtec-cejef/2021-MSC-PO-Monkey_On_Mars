using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    static public float score;
    public float scoreOrigin;
    public GameObject monkey;

    private void Start()
    {
        //Pour faire commencer la valeur du singe à 0
        scoreOrigin = monkey.transform.position.y;
    }

    void Update()
    {
        IncreaseScore();
    }

    public void IncreaseScore()
    {
        score = monkey.transform.position.y - scoreOrigin;
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        //Afficher le score dans la TextBox
        scoreText.text = string.Format("Score: {0:0}", score);
    }

}