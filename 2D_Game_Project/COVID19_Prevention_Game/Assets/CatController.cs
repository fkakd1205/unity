using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;  // LoadScene�� ����ϱ� ����

// Game3 - cat�� Controller
public class CatController : MonoBehaviour
{
    private Rigidbody2D rigid2D;
    private Animator animator;
    private float jumpForce = 700.0f;   // ������ �� �������� ��
    private float walkForce = 50.0f;    // �ɾ �� �������� ��
    private float maxWalkSpeed = 5.0f;  // �ִ� �ӵ��� ����

    void Start()
    {
        rigid2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {

        // Space bar������ �� ���� �����ϴ� ���� ����
        if (Input.GetKeyDown(KeyCode.Space) && rigid2D.velocity.y == 0)
        {
            GameObject.Find("cat_jump").GetComponent<AudioSource>().Play();  // ���� ȿ����
            rigid2D.AddForce(transform.up * jumpForce);    // ����� ���� (���� * ��)
            animator.SetBool("isJumping", true);    // �ִϸ��̼� ����
        }

        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;

        float speedx = Mathf.Abs(rigid2D.velocity.x);  // cat�� ���� �ӵ� ���

        // cat�� �ִ� �ӵ� ����
        if (speedx < maxWalkSpeed)
        {
            rigid2D.AddForce(transform.right * key * walkForce);
        }

        if (key != 0)    // key���� 1�̸� scale���� ����, -1�̸� �̹��� ����
        {
            transform.localScale = new Vector3(2 * key, 2, 1);
        }

        animator.speed = speedx / 5.0f;

        // ���ӿ��� ��� �Ʒ��� �������ٸ�
        if (transform.position.y < -5.0f)
        {
            SceneManager.LoadScene("Game3_OverScene");
        }
    }

    // Update is called once per frame. Update�Լ����� �� ���� ȣ��.
    void FixedUpdate()
    {
        //Debug.DrawRay(rigid2D.position, Vector3.down, new Color(0, 0, 1)); // ���� ��(���ӻ󿡼� ������ ����), (������ġ, �� ����, �� ��) 

        // (���� ������ġ, ���� ���� , �� ����, Ư�� ���̾�), ( ���� ���� ������Ʈ�� Ư�� ���̾�� ���� ������� �� ��� ), RaycastHit2D : Ray�� ���� ������Ʈ Ŭ���� 
        RaycastHit2D rayHit = Physics2D.Raycast(rigid2D.position, Vector3.down, 3, LayerMask.GetMask("ground"));

        // rayHit�� ó�� ���� ������Ʈ�� ������ ����
        if (rigid2D.velocity.y < 0)
        { 
            // �پ� �ö��ٰ� �Ʒ��� ������ ���� ���� ��
            if (rayHit.collider != null)
            { 
                //���� ���� ������Ʈ���� �Ÿ��� 0.5���� ���� ��
                if (rayHit.distance < 0.5f)
                    animator.SetBool("isJumping", false); // �ִϸ��̼� ����
            }
        }
    }
}
