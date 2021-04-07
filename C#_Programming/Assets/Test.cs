using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    private int hp;
    private int power;

    public Player(int hp, int power)
    {
        this.hp = hp;
        this.power = power;
    }

    // Player ������
    public void Attack()
    {
        Debug.Log(this.power + "�������� ������");
    }

    // Player ���� ����
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���");

    }
}

public class Rectangle
{
    private int width;
    private int height;

    public Rectangle(int width, int height)
    {
        this.width = width;
        this.height = height;
    }

    // �簢���� ���� ���ϱ�
    public void evalArea()
    {
        int area = this.width * this.height;
        Debug.Log("�簢���� ���̴� " + area);
    }

    // �簢���� �ѷ� ���ϱ�
    public void evalPerimeter()
    {
        int perimeter = (this.width + this.height) * 2;
        Debug.Log("�簢���� �ѷ��� " + perimeter);
    }
}

public class Student
{
    public const int SUBJECT_SIZE = 5;
    public string[] subjectName = { "����", "����", "����", "����", "����" };

    private int id;
    private string name;
    private int[] score = new int[SUBJECT_SIZE];

    public Student(int id, string name, int[] score)
    {
        this.id = id;
        this.name = name;
        this.score = score;
    }

    // ���� ���� ���ϱ�
    public void subjectScore()
    {
        for (int i = 0; i < subjectName.Length; i++)
        {
            Debug.Log(this.name + "�� " + subjectName[i] + " ������ : " + this.score[i] + "��");
        }
    }

    // ������ ��� ���ϱ�
    public void evalAverage()
    {
        int sum = 0;
        float average = 0;
        for (int i = 0; i < score.Length; i++)
        {
            sum += this.score[i];
        }
        average = (float)sum / score.Length;

        Debug.Log(this.name + "�� ���� ����� " + average + "�� �Դϴ�.\n");
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        // Player ����
        Player myPlayer = new Player(100, 20);
        myPlayer.Attack();
        myPlayer.Damage(30);

        // Rectangle ����
        Rectangle myRectangel = new Rectangle(10, 15);
        myRectangel.evalArea();
        myRectangel.evalPerimeter();

        // Student ����
        int[] score1 = new int[] {90, 90, 95, 100, 80};
        Student student1 = new Student(20214092, "����", score1);
        student1.subjectScore();
        student1.evalAverage();

        int[] score2 = new int[] {95, 90, 95, 95, 85, 98};
        Student student2 = new Student(20211212, "����", score2);
        student2.subjectScore();
        student2.evalAverage();
    }

    void Update()
    {
        
    }
}
