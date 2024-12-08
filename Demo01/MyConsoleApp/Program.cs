// See https://aka.ms/new-console-template for more information
using MyLibrary;

namespace MyconsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        MessageWriter MyWriter = new MessageWriter();
        MyWriter.Write("Hello, Writer");

        FiggleWriter FWriter = new FiggleWriter();
        FWriter.Writer("Hello, Figgle!!!!");

    }
}

