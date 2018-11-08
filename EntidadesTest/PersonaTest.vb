Imports Entidades

Module PersonaTest
    Friend Sub MostrarTodasLasAsignaturas(profesor As Persona)
        Console.WriteLine("Mostrar todas las asignaturas de " & profesor.ToString)
        For Each a In profesor.GetAllAsignaturas
            Console.WriteLine(a)
        Next
    End Sub
End Module
