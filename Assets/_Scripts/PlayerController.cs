using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    //Combat
    public string myName;
    public int myTeam;
    public int myState;
    public float myHealthPoint;
    public float mySpiritPoint;
    public float myPhysicalDamage;
    public float myMagicalDamage;
    public float myPhysicalArmor;
    public float myMagicalArmor;
    public float myMovementDistance;
    public float myAttackRange;
    //Non-Combat
    //public bool isRevert;
    public float nonAttackMoveSpeed;
    public Transform rotateGameObject;
    //
    public Animator getAnimator;

    void Start()
    {
        Init();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rotateGameObject.rotation = Quaternion.Euler(0.0f, 0.0f, 0.0f);
            if (Input.GetKey(KeyCode.A))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, -45.0f, 0);
            if (Input.GetKey(KeyCode.D))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, 45.0f, 0);
        }
        else if (!Input.GetKey(KeyCode.S))
        {
            if (Input.GetKey(KeyCode.A))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, -90.0f, 0);
            if (Input.GetKey(KeyCode.D))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, 90.0f, 0);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rotateGameObject.rotation = Quaternion.Euler(0.0f, 180.0f, 0);
            if (Input.GetKey(KeyCode.A))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, 215.0f, 0);
            if (Input.GetKey(KeyCode.D))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, 135.0f, 0);
        }
        else if (!Input.GetKey(KeyCode.W))
        {
            if (Input.GetKey(KeyCode.A))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, -90.0f, 0);
            if (Input.GetKey(KeyCode.D))
                rotateGameObject.rotation = Quaternion.Euler(0.0f, 90.0f, 0);
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * nonAttackMoveSpeed * Time.deltaTime;
            //getAnimator.SetInteger("KEY", 1);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += -transform.right * nonAttackMoveSpeed * Time.deltaTime;
            //getAnimator.SetInteger("KEY", 1);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += -transform.forward * nonAttackMoveSpeed * Time.deltaTime;
            //getAnimator.SetInteger("KEY", 1);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * nonAttackMoveSpeed * Time.deltaTime;
            //getAnimator.SetInteger("KEY", 1);
        }
        /*if ((Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.D)))
            getAnimator.SetInteger("KEY", 0);*/
    }

    public void Init()
    {
        getAnimator = GetComponent<Animator>();
    }
}
