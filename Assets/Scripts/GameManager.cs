using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    public GameObject menu;
    public GameObject gameOverPanel;
    public GameObject gameOver;
    public int startNum;
    
    public int totalTime = 60;
    public GameObject time;
    private float remainTime;
    private Text timeText;

    public GameObject score;
    private int totalScore;
    private Text scoreText;

    public List<GameObject> cubes;
    private bool isOver;
    public GameObject cubeSet;
    private void Awake()
    {
        if (instance != null)
            Destroy(gameObject);
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        timeText = time.GetComponent<Text>();
        Time.timeScale = 0;
        scoreText = score.GetComponent<Text>();
        totalScore = 0;
    }

    // Update is called once per frame
    void Update()
    {
        remainTime = totalTime - Time.timeSinceLevelLoad;
        timeText.text = remainTime.ToString("00");
        if (remainTime <= 0) GameOver();
    }

    public void closeMenu()
    {
        menu.SetActive(false);
        score.SetActive(true);
        time.SetActive(true);
        Time.timeScale = 1;
        isOver = false;
        for (int i = 0; i < startNum; i++)
        {
            createCube();
        }
    }

    private void GameOver()
    {
        gameOverPanel.SetActive(true);
        gameOver.SetActive(true);
        Destroy(cubeSet);
        Time.timeScale = 0;
        isOver = true;
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
        isOver = false;
    }

    public static void addScore(int val)
    {
        if(instance.isOver) return;
        instance.totalScore += val;
        instance.scoreText.text = instance.totalScore.ToString("000");
    }

    public static void createCube()
    {
        if(instance.isOver) return;
        int i = Random.Range(0, instance.cubes.Count);
        var rad = Random.Range(0, 6.18f);
        var r = Random.Range(3f, 10f);//5.0f;
        Vector3 pos = new Vector3(
            Mathf.Sin(rad) * r, Random.Range(-0.5f, 0.5f), Mathf.Cos(rad) * r
        );

        GameObject cur= Instantiate(instance.cubes[i], pos, Quaternion.identity);
        cur.transform.SetParent(instance.cubeSet.transform);
    }
}