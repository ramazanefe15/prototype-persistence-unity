using TMPro;
using UnityEngine;

public class UIMain : MonoBehaviour
{
    public TextMeshProUGUI bestScoreText;
    public string pName;
    public int highScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        bestScoreText = GameObject.Find("Best Score").GetComponent<TextMeshProUGUI>(); 
        pName = GameManager.Instance.pName;
        highScore = GameManager.Instance.highScore;
        bestScoreText.text= "Best Score: " + pName + " : " + highScore;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
