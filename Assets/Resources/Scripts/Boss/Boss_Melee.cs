using UnityEngine;

public class Boss_Melee : Weapon
{
    protected override void Init()
    {
        attackDamage = 20;
        weilder = GameObject.FindGameObjectWithTag("Boss").transform;
        victim = GameObject.FindGameObjectWithTag("Player").transform;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform == victim)
        {
            Attack(victim.GetComponent<PlayerStateManager>());
        }
    }

}
