using UnityEngine;

public class Boss : Enemy
{
    override protected void Init()
    {
        base.Init();
        Health = 100;
        Speed = 2.5f;
        TargetDistance = 2.5f;
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.transform == player)
        {
            player.gameObject.GetComponent<PlayerStateManager>().ApplyDamage(10);
        }
    }

    override public void ApplyDamage(int damage)
    {
        base.ApplyDamage(damage);
        if (Health <= 0f)
        {
            Debug.Log("You win!");
            Time.timeScale = 0f;
        }
    }

}
