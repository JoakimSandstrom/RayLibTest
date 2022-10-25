using System;
public class Avatar
{
    public string name = "bob";

    //POSITION
    //BILD
    //MOVEMENT

    private Rectangle rect;
    private Texture2D sprite;
    private float speed = 4.5f;

    public Avatar()
    {
        sprite = Raylib.LoadTexture("Avatar.png");
        rect = new Rectangle(0, 0, sprite.width, sprite.height);
    }
    public void Update()
    {
        //WASD
        if (Raylib.IsKeyDown(KeyboardKey.KEY_A)||Raylib.IsKeyDown(KeyboardKey.KEY_LEFT)) rect.x -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_D)||Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT)) rect.x += speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_W)||Raylib.IsKeyDown(KeyboardKey.KEY_UP)) rect.y -= speed;
        if (Raylib.IsKeyDown(KeyboardKey.KEY_S)||Raylib.IsKeyDown(KeyboardKey.KEY_DOWN)) rect.y += speed;
    }

    public void Draw()
    {
        Raylib.DrawTexture
        (
            sprite,
            (int)rect.x,
            (int)rect.y,
            Color.WHITE
        );
    }
}
