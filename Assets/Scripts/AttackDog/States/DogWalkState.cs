using UnityEngine;
public class DogWalkState : State
{
    private DogStateMachine dogContext;
    public DogWalkState(DogStateMachine currentContext) : base(currentContext)
    {
        dogContext = currentContext;
    }
    public override void EnterState()
    {
        Debug.Log("We walk!");
        dogContext.Anim.Play("Walk");
        
    }
    public override void UpdateState()
    {
        Vector3 target = new Vector3(dogContext.Player.gameObject.transform.position.x, dogContext.RB.gameObject.transform.position.y, 0f);
        Vector3 currentPos = new Vector3(dogContext.RB.gameObject.transform.position.x, dogContext.RB.gameObject.transform.position.y, 0f);
        Vector3 direction = (target - currentPos).normalized;
        dogContext.AppliedMovementX = direction.x * dogContext.MoveSpeed;
        
        CheckSwitchStates();
    }
    public override void ExitState()
    {
    }

    public override void CheckSwitchStates()
    {
        Debug.Log(dogContext != null);
        if (dogContext.IsStunned)
        {   
            SwitchState(new DogStunState(dogContext));
        }
    }
}
