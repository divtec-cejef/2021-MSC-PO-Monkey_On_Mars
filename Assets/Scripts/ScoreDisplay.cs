using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    static public float score;
    public float scoreOrigin;
    public GameObject monkey;
    public float posMax;

    Vector3 _lastPosition;

    private void Start()
    {
        _lastPosition = this.transform.position;

        //Pour faire commencer la valeur du singe à 0
        scoreOrigin = monkey.transform.position.y;
        posMax = monkey.transform.position.y; ;
    }

    void Update()
    {
        
        IncreaseScore();
    }

    public void IncreaseScore()
    {

        
        if (posMax >= (monkey.transform.position.y - scoreOrigin) * 7)
        {
            score =+ GetCoin.PointsCoins - LoseVaisseau.LosePoints;
        }
        else
        {

            posMax = (monkey.transform.position.y - scoreOrigin) * 7;
            score = posMax + GetCoin.PointsCoins - LoseVaisseau.LosePoints;
            if (score < 0)
            {
                score = 0;
                LoseVaisseau.LosePoints = 0;
                GetCoin.PointsCoins = 0;
            }
        }

        if ((this.transform.position.y - _lastPosition.y) > 0)
           score = (monkey.transform.position.y - scoreOrigin) * 7 + GetCoin.PointsCoins - LoseVaisseau.LosePoints;


        _lastPosition = this.transform.position;
        UpdateScoreDisplay();
        
    }

    public void UpdateScoreDisplay()
    {
        //Afficher le score dans la TextBox
        scoreText.text = string.Format("Score: {0:0}", score);
    }

}