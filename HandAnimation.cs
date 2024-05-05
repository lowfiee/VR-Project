using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HandAnimation : MonoBehaviour
{
    [SerializeField] private InputActionReference gripReference;
        [SerializeField] private InputActionReference triggerReference;
    [SerializeField] private Animator handAnimator;
    // Update is called once per frame
    void Update()
    {
        float gripValue = gripReference.action.ReadValue<float>();
        handAnimator.SetFloat("grip", gripValue);

        float triggerValue = triggerReference.action.ReadValue<float>();
        handAnimator.SetFloat("trigger", triggerValue);
    }
}
