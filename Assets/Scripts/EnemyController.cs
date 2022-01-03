using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private Vector3 targetPosition;
    private float enemySpeed;

    private void Update()
    {
        MoveToPlayer();
    }

    private void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, enemySpeed * Time.deltaTime);
    }
}
