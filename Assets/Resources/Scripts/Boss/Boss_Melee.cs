using UnityEngine;

public class Boss_Melee : Weapon
{
    protected override void Init()
    {
        weilder = GameObject.FindGameObjectWithTag("Boss").transform;
    }
    public void OnTriggerEnter2D(Collider2D other)
    {   
        if (other.gameObject.tag.Equals("Player"))
        {
            Debug.Log("taking damage");
            Attack(other.gameObject.GetComponent<IDamageable>());
        }

    }

}
