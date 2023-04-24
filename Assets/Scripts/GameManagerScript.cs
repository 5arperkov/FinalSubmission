using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    public GameObject[] _food;
    public Vector2 posPrefab;

    void Start() 
    {
        InvokeRepeating("LaunchFood", 2.0f, 3.0f);
        Timer.instance.StartCounting();
    }

    void LaunchFood() 
    {
        int randomFood = Random.Range(0, _food.Length);
        float pos_X = Random.Range(-posPrefab.x, posPrefab.x);
        float pos_Y = Random.Range(-posPrefab.y, posPrefab.y);
        Vector2 instantiatePosition = new Vector2(pos_X, pos_Y);
        Instantiate(_food[randomFood], new Vector3(pos_X, 0.2f, pos_Y), Quaternion.identity, gameObject.transform);
    }
}
