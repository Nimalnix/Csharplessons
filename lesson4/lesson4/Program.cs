using Lesson4.Day5;

    int v1=1000;
Console.WriteLine($"v1:{v1}");
refrence.DoTask(v1);
Console.WriteLine($"v1:{v1}");
refrence.DoTaskA(ref v1);
Console.WriteLine( $"v1:{v1}");
