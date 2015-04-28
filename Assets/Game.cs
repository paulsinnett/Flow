using UnityEngine;
using System.Collections;

public class Game : MonoBehaviour
{
    Light light;

    void Start()
    {
        float brightness = PlayerPrefs.GetFloat("brightness", 1f);
        light = GetComponent<Light>();
        light.intensity = brightness * 2f;
        Invoke("GameOver", 2f);
    }

    void GameOver()
    {
        int score = Random.Range(0, 1000);
        int highScore = PlayerPrefs.GetInt("highscore", 0);
        if (score > highScore)
        {
            PlayerPrefs.SetInt("highscore", score);
        }
        Application.LoadLevel("GameOver");
    }
}
