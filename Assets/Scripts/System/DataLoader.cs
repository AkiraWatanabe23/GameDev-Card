using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Networking;

[System.Serializable]
public class DataLoader
{
    [Tooltip("データシートURL")]
    [SerializeField]
    private string _sheetURL = default;

    public async void Init()
    {
        await LoadData();
        Debug.Log("読み込み完了");
    }

    private async Task LoadData()
    {
        if (_sheetURL == null)
        {
            Debug.LogError("URLが未割り当てです");
            return;
        }

        using UnityWebRequest www = UnityWebRequest.Get(_sheetURL);

        var tcs = new TaskCompletionSource<bool>();
        var asyncOperation = www.SendWebRequest();

        asyncOperation.completed += operation =>
        {
            if (www.result == UnityWebRequest.Result.ConnectionError || www.result == UnityWebRequest.Result.ProtocolError)
            {
                Debug.LogError("Error Downloading SheetData : " + www.error);
                tcs.SetException(new System.Exception("Error Downloading SheetData."));
            }
            else
            {
                // ダウンロードしたデータの解析処理を行う
                string data = www.downloadHandler.text;
                // 解析処理...

                Debug.Log(data);
                tcs.SetResult(true);
            }
        };

        await tcs.Task;
    }
}
