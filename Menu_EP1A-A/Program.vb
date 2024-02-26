Imports System

Module Program
    Sub Main(args As String())
        Menu()
    End Sub

    Sub Menu()
        Console.SetCursorPosition(20, 5)
        Console.WriteLine("╔══════════════════╗")
        Console.SetCursorPosition(20, 6)
        Console.WriteLine("║      NADPIS      ║")
        Console.SetCursorPosition(20, 7)
        Console.WriteLine("╠══════════════════╣")
        Console.SetCursorPosition(20, 8)
        Console.WriteLine("║ Položka 1        ║")
        Console.SetCursorPosition(20, 9)
        Console.WriteLine("║ Položka 2        ║")
        Console.SetCursorPosition(20, 10)
        Console.WriteLine("║ Položka 3        ║")
        Console.SetCursorPosition(20, 11)
        Console.WriteLine("╚══════════════════╝")
    End Sub
End Module
