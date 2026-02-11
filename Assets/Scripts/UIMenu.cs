using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public TextMeshProUGUI inputText;
    void Start()
    {
        inputText = GameObject.Find("NameText").GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void LoadGame()
    {
        GameManager.Instance.pName = inputText.text;
        SceneManager.LoadScene(1);
    }
}
