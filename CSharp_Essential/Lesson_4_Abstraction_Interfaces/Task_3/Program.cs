
using Task_3.Interfaces;
using Task_3.Models;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Player player = new Player();

Console.WriteLine("\nПрогравач у ружимі відтворення:");
IPlayable playablePlayer = player;
playablePlayer.Play();
playablePlayer.Pause();
playablePlayer.Stop();


Console.WriteLine("\nПрогравач у ружимі запису:");
IRecodable recodablePlayer = player;
recodablePlayer.Record();
recodablePlayer.Pause();
recodablePlayer.Stop();
