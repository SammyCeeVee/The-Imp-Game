using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class ScorePlusser : MonoBehaviour {

	
    //This is the score
    static public float score = 0;
    static public float topScore = 0;

    public Text scoreText;
    public Text topScoreText;
    public Text goldText;
    // Use this for initialization
    void Start ()
    {
	    scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        Score();
	}

    void Score()
    {
        //if (!Pause.isPaused)
        //{
        //    score += Time.deltaTime * 10;
        //}
        scoreText.text = "\nScore:  " + score.ToString("F0");
        topScoreText.text = "\nTop:  " + topScore.ToString("F0");
        goldText.text = "\nGold:  " + GoldManager.goldNum.ToString("F0");
        if (score >= topScore)
        {
            topScore = score;
        }
    }

           
}
