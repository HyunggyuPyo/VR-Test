using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauncherBulletShot : MonoBehaviour
{
    private void Start()
    {
        this.GetComponent<Rigidbody>().AddForce(transform.forward * 10f, ForceMode.Impulse);

        Destroy(this.gameObject, 2f);
    }
}
