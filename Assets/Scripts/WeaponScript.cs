using UnityEngine;

public class WeaponScript : MonoBehaviour
{
   [SerializeField] private Camera _fpCamera;
   [SerializeField] private ParticleSystem _muzzleFlash;

   [SerializeField] private float _range = 100f;

   private void Update()
    {
       if (Input.GetButtonDown("Fire1")) 
       {
         Shoot();
       }
    }

    private void Shoot()
    {
     _muzzleFlash.Play();
      RaycastHit _hit;
    Physics.Raycast(_fpCamera.transform.position, _fpCamera.transform.forward, out _hit ,_range);

       Debug.Log("I hit: " + _hit.transform.name);
    }


}//class
