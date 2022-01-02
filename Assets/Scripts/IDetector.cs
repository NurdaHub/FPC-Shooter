using UnityEngine;

public delegate void ObjectDetectedHandler(GameObject source, GameObject detectedObject);

public interface IDetector
{
    event ObjectDetectedHandler OnGameObjectDetected;

    void Detect(IDetectableObject detectableObject);
    void Detect(GameObject detectedObject);
}
