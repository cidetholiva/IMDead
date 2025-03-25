using UnityEngine;

public class POV : MonoBehaviour
{
    public Camera firstPersonCamera;
    public Camera thirdPersonCamera;

    private bool isFirstPerson = true;

    void Start()
    {
        // Start with first person view enabled
        SetView(true);
    }

    void Update()
    {
        // Toggle view when P is pressed
        if (Input.GetKeyDown(KeyCode.P))
        {
            isFirstPerson = !isFirstPerson;
            SetView(isFirstPerson);
        }
    }

    void SetView(bool firstPerson)
    {
        firstPersonCamera.enabled = firstPerson;
        thirdPersonCamera.enabled = !firstPerson;
    }
}
