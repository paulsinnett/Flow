using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ShowHighScore : MonoBehaviour
{
    void Start()
    {
        Text text = GetComponent<Text>();
        text.text = string.Format("{0}", PlayerPrefs.GetInt("highscore", 0));
    }
}
