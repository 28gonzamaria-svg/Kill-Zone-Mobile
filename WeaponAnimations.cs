using UnityEngine;

public class WeaponAnimations : MonoBehaviour
{
    public Animator weaponAnimator;

    public void Shoot() { weaponAnimator.SetTrigger("Shoot"); }
    public void Reload() { weaponAnimator.SetTrigger("Reload"); }
    public void Inspect() { weaponAnimator.SetTrigger("Inspect"); }
}