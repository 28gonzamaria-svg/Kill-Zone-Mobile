using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator animator;

    public void Run() { animator.SetBool("isRunning", true); }
    public void StopRun() { animator.SetBool("isRunning", false); }
    public void Jump() { animator.SetTrigger("Jump"); }
    public void Shoot() { animator.SetTrigger("Shoot"); }
    public void Reload() { animator.SetTrigger("Reload"); }
    public void StealthKill() { animator.SetTrigger("StealthKill"); }
}