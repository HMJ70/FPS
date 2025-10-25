using UnityEngine;

public class enemydeath : MonoBehaviour
{
    public int enemyHP = 20;
    private bool enemyDead = false;
    [SerializeField] private GameObject hurteffect;
    public GameObject enemyAI;
    public GameObject enemy; 

    public void DamageEnemy(int damageAmount)
    {
        if (enemyDead) return;

        enemyHP -= damageAmount;
        //Debug.Log($"{gameObject.name} took {damageAmount} damage. Remaining HP: {enemyHP}");

        if (enemyHP <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        score.AddScore(1);
        enemyDead = true;

        if (hurteffect != null)
            hurteffect.SetActive(false);

        if (enemy != null)
        {
            Animator anim = enemy.GetComponent<Animator>();
            if (anim != null)
                anim.Play("Death_Rifle");
        }

        if (enemyAI != null)
            enemyAI.SetActive(false);

        EnemyLook look = enemy?.GetComponent<EnemyLook>();
        if (look != null)
            look.enabled = false;

        foreach (Collider col in enemy.GetComponentsInChildren<Collider>())
        {
            col.enabled = false;
        }
        //Debug.Log($"{gameObject.name} died.");
    }
}
