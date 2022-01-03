using UnityEngine;

public class BulletController : MonoBehaviour
{
    private float bulletSpeed = 12f;
    private float currentDistance;
    private string wallTag = "Wall";
    private string enemyTag = "Enemy";

    public void InitBullet(Vector3 _position, Quaternion _rotation)
    {
        transform.position = _position;
        transform.rotation = _rotation;
    }

    private void Update()
    {
        MoveBullet();
    }

    private void MoveBullet()
    {
        var translate = Vector3.forward * Time.deltaTime * bulletSpeed; 
        transform.Translate(translate);
    }

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag(wallTag) || otherCollider.CompareTag(enemyTag))
            gameObject.SetActive(false);
    }
}