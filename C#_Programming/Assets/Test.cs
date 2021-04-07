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

    // Player 공격함
    public void Attack()
    {
        Debug.Log(this.power + "데미지를 입혔다");
    }

    // Player 공격 당함
    public void Damage(int damage)
    {
        this.hp -= damage;
        Debug.Log(damage + "데미지를 입었다");

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

    // 사각형의 넓이 구하기
    public void evalArea()
    {
        int area = this.width * this.height;
        Debug.Log("사각형의 넓이는 " + area);
    }

    // 사각형의 둘레 구하기
    public void evalPerimeter()
    {
        int perimeter = (this.width + this.height) * 2;
        Debug.Log("사각형의 둘레는 " + perimeter);
    }
}

public class Student
{
    public const int SUBJECT_SIZE = 5;
    public string[] subjectName = { "수학", "과학", "영어", "국어", "음악" };

    private int id;
    private string name;
    private int[] score = new int[SUBJECT_SIZE];

    public Student(int id, string name, int[] score)
    {
        this.id = id;
        this.name = name;
        this.score = score;
    }

    // 과목 성적 구하기
    public void subjectScore()
    {
        for (int i = 0; i < subjectName.Length; i++)
        {
            Debug.Log(this.name + "의 " + subjectName[i] + " 성적은 : " + this.score[i] + "점");
        }
    }

    // 전과목 평균 구하기
    public void evalAverage()
    {
        int sum = 0;
        float average = 0;
        for (int i = 0; i < score.Length; i++)
        {
            sum += this.score[i];
        }
        average = (float)sum / score.Length;

        Debug.Log(this.name + "의 성적 평균은 " + average + "점 입니다.\n");
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        // Player 생성
        Player myPlayer = new Player(100, 20);
        myPlayer.Attack();
        myPlayer.Damage(30);

        // Rectangle 생성
        Rectangle myRectangel = new Rectangle(10, 15);
        myRectangel.evalArea();
        myRectangel.evalPerimeter();

        // Student 생성
        int[] score1 = new int[] {90, 90, 95, 100, 80};
        Student student1 = new Student(20214092, "지수", score1);
        student1.subjectScore();
        student1.evalAverage();

        int[] score2 = new int[] {95, 90, 95, 95, 85, 98};
        Student student2 = new Student(20211212, "제니", score2);
        student2.subjectScore();
        student2.evalAverage();
    }

    void Update()
    {
        
    }
}
