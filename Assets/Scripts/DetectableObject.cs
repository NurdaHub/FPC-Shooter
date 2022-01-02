using UnityEngine;

public class DetectableObject : MonoBehaviour, IDetectableObject
{
    public event ObjectDetectedHandler OnGameObjectDetected;
    public void Detected(GameObject detectionSource)
    {
        OnGameObjectDetected?.Invoke(detectionSource, gameObject);
    }
}
