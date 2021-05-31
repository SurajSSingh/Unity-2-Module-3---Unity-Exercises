using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FireProjectile : MonoBehaviour
{
    public GameObject bulletPrefab;
    public float bulletActiveTime = 3;
    public float bulletPower = 10;


    public float maxAmmo = 20;
    public TextMeshProUGUI ammoText;
    public float reloadTime = 3f;

    private float ammoCount;

    void Start()
    {
        ammoCount = maxAmmo;
    }

    void Update()
    {
        if(Input.GetButton("Fire1") && ammoCount > 0)
        {
            // ADD CODE HERE

            // END OF CODE
            ammoText.text = $"Ammo: {ammoCount}";
        }


    }

    private void FireBullet(BulletScript bullet)
    {
        bullet.FireBullet(this.transform.forward, bulletPower);
    }

    public IEnumerator Reloading()
    {
        yield return new WaitForSeconds(0);
    }
}
