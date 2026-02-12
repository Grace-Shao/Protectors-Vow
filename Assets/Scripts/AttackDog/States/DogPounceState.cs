using UnityEditor.Rendering;
using UnityEngine;

public class DogPounceState : State
{
    private DogStateMachine dogContext;
    public DogPounceState(DogStateMachine currentContext) : base(currentContext)
    {
        
        dogContext = currentContext;
    }
    public override void EnterState()
    {
        dogContext.InAttack = true;
        dogContext.Anim.Play("Pounce");
        dogContext.AppliedMovementX = 0f;
    }
    public override void UpdateState()
    {
        CheckSwitchStates();
    }
    public override void ExitState()
    {
        dogContext.InAttack = false;
    }

    public override void CheckSwitchStates()
    {
        Debug.Log(dogContext);
        if (dogContext.IsStunned)
        {
            SwitchState(new DogStunState(dogContext));
        }
        else if (!dogContext.InAttack)
        {
            SwitchState(new DogWalkState(dogContext));
        }
    }
}
