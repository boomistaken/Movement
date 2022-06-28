using System; // Console
using System.Numerics; // Vector2
using Raylib_cs; // Color

/*
In this class, we have the properties:

- Vector2  Position
- float    Rotation
- Vector2  Scale

- Vector2 TextureSize
- Vector2 Pivot
- Color Color

Methods:

- AddChild(Node child)
- RemoveChild(Node child, bool keepAlive = false)
*/

namespace Movement
{
  class SpaceShip : SpriteNode
  {
    // your private fields here (rotSpeed, thrustForce)
    private Vector2 Acceleration;
    private float rotSpeed;
    private float thrustForce;

    // constructor + call base constructor
    public SpaceShip() : base("resources/spaceship.png")
    {
      rotSpeed = (float)Math.PI; // rad/second
      thrustForce = 500;

      Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
      Color = Color.YELLOW;
    }

    public void RotateRight(float deltaTime)
    {
      Rotation += rotSpeed * deltaTime;
    }

    public void RotateLeft(float deltaTime)
    {
      Rotation -= rotSpeed * deltaTime;
    }

    public void Thrust()
    {
      // TODO implement
      Color = Color.ORANGE;
      // use thrustForce somewhere here
      float x = thrustForce * MathF.Cos(Convert.ToSingle(Rotation));
      float y = thrustForce * MathF.Sin(Convert.ToSingle(Rotation));
      Acceleration = new Vector2(x, y);
    }

    public void NoThrust()
    {
      Color = Color.YELLOW;
    }

  }
}
