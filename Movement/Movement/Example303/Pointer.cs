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
  class Pointer : SpriteNode
  {
    // your private fields here (add Velocity, Acceleration, and MaxSpeed)
    private Vector2 Velocity;
    private Vector2 Acceleration;
    private float maxSpeed = 400;

    // constructor + call base constructor
    public Pointer() : base("resources/spaceship.png")
    {
      Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 2);
      Color = Color.YELLOW;
    }

    // Update is called every frame
    public override void Update(float deltaTime)
    {
      PointToMouse(deltaTime);
    }

    // your own private methods
    private void PointToMouse(float deltaTime)
    {
      // Or just implement it in Example 110 Follower

      Vector2 mouse = Raylib.GetMousePosition();
      // Console.WriteLine(mouse);

      // Position = mouse; // incorrect!!

      // Rotation += deltaTime * Math.PI;  // incorrect!!

      Position += Velocity * deltaTime;
      Acceleration = mouse - Position;
      Acceleration = Vector2.Normalize(Acceleration);
      Velocity += Acceleration;
      Rotation = MathF.Atan2(Velocity.Y, Velocity.X);

      switch (Velocity.Length())
      {
        case float x when x > maxSpeed:
          Velocity = Vector2.Normalize(Velocity) * maxSpeed;
          break;
      }

      // TODO implement
      // Position += Velocity * deltaTime;
    }

  }
}
