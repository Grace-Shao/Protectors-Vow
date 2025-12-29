using UnityEngine;

public class Player_Melee : Weapon
{
    protected override void Init()
    {
        attackDamage = 20;
        weilder = GameObject.FindGameObjectWithTag("Player").transform;
        victim = GameObject.FindGameObjectWithTag("Boss").transform; //refactor later when there are more enemies
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.transform == victim)
        {
            Attack(victim.GetComponent<Boss>());
        }
    }

}
