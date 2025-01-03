using OpenTK.Graphics.OpenGL4;
using OpenTK.Mathematics;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

class Program
{
    static void Main()
    {
        var settings = GameWindowSettings.Default;
        var nativeSettings = new NativeWindowSettings
        {
            Size = new Vector2i(800, 600),
            Title = "OpenTK Game"
        };

        using (var window = new GameWindow(settings, nativeSettings))
        {
            window.RenderFrame += (FrameEventArgs args) =>
            {
                GL.Clear(ClearBufferMask.ColorBufferBit | ClearBufferMask.DepthBufferBit);
                window.SwapBuffers();
            };

            window.Run();
        }
    }
}

