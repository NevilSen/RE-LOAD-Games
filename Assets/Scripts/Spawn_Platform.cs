﻿using UnityEngine;
using System.Collections;

public class Spawn_Platform : MonoBehaviour
{

    public int maxPlatforms = 100;
    public GameObject platform;
    public float horizontalMin = 7.5f;
    public float horizontalMax = 14f;
    public float verticalMin = 0f;
    public float verticalMax = 6;


    private Vector2 originPosition;


    void Start()
    {

        originPosition = transform.position;
        Spawn();

    }

    void Spawn()
    {
        for (int i = 0; i < maxPlatforms; i++)
        {
            Vector2 randomPosition = originPosition + new Vector2(Random.Range(horizontalMin, horizontalMax), Random.Range(verticalMin, verticalMax));
            Instantiate(platform, randomPosition, Quaternion.identity);
            originPosition = randomPosition;
        }
    }

}