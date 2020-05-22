using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterController : MonoBehaviour
{
    Rigidbody rb;

    Vector3 localGravity;                   // 重力の向き
    CapsuleCollider playerCollider;
    [SerializeField] float playerSpeed;     // プレイヤーの移動速度
    float jumpPower;       // ジャンプ力

    bool isJump;
    public static bool dirFlag;
    public static bool sideAttackFlag;
    public static bool underAttackFlag;
    public static bool goalFlag;
    bool deadFlag;
    bool airFlag;
    bool GameOverFlag;
    float charDir;

    private Animator animator;

    // 設定したフラグの名前
    private const string key_isRun = "IsRun";
    private const string key_isAttack01 = "IsAttack01";
    private const string key_isAttack02 = "IsAttack02";
    private const string key_isJump = "IsJump";
    private const string key_isDamage = "IsDamage";
    private const string key_isDead = "IsDead";

    [SerializeField] int rotatTime;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        this.animator = GetComponent<Animator>();
        playerCollider = GetComponent<CapsuleCollider>();
        isJump = false;
        sideAttackFlag = false;
        underAttackFlag = false;
        deadFlag = false;
        goalFlag = false;
        jumpPower = 8;
        charDir = 0f;
        dirFlag = true;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        airFlag = JumpBlock.airFlag;
        goalFlag = goalBlock.goalFlag;
        if ((!deadFlag) && (!goalFlag))
        {
            OperationKeyBoad(); // キーボード入力
            Animation();        // アニメーション処理
        }
        if (deadFlag)
        {
            GameOver();       // 死んだときの処理
        }
        if (goalFlag)
        {
            Goal();
        }
        PlayerRotate();     // プレイヤー回転処理
    }

    void PlayerRotate()
    {
        // プレイヤーの回転
        if ((!deadFlag) && (!goalFlag))
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                dirFlag = true;
                charDir = -90f;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                dirFlag = false;
                charDir = 90f;
            }
            rb.rotation = Quaternion.RotateTowards
            (transform.rotation, Quaternion.Euler(0, charDir, 0),
            Time.deltaTime * rotatTime);
        }
    }

    void OperationKeyBoad()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.position += new Vector3(playerSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.position -= new Vector3(playerSpeed, 0f, 0f);
        }
        if (airFlag)
        {
            jumpPower = 8 * 1.75f;
        }
        if (!airFlag)
        {
            jumpPower = 8;
        }
        if (Input.GetButtonDown("Jump1"))
        {
            if (!isJump)
            {
                rb.velocity = Vector3.up * jumpPower;
            }
            isJump = true;
        }
    }
    void GameOver()
    {
        SceneNavigator.Instance.Change("gameover");
    }
    void Goal()
    {
        // ゴール時の処理
        SceneNavigator.Instance.Change("clear");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("UBblock") || (collision.gameObject.CompareTag("Bblock")) || (collision.gameObject.CompareTag("jumpBlock")))
        {
            isJump = false;
        }
        if(collision.gameObject.CompareTag("jumpBlock"))
        {

        }
    }
    void Animation()
    {
        // 矢印上ボタンを押下している
        if ((Input.GetKey(KeyCode.LeftArrow)) || (Input.GetKey(KeyCode.RightArrow)))
        {
            // IdleからRunに遷移する
            this.animator.SetBool(key_isRun, true);
        }
        else
        {
            // RunからIdleに遷移する
            this.animator.SetBool(key_isRun, false);
        }

        if (Input.GetButtonDown("Jump1") && (isJump))
        {
            //Jumpに遷移する
            if (isJump)
            {
                this.animator.SetBool(key_isJump, true);
            }
        }
        else
        {
            // JumpからIdleに遷移する
            this.animator.SetBool(key_isJump, false);
        }

        if (Input.GetButtonDown("sideAttack"))
        {
            //Attack02に遷移する
            this.animator.SetBool(key_isAttack02, true);
            sideAttackFlag = true;
        }
        else
        {
            // Attack02からIdleに遷移する
            this.animator.SetBool(key_isAttack02, false);
            sideAttackFlag = false;
        }

        if (Input.GetButtonDown("underAttack"))
        {
            //Attack01に遷移する
            this.animator.SetBool(key_isAttack01, true);
            underAttackFlag = true;
        }
        else
        {
            // Attack01からIdleに遷移する
            this.animator.SetBool(key_isAttack01, false);
            underAttackFlag = false;
        }

        // 死亡
        if (time.gameoverFlag)
        {
            //Deadに遷移する
            this.animator.SetBool(key_isDead, true);
            AudioManager.instance.PlaySE("die");
            deadFlag = true;
        }
    }
}
