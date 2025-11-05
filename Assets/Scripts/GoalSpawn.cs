using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalSpawn : MonoBehaviour
{

    public GameObject Goal;
    public float Radius = 7;


    void Start()
    {
        SpawnObjectAtRandom();
    }

    void SpawnObjectAtRandom()
    {
        Vector3 randomPos = Random.insideUnitCircle * Radius;

        Instantiate(Goal, randomPos, Quaternion.identity);
    }
}
