using UnityEngine;
using UnityEngine.UI;

public class ScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    static public float score;
    public float scoreOrigin;
    public GameObject monkey;
    public float posMax;
    private int coinsPoints;
    private int vaisseauxPoints;
    private float scoreMaxHauteur;


    private void Start()
    {
        ScoreDisplay.score = 0;
        GetCoin.PointsCoins = 0;
        LoseVaisseau.LosePoints = 0;

        //Pour faire commencer la valeur du singe à 0
        scoreOrigin = monkey.transform.position.y;
        posMax = -5;
    }

    void Update()
    {
        
        IncreaseScore();
    }

    public void IncreaseScore()
    {

         
        if (monkey.transform.position.y > posMax)
        {
            score = (monkey.transform.position.y - scoreOrigin) * 7 + GetCoin.PointsCoins - LoseVaisseau.LosePoints;
            Debug.Log(posMax);
            posMax = monkey.transform.position.y;
            scoreMaxHauteur = (monkey.transform.position.y - scoreOrigin) * 7;
        }
        else if (monkey.transform.position.y < posMax)
        {
            if (coinsPoints != GetCoin.PointsCoins || vaisseauxPoints != LoseVaisseau.LosePoints)
            {

                score = scoreMaxHauteur + GetCoin.PointsCoins - LoseVaisseau.LosePoints;
                coinsPoints = GetCoin.PointsCoins;
                vaisseauxPoints = LoseVaisseau.LosePoints;


            }


            if (score < 0)
            {
                score = 0;
                LoseVaisseau.LosePoints = 0;
                GetCoin.PointsCoins = 0;
            }
        }
        UpdateScoreDisplay();
    }

    public void UpdateScoreDisplay()
    {
        //Afficher le score dans la TextBox
        scoreText.text = string.Format("Score: {0:0}", score);
    }

}