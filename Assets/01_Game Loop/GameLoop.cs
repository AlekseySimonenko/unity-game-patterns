using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public enum GameLoopType { UPDATE, DELTAUPDATE, FIXEDUPDATE, COSTUM }
    public GameLoopType LoopType;
    public enum FrameRateType { FIXED5, FIXED60, UNFIXED }
    public FrameRateType FrameRate;
    public Mover mover;
    public int TargetFrameRate;

    // Start is called before the first frame update
    void Start()
    {
        if (FrameRate == FrameRateType.FIXED5)
            Application.targetFrameRate = 5;
        if (FrameRate == FrameRateType.FIXED60)
            Application.targetFrameRate = 60;
        if (FrameRate == FrameRateType.UNFIXED)
            Application.targetFrameRate = 0;
    }

    // Update cycle by frame time
    void Update()
    {
        float modificator;
        if (LoopType == GameLoopType.UPDATE)
        {
            modificator = 1.0f;
            UpdateMoving(modificator);
        }
        if (LoopType == GameLoopType.DELTAUPDATE)
        {
            // >>> UNSCALED DELTA TIME ! <<< 
            //In real app replace TargetFrameRate by Application.targetFrameRate
            modificator = Time.unscaledDeltaTime / (1.0f / TargetFrameRate) ;
            UpdateMoving(modificator);
        }

    }

    // Update cycle by CPU fixed time
    void FixedUpdate()
    {
        float modificator;
        if (LoopType == GameLoopType.FIXEDUPDATE)
        {
            // >>> UNSCALED FIXED DELTA TIME ! <<< 
            //In real app replace TargetFrameRate by Application.targetFrameRate
            modificator = Time.fixedUnscaledDeltaTime / (1.0f / TargetFrameRate);
            UpdateMoving(modificator);
        }
    }

    private void UpdateMoving(float modificator)
    {
        if (Input.GetKey(KeyCode.UpArrow))
            mover.MoveUp(modificator);
        if (Input.GetKey(KeyCode.DownArrow))
            mover.MoveDown(modificator);
        if (Input.GetKey(KeyCode.LeftArrow))
            mover.MoveLeft(modificator);
        if (Input.GetKey(KeyCode.RightArrow))
            mover.MoveRight(modificator);
    }

}
