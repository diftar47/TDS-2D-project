using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI : MonoBehaviour
{
    [SerializeField] private GameObject mainCanvas;
    [SerializeField] private GameObject lossCanvas;
    [SerializeField] private GameObject upgradesCanvas;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text moneyText;

    private void Start()
    {
        mainCanvas.SetActive(true);
        lossCanvas.SetActive(false);
        upgradesCanvas.SetActive(false);
    }

    private void Update()
    {
        scoreText.text = string.Format("Score: {0}", Player.score);
        moneyText.text = string.Format("Money^ {0}", Player.money);
    }

    public void RestartLevel()
    {
        Player.score = 0;
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }

    public void OpenUpgradesCanvas()
    {
        mainCanvas.SetActive(false);
        upgradesCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void CloseUpgradesCanvas()
    {
        mainCanvas.SetActive(true);
        upgradesCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    public void ApplicationQuit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
