using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Util;

public class CloudControllerLevelTwo : MonoBehaviour
{
    [Header("Speed Values")]
    [SerializeField]
    public Speed horizontalSpeedRange;

    [SerializeField]
    public Speed verticalSpeedRange;

    public float verticalSpeed;
    public float horizontalSpeed;

    [SerializeField]
    public Boundary boundary;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        Move();
        CheckBounds();
    }

    void Move()
    {
        Vector2 newPosition = new Vector2(horizontalSpeed, verticalSpeed);
        Vector2 currentPosition = transform.position;

        currentPosition -= newPosition;
        transform.position = currentPosition;
    }

    void Reset()
    {
        horizontalSpeed = Random.Range(horizontalSpeedRange.min, horizontalSpeedRange.max);
        verticalSpeed = Random.Range(verticalSpeedRange.min, verticalSpeedRange.max);

        float randomXPosition = Random.Range(boundary.Bottom, boundary.Top);
        transform.position = new Vector2(randomXPosition, Random.Range(boundary.Right, boundary.Right + 2.0f));
    }

    void CheckBounds()
    {
        if (transform.position.x <= boundary.Left)
        {
            Reset();
        }
    }
    void CheckLevel()
    {

    }
}
