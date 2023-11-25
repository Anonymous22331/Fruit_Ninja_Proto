using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject[] targets;
    public TextMeshProUGUI scoreText;

    private float spawnRate = 1.0f;
    private int score;
    

    void Start()
    {
        StartCoroutine(SpawnTarget());
        UpdateScore(0);
    }

    public void UpdateScore(int scoreAdd)
    {
        score += scoreAdd;
        scoreText.text = "Score: " + score;
    }

    IEnumerator SpawnTarget()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnRate);
            int index = Random.Range(0, targets.Length);
            Instantiate(targets[index]);
        }
    }
}
