using UnityEngine;

public class LifeCycleExample : MonoBehaviour
{
    // Awake is called once when the object is created, before Start and even before OnEnable.
    private void Awake()
    {
        Debug.Log("--Awake called: Initialization that must happen even if the object is disabled.--");
    }

    // OnEnable is called every time the object or component becomes active.
    private void OnEnable()
    {
        Debug.Log("--OnEnable called: Object is active, can subscribe to events and start timers.--");
    }

    // Start is called before the first frame update after the object is enabled, if the script is enabled.
    private void Start()
    {
        Debug.Log("--Start called: Initial logic that depends on other components being initialized.--");
    }

    // Update is called once per frame — used for time-dependent logic.
    private void Update()
    {
        Debug.Log("--Update called: Per-frame update, e.g., input checking.--");
    }

    // FixedUpdate is called at fixed time intervals — best for physics.
    private void FixedUpdate()
    {
        Debug.Log("--FixedUpdate called: Physics and Rigidbody interaction logic.--");
    }

    // LateUpdate is called at the end of each frame — useful when you need to act after Update.
    private void LateUpdate()
    {
        Debug.Log("LateUpdate called: Concluding logic, e.g., camera following an object.--");
    }

    // OnDisable is called when the object or component becomes inactive.
    private void OnDisable()
    {
        Debug.Log("OnDisable called: Unsubscribing from events, stopping coroutines.--");
    }

    // OnDestroy is called before the object is destroyed.
    private void OnDestroy()
    {
        Debug.Log("OnDestroy called: Resource cleanup, logical termination of the object's operation.--");
    }
}