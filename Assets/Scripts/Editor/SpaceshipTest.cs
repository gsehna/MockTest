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
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.color = Spaceship.Color.Pink;
        spaceship.isPlayer = true;

        Assert.AreEqual(spaceship.color == Spaceship.Color.Pink, spaceship.isPlayer == true);
    }

    [Test]
    public void BlueSpaceship_IsNotPlayer()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.color = Spaceship.Color.Blue;
        spaceship.isPlayer = false;

        Assert.AreEqual(spaceship.color == Spaceship.Color.Blue, spaceship.isPlayer == false);
    }

    [Test]
    public void OrangeSpaceship_IsNotPlayer()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.color = Spaceship.Color.Orange;
        spaceship.isPlayer = false;

        Assert.AreEqual(spaceship.color == Spaceship.Color.Orange, spaceship.isPlayer == false);
    }

    [Test]
    public void MovementSpeed_Is_FourPointFive()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.movementSpeed = 4.5f;

        Assert.AreEqual(spaceship.movementSpeed, 4.5f);
    }

    [Test]
    public void HorizontalLimit_Is_Eight()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.horizontalLimit = 8f;

        Assert.AreEqual(spaceship.horizontalLimit, 8);
    }

    [Test]
    public void ShotDelay_Is_ZeroPointFive()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();
        spaceship.shotDelay = 0.5f;

        Assert.AreEqual(spaceship.shotDelay, 0.5f);
    }
}
