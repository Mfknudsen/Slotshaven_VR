using UnityEngine;

public class Gaze : MonoBehaviour
{
    [SerializeField] private float maxDistance;
    [SerializeField] private float timeToTrigger = 5;

    private Transform camTransform;
    private float currentTime;

    private void Awake()
    {
        camTransform = Camera.main.transform;
    }

    void Update()
    {
        if (Physics.Raycast(camTransform.position, camTransform.forward, out RaycastHit hit, maxDistance))
        {
            GazeInteractable[] interacts = hit.transform.gameObject.GetComponents<GazeInteractable>();

            if (interacts.Length == 0)
                currentTime = 0;
            else
                currentTime += Time.deltaTime;

            if (currentTime >= timeToTrigger)
            {
                foreach (GazeInteractable interactable in interacts)
                    interactable.Trigger();

                currentTime = -1;
            }
        }
    }
}