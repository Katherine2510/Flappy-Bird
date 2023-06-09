using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Reflection.Emit;

public class GameController : MonoBehaviour
{

    public bool isEndGame;
    bool isStartFirstTime = true;
    int gamePoint = 0;
    public Text txtPoint;
    public GameObject pnlEndGame;
  
    public Text txtEndPoint;
    public Button btnRestart;



    // Use this for initialization
    public void Start()
    {
        Time.timeScale = 0;
        isEndGame = false;
        isStartFirstTime = true;
        pnlEndGame.SetActive(false);
   

    }

    // Update is called once per frame
    void Update()
    {
        if (isEndGame)
        {
            if (Input.GetMouseButtonDown(0) && isStartFirstTime)
            {
                StartGame();
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                Time.timeScale = 1;
            }
        }
    }

   
    public void GetPoint()
    {
        gamePoint++;
        txtPoint.text = "Point: " + gamePoint.ToString();
    }

    void StartGame()
    {
        SceneManager.LoadScene(0);
    }
  

    public void Restart()
    {
        StartGame();
    }

    public void EndGame()
    {
        isEndGame = true;
        isStartFirstTime = false; ;
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
        txtEndPoint.text = "Your point: " + gamePoint.ToString();
    }
}
