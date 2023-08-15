using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tower : MonoBehaviour
{
    public float cooldown;
    public float dame;
    public float rangeAttack;
    public Transform ShotPos;
    public Attack attack;

    private void Start() {
        attack = gameObject.GetComponent<Attack>();
        attack.Setup(dame,cooldown,rangeAttack,ShotPos);
    }
}
