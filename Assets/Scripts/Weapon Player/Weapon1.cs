using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections;

public class SwordAttack : MonoBehaviour
{
    public Transform sword;

    public float attackSpeed = 500f; // Grad pro Sekunde
    public float startAngle = 45f;
    public float endAngle = -90f;

    bool isAttacking = false;

    void Start()
    {
        sword.localRotation = Quaternion.Euler(0, 0, startAngle);
        sword.gameObject.SetActive(false);
    }

    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && !isAttacking)
        {
            StartCoroutine(Attack());
        }
    }

    IEnumerator Attack()
    {
        isAttacking = true;
        sword.gameObject.SetActive(true);

        // nach unten schlagen
        while (Quaternion.Angle(sword.localRotation, Quaternion.Euler(0, 0, endAngle)) > 1f)
        {
            sword.localRotation = Quaternion.RotateTowards(
                sword.localRotation,
                Quaternion.Euler(0, 0, endAngle),
                attackSpeed * Time.deltaTime
            );

            yield return null;
        }

        yield return new WaitForSeconds(0.1f);

        Quaternion.Euler(0, 0, startAngle);
        sword.gameObject.SetActive(false);
        isAttacking = false;
    }
}