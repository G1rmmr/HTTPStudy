using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// 1. ������ ���� ->������ ������ ����
class Data
{
    public string nickname;
	public int level;
	public int coin = 100;
	public bool skill;
    // �����ϰ� ���� �����͸� Ŭ����ȭ ��Ŵ
}

public class JSONTest : MonoBehaviour
{
    Data Player = new Data() {
		nickname = "G1rmmr",
        level = 1,
        coin = 100,
        skill = false
	};

    void Start()
    {
		// 2. Json���� ��ȯ
        string JsonData = JsonUtility.ToJson(Player);
        print(JsonData);

        Data Player2 = JsonUtility.FromJson<Data>(JsonData);

		print(Player2.nickname);
		print(Player2.level);
		print(Player2.coin);
		print(Player2.skill);
	}
}