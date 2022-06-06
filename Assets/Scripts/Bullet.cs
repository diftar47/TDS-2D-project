using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float destroyTime;

    private void Start()
    {
        StartCoroutine(DestroyBullet());
    }

    private void OnTriggerEnter2D(Collider2D colliderInfo)
    {
        if (Time.timeScale == 1)
        {
            Debug.Log("The bullet hit in " + colliderInfo);
            Destroy(colliderInfo.gameObject);
            Destroy(gameObject);
            Player.score += 1;
            Player.money += 1;
        }
    }

    private IEnumerator DestroyBullet()
    {
        for(int i = 0; i < 5;)
        {
            yield return new WaitForSeconds(destroyTime);
            Destroy(gameObject);
        }
    }
}
