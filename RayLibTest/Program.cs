global using Raylib_cs;

Raylib.InitWindow(800, 600, "Världens sämsta spel");
Raylib.SetTargetFPS(60);

Avatar a = new Avatar();

while(!Raylib.WindowShouldClose())
{
    //LOGIK
    a.Update();
    //GRAFIK
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.WHITE);
    a.Draw();


    Raylib.EndDrawing();
}