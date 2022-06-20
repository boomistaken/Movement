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
  class BouncingBall : SpriteNode
  {
    // your private fields here (add Velocity, Acceleration, addForce method)
    private Vector2 Velocity;
    private Vector2 Acceleration;

    // constructor + call base constructor
    public BouncingBall() : base("resources/ball.png")
    {
      Position = new Vector2(Settings.ScreenSize.X / 6, Settings.ScreenSize.Y / 4);
      Color = Color.BLUE;
    }

    // Update is called every frame
    public override void Update(float deltaTime)
    {
      Fall(deltaTime);
      BounceEdges();
    }

    // your own private methods
    private void Fall(float deltaTime)
    {
      // TODO implement
      // Position += Velocity * deltaTime;

      Vector2 wind = new Vector2(1.8f, 0.0f);
      Vector2 gravity = new Vector2(0.0f, 9.8f);

      AddForce(wind);
      AddForce(gravity);

      Position += Velocity * deltaTime;
      Velocity += Acceleration;
      Acceleration = Vector2.Normalize(Acceleration);
    }

    private void AddForce(Vector2 force)
    {
      // TODO implement
      Acceleration += force;
    }

    private void BounceEdges()
    {
      float scr_width = Settings.ScreenSize.X;
      float scr_height = Settings.ScreenSize.Y;
      float spr_width = TextureSize.X;
      float spr_height = TextureSize.Y;

      // TODO implement...
      switch (Position.X)
      {
        case float x when x > scr_width - spr_width:
          Position.X = scr_width - spr_width;
          Velocity.X *= -1f;
          break;
      }
      switch (Position.Y)
      {
        case float y when y > scr_height - spr_height:
          Position.Y = scr_height - spr_height;
          Velocity.Y *= -1f;
          break;
      }
    }
  }
}