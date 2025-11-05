using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class enemy : MonoBehaviour
{
    [Header("Movement Settings")]
    [Tooltip("Time (in seconds) it takes to move one tile.")]
    public float moveTime = 0.2f;

    private Rigidbody2D rb2D;
    private float inverseMoveTime;
    private Vector2 targetPosition;

    private void Awake()
    {
        {
            rb2D = this.gameObject.GetComponent<Rigidbody2D>();
        }
    }

    void Start()
    {
        inverseMoveTime = 1f / moveTime;

        targetPosition = rb2D.position;
    }

    public void TakeTurn()
    {
        GameObject.FindWithTag("Player");

        Vector2[] directions = { Vector2.up, Vector2.down, Vector2.left, Vector2.right };
        Vector2 directionToPlayer = ((Vector2)(transform.position - transform.position)).normalized;
        Vector2 targetPosition = (Vector2)transform.position + directionToPlayer;

        rb2D.MovePosition(targetPosition);

        Debug.Log("Enemy moved towards player.");
    }
}
