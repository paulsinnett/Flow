using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{
    void Start()
    {
        Color colour = Color.green;
        switch (PlayerPrefs.GetInt("difficulty", 1))
        {
            case 1:
                colour = Color.green;
                break;
            case 2:
                colour = Color.yellow;
                break;
            case 3:
                colour = Color.red;
                break;
        }

        Renderer renderer = GetComponent<Renderer>();
        Material material = renderer.material;
        material.color = colour;
    }
}
