using System.Collections;
using System.Collections.Generic;
using Firebase.Firestore;
using UnityEngine;

public class SessionGenerator : MonoBehaviour
{
    private FirebaseFirestore firestore;

    public void Awake()
    {
      firestore = FirebaseFirestore.DefaultInstance;  
    }

    public void SaveToCloud()
    {
        PredatorTrial saveData = new PredatorTrial();
        firestore.Document($"save_data/0").SetAsync(saveData);
    }

    public void LoadFromCloud()
    {
        Debug.Log("Load from cloud");
    }
}
