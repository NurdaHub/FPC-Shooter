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

    private void OnTriggerEnter(Collider otherCollider)
    {
        if (IsDetectableObject(otherCollider, out var detectedObject))
            Detect(detectedObject);
    }

    private bool IsDetectableObject(Collider otherCollider, out IDetectableObject detectedObject)
    {
        detectedObject = otherCollider.GetComponent<IDetectableObject>();

        return detectedObject != null;
    }
}
