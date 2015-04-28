using UnityEngine;
using System.Collections;

public class Options : MonoBehaviour
{
    void Start()
    {

    }

    public void ChooseDifficulty(int difficulty)
    {
        PlayerPrefs.SetInt("difficulty", difficulty);
        Debug.Log(difficulty);
        Application.LoadLevel("Game");
    }
}
