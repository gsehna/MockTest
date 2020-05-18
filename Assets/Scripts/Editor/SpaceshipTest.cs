using NUnit.Framework;
using NSubstitute;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceshipTest
{
    [Test]
    public void PinkSpaceship_IsPlayer()
    {
        Spaceship spaceship = Substitute.For<Spaceship>();
        spaceship.color = Spaceship.Color.Pink;
        spaceship.isPlayer = true;

        Assert.Equals(spaceship.color == Spaceship.Color.Pink, spaceship.isPlayer == true);
    }

    [Test]
    public void BlueSpaceship_IsNotPlayer()
    {
        Spaceship spaceship = Substitute.For<Spaceship>();
        spaceship.color = Spaceship.Color.Blue;
        spaceship.isPlayer = false;

        Assert.Equals(spaceship.color == Spaceship.Color.Blue, spaceship.isPlayer == false);
    }

    [Test]
    public void OrangeSpaceship_IsNotPlayer()
    {
        Spaceship spaceship = Substitute.For<Spaceship>();
        spaceship.color = Spaceship.Color.Orange;
        spaceship.isPlayer = false;

        Assert.Equals(spaceship.color == Spaceship.Color.Orange, spaceship.isPlayer == false);
    }

    [Test]
    public void HorizontalLimit_IsEight()
    {
        Spaceship spaceship = Substitute.For<Spaceship>();

        Assert.Equals(spaceship.horizontalLimit, 8);
    }
}
