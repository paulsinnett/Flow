using UnityEngine;
using System.Collections;

public class Brightness : MonoBehaviour
{
    public void ChangeBrightness(float brightness)
    {
        PlayerPrefs.SetFloat("brightness", brightness);
    }
}
