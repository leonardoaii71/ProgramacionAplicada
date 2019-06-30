using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreController : MonoBehaviour
{
    Dictionary<string, int> essenceScores = new Dictionary<string, int>
    {
        {"Blue",0 },
        {"Purple", 0},
        {"Yellow", 0},
        {"Green", 0},
        {"Red", 0},
        {"Orange", 0}
    };

    public TextMeshPro BlueScore;
     public TextMeshPro PurpleScore;
    public TextMeshPro RedScore;
    public TextMeshPro GreenScore;
    public TextMeshPro OrangeScore;
    public TextMeshPro YellowScore;
    
    // Start is called before the first frame update
    void Start()
    {
        ResetTextScores();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddEssence(string Tag)
    {
        essenceScores[Tag]++;

        switch (Tag)
        {
            case "Blue":
                BlueScore.text = essenceScores[Tag].ToString();
                break;
            case "Red":
                RedScore.text = essenceScores[Tag].ToString();
                break;
            case "Green":
                GreenScore.text = essenceScores[Tag].ToString();
                break;
            case "Orange":
                OrangeScore.text = essenceScores[Tag].ToString();
                break;
            case "Purple":
               PurpleScore.text = essenceScores[Tag].ToString();
                break;
            case "Yellow":
                YellowScore.text = essenceScores[Tag].ToString();
                break;
        }
    }
    public void ResetTextScores()
    {
        BlueScore.text = essenceScores["Blue"].ToString();
        RedScore.text = essenceScores["Red"].ToString();
        GreenScore.text = essenceScores["Green"].ToString();
        OrangeScore.text = essenceScores["Orange"].ToString();
        PurpleScore.text = essenceScores["Purple"].ToString();
        YellowScore.text = essenceScores["Yellow"].ToString();
    }
}
