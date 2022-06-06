using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private Transform targetPosition;
    
    [SerializeField] private float moveSpeed;

    private void Start()
    {
        targetPosition = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition.position, moveSpeed * Time.deltaTime);
    }
}
