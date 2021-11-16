using UnityEngine;

public class GamepadInteractable : MonoBehaviour
{
    [SerializeField] private GameObject[] interacts;

    public void Trigger()
    {
        foreach (GameObject obj in interacts)
        {
            foreach (IInteractable interactable in obj.GetComponents<IInteractable>())
                interactable.Trigger();
        }

        Debug.Log("Gamepad Trigger");
    }
}