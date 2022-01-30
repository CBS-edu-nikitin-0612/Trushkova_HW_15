// See https://aka.ms/new-console-template for more information
using Task3;

Console.WriteLine("Hello, World!");

Player player = new Player();

IRecodable recording = player as IRecodable;
recording.Record();
recording.Pause();
recording.Record();
recording.Stop();

IPlayable playering = player as IPlayable;
playering.Play();
playering.Pause();
playering.Stop();


