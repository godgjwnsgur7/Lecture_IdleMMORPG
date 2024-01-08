using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class TitleScene : MonoBehaviour
{
    private void Start()
    {
        // PreLoad 라벨이 붙은 모든 리소스를 로드하고 콜백함수로 완료 통보를 받음
        Managers.Resource.LoadAllAsync<Object>("PreLoad", (key, count, totalCount) =>
        {
            Debug.Log($"{key} {count}/{totalCount}");

            if(count == totalCount)
            {
                // Managers.Data.Init();
            }
        });
    }
}
