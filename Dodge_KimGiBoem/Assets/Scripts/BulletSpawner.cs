using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefeb; // ������ ź���� ���� ������
    public float spawnRateMin = 1.4f; // �ּ� ���� �ֱ�
    public float spawnRateMax = 1.6f; // �ִ� ���� �ֱ�

    private Transform target; // �߻��� ���
    private float spawnRate; // ź�� ���� �ֱ�
    private float timeAfterSpawn; // �ֱ� ���� �������� ���� �ð�
    void Start()
    {
        // �ֱ� ���� ������ ���� �ð��� 0���� �ʱ�ȭ
        timeAfterSpawn = 0f;
        // ź�� ���� ������ spawnRateMin�� spawnRateMax ���̿��� ���� ����
        spawnRate = Random.Range(spawnRateMin, spawnRateMax);
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
            spawnRate = 1.5f;
        }
    }
}
