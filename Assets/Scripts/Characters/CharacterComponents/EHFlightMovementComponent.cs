using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Movement component that handles movement of the character that it is attached to. In particular this handles flight logic for our character
/// 
/// NOTE: Potentially in the future we might make this just a state in the character movement mechanics. We'll see...
/// </summary>
public class EHFlightMovementComponent : EHBaseMovementComponent
{
    #region main variables
    public float Acceleration = 15f;
    public float MaxVelocity = 5f;
    #endregion main variables

    #region override methods
    protected override void UpdateVelocityFromInput(Vector2 CurrentInput, Vector2 PreviousInput)
    {
        Vector2 FlightDirection = CurrentInput.normalized;
        Vector2 GoalVelcoity = FlightDirection * MaxVelocity;

        Physics2D.Velocity = Vector2.MoveTowards(Physics2D.Velocity, GoalVelcoity, EHTime.DeltaTime * Acceleration);
    }

    // Not really needed since there are no movement types besides flight that I can think of for now
    protected override void UpdateMovementTypeFromInput(Vector2 CurrentInput)
    {
        
    }
    #endregion override methods
}
