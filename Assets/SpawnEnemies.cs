using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour
{
    public Transform enemyTemplate;

    void Start()
    {
        int numberOfEnemies = 5;
        switch (PlayerPrefs.GetInt("difficulty", 1))
        {
            case 1:
                numberOfEnemies = 5;
                break;
            case 2:
                numberOfEnemies = 10;
                break;
            case 3:
                numberOfEnemies = 15;
                break;
        }

        Vector3 position = Vector3.zero;
        for (int i = 0; i < numberOfEnemies; i++)
        {
            Instantiate(enemyTemplate, position, Quaternion.identity);
            position.x += 2f;
        }
    }
}
