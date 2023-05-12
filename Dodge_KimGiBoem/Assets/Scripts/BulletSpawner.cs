using UnityEngine;

public class BulletSpawner : MonoBehaviour
{
    public GameObject bulletPrefeb; // 생성할 탄알의 원본 프리팹

    private float spawnRate; // 탄알 생성 주기
    private float timeAfterSpawn; // 최근 생성 시점에서 지난 시간
    private Transform target; 
    void Start()
    {
        // 최근 생성 이후의 누적 시간을 0으로 초기화
        timeAfterSpawn = 0f;
        // 탄알 생성 간격을 1.5로 고정
        spawnRate = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        // timeAfterSpawn 갱신
        timeAfterSpawn += Time.deltaTime;

        // 최근 생성 시점에서부터 누적된 시간이 생성 주기보다 크거나 같다면
        if (timeAfterSpawn >= spawnRate)
        {
            // 누적된 시간을 리셋
            timeAfterSpawn = 0f;

            // 다음번 생성 간격을 1.5로 지정
            spawnRate = 1f;
            GameObject bullet = Instantiate(bulletPrefeb,transform.position,transform.rotation);
        }
    }
}
