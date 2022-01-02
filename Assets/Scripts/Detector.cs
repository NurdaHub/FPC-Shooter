using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Detector : MonoBehaviour, IDetector
{
    public event ObjectDetectedHandler OnGameObjectDetected;
    
    public void Detect(IDetectableObject detectableObject)
    {
        detectableObject.Detected(gameObject);
        
        OnGameObjectDetected?.Invoke(gameObject, detectableObject.gameObject);
    }

    public void Detect(GameObject detectedObject)
    {
        
    }

    private void OnTriggerEnter(Collider collider)
    {
        if (IsDetectableObject(collider, out var detectedObject))
            Detect(detectedObject);
    }

    private bool IsDetectableObject(Collider collider, out IDetectableObject detectedObject)
    {
        detectedObject = collider.GetComponent<IDetectableObject>();

        return detectedObject != null;
    }
}
