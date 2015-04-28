using UnityEngine;
using System.Collections;

public class Transition : MonoBehaviour
{
    public float time = 1f;
    public string nextScene;

    void Start()
    {
        Invoke("NextScene", time);
    }

    void NextScene()
    {
        Application.LoadLevel(nextScene);
    }
}
