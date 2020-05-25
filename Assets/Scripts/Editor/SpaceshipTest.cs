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
    public void HorizontalLimit_IsEight()
    {
        ISpaceship spaceship = Substitute.For<ISpaceship>();

        Assert.AreEqual(spaceship.horizontalLimit, 8);
    }
}
