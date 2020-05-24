using UnityEngine;
using System.Collections;

public class ScoreKeeper : MonoBehaviour {

	public TextMesh ScoreText;
    public TextMesh topScoreText;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        ScoreText.text = "Score: " + ScorePlusser.score;
        topScoreText.text = "Top: " + ScorePlusser.score;
    }
}
