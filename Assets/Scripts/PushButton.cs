using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PushButton : MonoBehaviour
{
    [SerializeField]
    private Transform button;

    [SerializeField]
    private Transform upPosition, downPosition;

    [SerializeField]
    private float movementSpeed = 0.3f;

    public UnityEvent OnHandIn;
    public UnityEvent OnHandOut;
    private Vector3 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        button.position = upPosition.position;
        targetPosition = upPosition.position;
    }

    public void HandIn()
    {
        targetPosition = downPosition.position;
        OnHandIn?.Invoke();
    }

    public void HandOut()
    {
        targetPosition = upPosition.position;
        OnHandOut?.Invoke();
    }

    // Update is called once per frame
    void Update()
    {
        button.position = Vector3.Lerp(button.position, targetPosition, movementSpeed);
    }
}
