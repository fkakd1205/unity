using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene을 사용하기 위해

// Game3 - cat의 Controller
public class CatController : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private Animator animator;
    private float jumpForce = 700.0f;   // 점프할 때 가해지는 힘
    private float walkForce = 50.0f;    // 걸어갈 때 가해지는 힘
    private float maxWalkSpeed = 5.0f;  // 최대 속도를 지정

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        // Space bar눌렀을 때 다중 점프하는 동작 방지
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            GameObject.Find("cat_jump").GetComponent<AudioSource>().Play();  // 점프 효과음
            rigid2D.AddForce(transform.up * jumpForce);    // 고양이 점프 (방향 * 힘)
            animator.SetBool("isJumping", true);    // 애니메이션 변경
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rigid2D.velocity.x);  // cat의 현재 속도 계산

        // cat의 최대 속도 제한
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)    // key값이 1이면 scale영향 없고, -1이면 이미지 반전
        {
            transform.localScale = new Vector3(2 * key, 2, 1);
        }

        animator.speed = speedx / 5.0f;

        // 게임에서 블록 아래로 떨어진다면
        if (transform.position.y < -5.0f)
        {
            SceneManager.LoadScene("Game3_OverScene");
        }
    }

    // Update is called once per frame. Update함수보다 더 많이 호출.
    void FixedUpdate()
    {
        //Debug.DrawRay(rigid2D.position, Vector3.down, new Color(0, 0, 1)); // 빔을 쏨(게임상에서 보이진 않음), (시작위치, 빔 방향, 빔 색) 

        // (빔의 시작위치, 빔의 방향 , 빔 길이, 특정 레이어), ( 빔에 맞은 오브젝트를 특정 레이어로 한정 지어야할 때 사용 ), RaycastHit2D : Ray에 닿은 오브젝트 클래스 
        RaycastHit2D rayHit = Physics2D.Raycast(rigid2D.position, Vector3.down, 3, LayerMask.GetMask("ground"));

        // rayHit은 처음 맞은 오브젝트의 정보만 저장
        if (rigid2D.velocity.y < 0)
        { 
            // 뛰어 올랐다가 아래로 떨어질 때만 빔을 쏨
            if (rayHit.collider != null)
            { 
                //빔을 맞은 오브젝트와의 거리가 0.5보다 작을 때
                if (rayHit.distance < 0.5f)
                    animator.SetBool("isJumping", false); // 애니메이션 변경
            }
        }
    }
}
