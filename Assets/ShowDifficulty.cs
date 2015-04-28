using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowDifficulty : MonoBehaviour
{
    Text text;
    void Start()
    {
        text = GetComponent<Text>();

        string difficulty = "easy";
        switch (PlayerPrefs.GetInt("difficulty", 1))
        {
            case 1:
                difficulty = "easy";
                break;
            case 2:
                difficulty = "medium";
                break;
            case 3:
                difficulty = "hard";
                break;
        }

        text.text = string.Format("Difficulty {0}", difficulty);
    }
}
