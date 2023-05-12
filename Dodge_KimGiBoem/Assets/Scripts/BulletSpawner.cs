using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefeb; // ������ ź���� ���� ������

    private float spawnRate; // ź�� ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�
    private Transform target; 
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ 1.5�� ����
        spawnRate = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn ����
        timeAfterSpawn += Time.deltaTime;

        // �ֱ� ���� ������������ ������ �ð��� ���� �ֱ⺸�� ũ�ų� ���ٸ�
        if (timeAfterSpawn >= spawnRate)
        {
            // ������ �ð��� ����
            timeAfterSpawn = 0f;

            // ������ ���� ������ 1.5�� ����
            spawnRate = 1f;
            GameObject bullet = Instantiate(bulletPrefeb,transform.position,transform.rotation);
        }
    }
}
