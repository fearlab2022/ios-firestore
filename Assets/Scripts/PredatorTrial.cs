using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using Firebase.Firestore;

[FirestoreData]
public class PredatorTrial: MonoBehaviour
{
    public float attacking_prob;
    public int preyPosX;
    public int preyPosY;
    public int exit5_coord;
    public int exit7_coord;
    public float exit5_prob;
    public float exit7_prob;
    public int symindex;
    public int rotate;

    //data to record
    public float trialOnsetTime;
    public float trialOffsetTime;
    public string playerState;  
    public List<(int x, int y)> playerPos; 
    public List<(int x, int y)> predatorPos; 
    public List<float> reward;
    public List<float> time;
    public float trialTotalReward; 
    private float totalReward; 
    public float escapeTime;
    public float captureTime;
    public float attackingTime;

    public PredatorTrial()
    {
        attacking_prob = 0f;
        preyPosX = 0;
        preyPosY = 0;
        exit5_coord = 0;
        exit7_coord = 0;
        exit5_prob = 0f;
        exit7_prob = 0f;
        symindex = 0;
        rotate = 0; 
    }

    public PredatorTrial(float attacking_prob, int preyPosX, int preyPosY, int exit5_coord, float exit5_prob, int exit7_coord, float exit7_prob, int symindex, int rotate)
    {
        this.attacking_prob = attacking_prob;
        this.preyPosX = preyPosX;
        this.preyPosY = preyPosY;
        this.exit5_coord = exit5_coord;  
        this.exit5_prob = exit5_prob;
        this.exit7_coord = exit7_coord;  
        this.exit7_prob = exit7_prob;
        this.symindex = symindex;
        this.rotate = rotate;
        playerPos = new List<(int x, int y)>();
        predatorPos = new List<(int x, int y)>();
        reward = new List<float>();
        time = new List<float>();
        playerState = "";
        trialTotalReward = 0f;
        TotalReward = 0f;
        trialOnsetTime = 0f; 
        trialOffsetTime = 0f;
        escapeTime = 0f;
        captureTime = 0f;
    }

    public int getPredPosX()
    {
        return preyPosX;
    }
    
    public int getPredPosY()
    {
        return preyPosY;
    }

    [FirestoreProperty]
    public float AttackingProb
    {
        get => attacking_prob;
        set => attacking_prob = value;
    }

    [FirestoreProperty]
    public int PreyPosX
    {
        get => preyPosX;
        set => preyPosX = value;
    }

    [FirestoreProperty]
    public int PreyPosY
    {
        get => preyPosY;
        set => preyPosY = value;
    }

    [FirestoreProperty]
    public int Exit5Coord
    {
        get => exit5_coord;
        set => exit5_coord = value;
    }

    [FirestoreProperty]
    public int Exit7Coord
    {
        get => exit7_coord;
        set => exit7_coord = value;
    }

    [FirestoreProperty]
    public float Exit5Prob
    {
        get => exit5_prob;
        set => exit5_prob = value;
    }

    [FirestoreProperty]
    public float Exit7Prob
    {
        get => exit7_prob;
        set => exit7_prob = value;
    }

    [FirestoreProperty]
    public int SymIndex
    {
        get => symindex;
        set => symindex = value;
    }

    [FirestoreProperty]
    public int Rotate
    {
        get => rotate;
        set => rotate = value;
    }

    [FirestoreProperty]
    public float TrialOnsetTime
    {
        get => trialOnsetTime;
        set => trialOnsetTime = value;
    }

    [FirestoreProperty]
    public float TrialOffsetTime
    {
        get => trialOffsetTime;
        set => trialOffsetTime = value;
    }

    [FirestoreProperty]
    public string PlayerState
    {
        get => playerState;
        set => playerState = value;
    }

    [FirestoreProperty]
    public List<(int x, int y)> PlayerPos
    {
        get => playerPos;
        set => playerPos = value;
    }

    [FirestoreProperty]
    public List<(int x, int y)> PredatorPos
    {
        get => predatorPos;
        set => predatorPos = value;
    }

    [FirestoreProperty]
    public List<float> Reward
    {
        get => reward;
        set => reward = value;
    }

    [FirestoreProperty]
    public List<float> Time
    {
        get => time;
        set => time = value;
    }

    [FirestoreProperty]
    public float TrialTotalReward
    {
        get => trialTotalReward;
        set => trialTotalReward = value;
    }

    [FirestoreProperty]
    public float TotalReward
    {
        get => totalReward;
        set => totalReward = value;
    }

    [FirestoreProperty]
    public float EscapeTime
    {
        get => escapeTime;
        set => escapeTime = value;
    }

    [FirestoreProperty]
    public float CaptureTime
    {
        get => captureTime;
        set => captureTime = value;
    }

    [FirestoreProperty]
    public float AttackingTime
    {
        get => attackingTime;
        set => attackingTime = value;
    }
}