using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationLooper : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        // Get the Animator component attached to the GameObject
        animator = GetComponent<Animator>();

        // Set the isLooping parameter to true to start the welcoming animation
        animator.SetBool("isLooping", true);
        Debug.Log("Animation loop started."); // Debug statement to confirm loop start
    }

    void Update()
    {
        // Continuously check and set the animation to loop
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("YourWelcomingAnimationName"))
        {
            Debug.Log("Welcoming animation is playing."); // Confirm animation is playing
        }
        else
        {
            Debug.Log("Welcoming animation is not playing."); // Animation is not playing
            animator.SetBool("isLooping", true); // Set isLooping to true to ensure it loops
        }
    }

}
