using System.Collections;
using UnityEngine;

public class Tower : MonoBehaviour
{
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private float baseShootInterval = 1;
    private Transform target;
    public Animator animator;
    public Sprite Archer_upgrade;


    public bool Upgraded { get; private set; }

    private float shootInterval;

    void Start()
    {
        animator = GetComponent<Animator>();
        shootInterval = baseShootInterval;
        StartCoroutine(Shoot());
    }

    void Update()
    {
        GameObject[] targets = GameObject.FindGameObjectsWithTag("Enemy");
        if (targets.Length == 0)
        {
            return;
        }

        float nearestDistance = 2.5f;
        for (int i = 0; i < targets.Length; i++)
        {
            float distance = Vector2.Distance(transform.position, targets[i].transform.position);
            if (distance < nearestDistance)
            {
                animator.SetBool("Shooting", true);
                target = targets[i].transform;
                nearestDistance = distance;
            }
        }

        LookAtTarget();
    }

    void LookAtTarget()
    {
        Vector2 direction = target.position - transform.position;
        transform.rotation = Quaternion.FromToRotation(Vector3.up, direction);
    }

    IEnumerator Shoot()
    {
        while (true)
        {
            if (target != null)
            {
                GameObject projectileGameObject = Instantiate(projectilePrefab);
                Projectile projectile = projectileGameObject.GetComponent<Projectile>();
                projectileGameObject.transform.position = transform.position;
                projectile.target = target;
            }

            yield return new WaitForSeconds(shootInterval);
        }
    }

    public void UpgradeTower()
    {
        if (Upgraded) return;
        Upgraded = true;
        shootInterval = baseShootInterval / 1.5f;
        GetComponent<SpriteRenderer>().sprite = Archer_upgrade;
    }
}
