using System.Collections;
using UnityEngine;

//Bossクラス（＝設計図）
public class Boss
{
    private int hp = 100;       // 体力
    private int power = 25;     // 攻撃力
    private int mp = 53;        // 魔法力

    //攻撃用の関数
    //引数も返り値もない関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた！");
    }

    //防御用の関数
    //引数があり、返り値がない関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた！");
        // 残りhpを減らす
        this.hp -= damage;
    }

    //魔法攻撃用の関数
    public void Magic()
    {
        if (this.mp >= 5)
        {
            // 残りmpを減らす
            this.mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + mp + "。");
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}

//Kadaiクラス（＝本体・設計図を使うところ）
public class Kadai : MonoBehaviour
{
    void Start()
    {
        //Bossクラスの変数(lastboss)を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        // 攻撃用の関数を呼び出す
        lastboss.Attack();
        // 防御用の関数を呼び出す
        lastboss.Defence(3);
        // 魔法攻撃用の関数を呼び出す
        for (int i = 0; i < 11; i++)
        {
            lastboss.Magic();
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}