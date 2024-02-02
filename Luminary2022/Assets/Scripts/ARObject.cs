using UnityEngine;

public class ARObject : MonoBehaviour
{

    [SerializeField]
    private Animator animator;

    private static readonly int ARObjectActivate = Animator.StringToHash("ARObjectActivate");
    
    public void ActivateARObject()
    {
        animator.SetTrigger(ARObjectActivate);
    }
    
}
