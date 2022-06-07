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
  class SimpleBall : SpriteNode
  {
    // your private fields here

    private float xspeed = 600;
    private float yspeed = 600;
    private float scr_width = Settings.ScreenSize.X;
    private float scr_height = Settings.ScreenSize.Y;



    // constructor + call base constructor
    public SimpleBall() : base("resources/bigball.png")
    {
      Position = new Vector2(scr_width / 2, scr_height / 4);
      Color = Color.YELLOW;
    }

    // Update is called every frame
    public override void Update(float deltaTime)
    {

      Move(deltaTime);
      BounceEdges();
    }

    // your own private methods



    private void Move(float deltaTime)
    {
      // TODO implement
      Position.X = Position.X + xspeed * deltaTime;
      Position.Y = Position.Y + yspeed * deltaTime;
    }

    private void BounceEdges()
    {

      float spr_width = TextureSize.X;
      float spr_height = TextureSize.Y;

      // TODO implement...
      switch (Position.X)
      {
        case float x when x > scr_width:
          xspeed = -xspeed;
          break;
        case float x when x < 0:
          xspeed = -xspeed;
          break;
      }
      switch (Position.Y)
      {
        case float y when y > scr_height:
          yspeed = -yspeed;
          break;
        case float y when y < 0:
          yspeed = -yspeed;
          break;
      }
    }

  }
}
