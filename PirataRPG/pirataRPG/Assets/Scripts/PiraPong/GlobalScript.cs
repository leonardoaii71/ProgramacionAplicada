using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//asignar a camara
public class GlobalScript : MonoBehaviour
{
    public int leftScore;
    public int rightScore;

    public TextMesh leftScoreText;
    public TextMesh rightScoreText;
        
    
    // Start is called before the first frame update
    void Start()
    {
        leftScore = 0;
        rightScore = 0;

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void incrementScore(bool isLeftPlayer){
        if (isLeftPlayer)
        {
            leftScore++;
            leftScoreText.text = leftScore.ToString();
        }
        else
        {
            rightScore++;
            rightScoreText.text = rightScore.ToString();
        }
    }
}
