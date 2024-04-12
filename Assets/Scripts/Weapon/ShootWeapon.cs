using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class ShootWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _launchPosition, _bulletPrefab;
    private bool _okToShoot = false;
    private bool _shootingPaused = false;
    private InputData _inputData;
    private bool _okayToExit = true;

    // Start is called before the first frame update
    void Start()
    {
       _inputData = GetComponent<InputData>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(_okToShoot){
            if(!_shootingPaused){
                if(_inputData._rightController.TryGetFeatureValue(CommonUsages.primaryButton, out bool _aButtonPressed)){
                    if(_aButtonPressed){
                        _shootingPaused = true;
                        Fire();
                        StartCoroutine(Pause());
                    }
                }
            }
        }
        if (_okayToExit)
        {
            if(_inputData._leftController.TryGetFeatureValue(CommonUsages.secondaryButton, out bool _yButtonPressed))
            {
                if (_yButtonPressed)
                {
                    _okayToExit = false;
                    GameObject save = GameObject.Find("GameController");
                }
            }
        }
    }

    private void Fire(){
        GameObject bullet = Instantiate(_bulletPrefab) as GameObject;
        bullet.SetActive(true);
        bullet.transform.position = _launchPosition.transform.position;
        bullet.transform.rotation = _launchPosition.transform.rotation;

        bullet.GetComponent<Rigidbody>().AddForce(_launchPosition.transform.forward * 50f, ForceMode.Impulse);
    }

    IEnumerator Pause(){
        yield return new WaitForSeconds(0.5f);
        _shootingPaused = false;
    }

    public void PickUpWeaponTrigger(){
        _okToShoot = true;
    }

    public void DroppedWeaponTrigger(){
        _okToShoot = false;
    }

}
