using UnityEngine;

public interface IDetectableObject
{
    event ObjectDetectedHandler OnGameObjectDetected;
    
    GameObject gameObject { get; }

    void Detected(GameObject detectionSource);
}