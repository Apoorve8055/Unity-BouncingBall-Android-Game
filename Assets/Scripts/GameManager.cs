
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    int score;
    public Text scroeText;
    public GameObject gameStartUI;
    private void Awake(){
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart(){
        gameStartUI.SetActive(false);
        scroeText.gameObject.SetActive(true);
    }
    public void Restart(){
        SceneManager.LoadScene("SampleScene");

    }
    public void ScoreUp(){
        score++;
        scroeText.text = score.ToString();
    }
}
