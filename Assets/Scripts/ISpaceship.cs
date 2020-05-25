using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface ISpaceship
{
    
    
    bool isPlayer { get; set; }
    Spaceship.Color color { get; set; }
    float movementSpeed { get; set; }
    float horizontalLimit { get; set; }
    float shotDelay { get; set; }
    float shotTimer { get; set; }

}
