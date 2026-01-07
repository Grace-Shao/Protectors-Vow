using UnityEngine;

public class TriggerBattle : MonoBehaviour
{
    [SerializeField] private GameObject boss;
    [SerializeField] private GameObject battleBounds;
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            boss.GetComponent<BossStateMachine>().BeginBattle();
            battleBounds.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
