using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    
    private string bulletTag = "Bullet";

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (otherCollider.CompareTag(bulletTag))
            SpawnCube();
    }

    private void SpawnCube()
    {
        Instantiate(cubePrefab, GetCubePosition(), Quaternion.identity, transform.parent);
    }

    private Vector3 GetCubePosition()
    {
        var cubeYPosition = cubePrefab.transform.position.y; 
        var cubePosition = new Vector3(transform.position.x, cubeYPosition, transform.position.z);

        return cubePosition;
    }
}
