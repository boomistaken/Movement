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
  class AcceleratingBall : SpriteNode
  {
    // your private fields here (add Velocity, Acceleration, and MaxSpeed)
    private Vector2 Velocity;
    private Vector2 Acceleration = new Vector2(0.06f, -0.03f);
    private float maxSpeed = 1600;

    // constructor + call base constructor
    public AcceleratingBall() : base("resources/ball.png")
    {
      Position = new Vector2(Settings.ScreenSize.X / 2, Settings.ScreenSize.Y / 4);
      Color = Color.RED;
    }

    // Update is called every frame
    public override void Update(float deltaTime)
    {
      Move(deltaTime);
      WrapEdges();
      if (Velocity.Length() > maxSpeed)
      {
        Acceleration = new Vector2(0, 0);
      }
    }

    // your own private methods
    private void Move(float deltaTime)
    {
      // TODO implement
      Position += Velocity * deltaTime;
      Velocity += Acceleration;
    }

    private void WrapEdges()
    {
      float scr_width = Settings.ScreenSize.X;
      float scr_height = Settings.ScreenSize.Y;

      // TODO implement...
      if (Position.X > scr_width)
      {
        Position = new Vector2(0, Position.Y);
      }
      else if (Position.X < 0)
      {
        Position = new Vector2(scr_width, Position.Y);
      }
      if (Position.Y > scr_height)
      {
        Position = new Vector2(Position.X, 0);
      }
      else if (Position.Y < 0)
      {
        Position = new Vector2(Position.X, scr_height);
      }

    }

  }
}
